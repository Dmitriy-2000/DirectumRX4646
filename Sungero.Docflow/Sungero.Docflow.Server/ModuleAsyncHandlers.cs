﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow;
using Sungero.Docflow.DocumentComparisonInfo;

namespace Sungero.Docflow.Server
{
  public class ModuleAsyncHandlers
  {
    /// <summary>
    /// Сравнить документы.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void CompareDocuments(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.CompareDocumentsInvokeArgs args)
    {
      // Получить результаты сравнения.
      args.Retry = false;
      var comparisonInfoId = args.ComparisonInfoId;
      var comparisonInfo = DocumentComparisonInfos.GetAll(x => x.Id == comparisonInfoId).FirstOrDefault();
      if (comparisonInfo == null)
      {
        Logger.ErrorFormat("CompareDocuments: document comparison info not found (cmpid={0}).", comparisonInfoId);
        return;
      }
      
      if (args.RetryIteration == 0)
      {
        var firstVersionBody = Functions.Module.GetVersionBody(comparisonInfo.FirstDocumentId.Value, comparisonInfo.FirstVersionNumber.Value);
        var secondVersionBody = Functions.Module.GetVersionBody(comparisonInfo.SecondDocumentId.Value, comparisonInfo.SecondVersionNumber.Value);
        
        if (Functions.Module.IsVersionBodyEmpty(comparisonInfo.FirstDocumentId.Value, comparisonInfo.FirstVersionNumber.Value))
        {
          Logger.ErrorFormat("CompareDocuments: first document id {0}, version {1} not found (cmpid={2}).",
                             comparisonInfo.FirstDocumentId, comparisonInfo.FirstVersionNumber, comparisonInfoId);
          comparisonInfo.ProcessingStatus = Docflow.DocumentComparisonInfo.ProcessingStatus.Error;
          comparisonInfo.ErrorMessage = Resources.ErrorWhileComparingDocuments;
          comparisonInfo.Save();
          return;
        }
        
        if (Functions.Module.IsVersionBodyEmpty(comparisonInfo.SecondDocumentId.Value, comparisonInfo.SecondVersionNumber.Value))
        {
          Logger.ErrorFormat("CompareDocuments: second document id {0}, version {1} not found (cmpid={2}).",
                             comparisonInfo.SecondDocumentId, comparisonInfo.SecondVersionNumber, comparisonInfoId);
          comparisonInfo.ProcessingStatus = Docflow.DocumentComparisonInfo.ProcessingStatus.Error;
          comparisonInfo.ErrorMessage = Resources.ErrorWhileComparingDocuments;
          comparisonInfo.Save();
          return;
        }
        
        var firstVersionSize = firstVersionBody.Size;
        var secondVersionSize = secondVersionBody.Size;
        
        var documentInfoTemplate = "id - {0}, version - {1}, extension - {2}, size - {3}";
        var firstDocumentInfo = string.Format(documentInfoTemplate, comparisonInfo.FirstDocumentId, comparisonInfo.FirstVersionNumber,
                                              comparisonInfo.FirstVersionExtension, firstVersionSize);
        var secondDocumentInfo = string.Format(documentInfoTemplate, comparisonInfo.SecondDocumentId, comparisonInfo.SecondVersionNumber,
                                               comparisonInfo.SecondVersionExtension, secondVersionSize);

        Logger.DebugFormat("CompareDocuments: start async handler. First document: {0}. Second document: {1} (cmpid={2}).",
                           firstDocumentInfo, secondDocumentInfo, comparisonInfo.Id);
      }
      
      // Проверка блокировки.
      if (!Locks.TryLock(comparisonInfo))
      {
        Logger.DebugFormat("CompareDocuments: document comparison info is locked (cmpid={0}).", comparisonInfoId);
        args.Retry = true;
        return;
      }

      // Сравнение версий (итерационно).
      var processingStatus = comparisonInfo.ProcessingStatus;
      try
      {
        // При первом запуске отправить документы на конвертацию в PDF.
        if (processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.Started)
          processingStatus = Docflow.PublicFunctions.DocumentComparisonInfo.ConvertVersionsToPdf(comparisonInfo);
        
        // Проверить статус задач Ario и скачать сконвертированные документы.
        if (processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.PdfConverting)
          processingStatus = Docflow.PublicFunctions.DocumentComparisonInfo.FillPdfVersionsFromArio(comparisonInfo);
        
        // Выполнить сравнение PDF-ок.
        if (processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.PdfConverted)
          processingStatus = Docflow.PublicFunctions.DocumentComparisonInfo.ComparePdfVersions(comparisonInfo);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CompareDocuments: error while comparing documents (cmpid={0}).", ex, comparisonInfoId);
        processingStatus = Docflow.DocumentComparisonInfo.ProcessingStatus.Error;
        comparisonInfo.ProcessingStatus = processingStatus;
        comparisonInfo.ErrorMessage = Resources.ErrorWhileComparingDocuments;
        comparisonInfo.Save();
      }
      
      // Если документ еще конвертируется в Ario - перезапустить обработчик.
      if (processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.PdfConverting)
      {
        args.Retry = true;
        args.NextRetryTime = this.GetCompareDocumentsNextRetryTime(args.RetryIteration);
        Logger.DebugFormat("CompareDocuments: restart async handler, iteration: {0}, next retry time: {1} (cmpid={2}).", args.RetryIteration, args.NextRetryTime, comparisonInfoId);
      }
      
      if (Locks.GetLockInfo(comparisonInfo).IsLocked)
        Locks.Unlock(comparisonInfo);
      
      // Добавить задержку, чтобы отображение всплывающего сообщения о завершении сравнения срабатывало и в случае быстрого выполнения АО.
      if (processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.Compared || processingStatus == Docflow.DocumentComparisonInfo.ProcessingStatus.Error)
      {
        var processingTime = (int)Math.Round(Calendar.Now.Subtract(args.ProcessingStartTime).TotalMilliseconds);
        Logger.DebugFormat("CompareDocuments: end async handler. Processing time - {0} ms (cmpid={1}).", processingTime, comparisonInfoId);
        
        // Для защиты от переполнения проверить, что время положительное.
        if (processingTime > 0 && processingTime < 2500)
          System.Threading.Thread.Sleep(2500 - processingTime);
      }
    }

    /// <summary>
    /// Получить время следующей попытки сравнения документов.
    /// </summary>
    /// <param name="retryIteration">Номер итерации (начинается с нуля).</param>
    /// <returns>Время следующей попытки.</returns>
    /// <remarks>Период переповтора увеличивается в зависимости от общего времени обработки.</remarks>
    public virtual DateTime GetCompareDocumentsNextRetryTime(int retryIteration)
    {
      // Таймауты переповтора для разного времени обработки.
      var retryTimeoutBeforeOneMinute = 5;
      var retryTimeoutBeforeFiveMinutes = 10;
      var retryTimeoutBeforeOneHour = 60;
      var retryTimeoutAfterOneHour = 600;
      
      // Общее время обработки определяем по количеству переповторов с указанными выше таймаутами.
      var retryCountInOneMinute = 12;
      var retryCountInFiveMinutes = 36;
      var retryCountInOneHour = 91;
      
      if (retryIteration < retryCountInOneMinute)
        return Calendar.Now.AddSeconds(retryTimeoutBeforeOneMinute);
      
      if (retryIteration < retryCountInFiveMinutes)
        return Calendar.Now.AddSeconds(retryTimeoutBeforeFiveMinutes);
      
      if (retryIteration < retryCountInOneHour)
        return Calendar.Now.AddSeconds(retryTimeoutBeforeOneHour);
      
      return Calendar.Now.AddSeconds(retryTimeoutAfterOneHour);
    }

    public virtual void AddRegistrationStamp(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.AddRegistrationStampInvokeArgs args)
    {
      int documentId = args.DocumentId;
      int versionId = args.VersionId;
      double rightIndent = args.RightIndent;
      double bottomIndent = args.BottomIndent;
      
      Logger.DebugFormat("AddRegistrationStamp: start converting document to pdf. Document id - {0}.", documentId);
      
      var document = OfficialDocuments.GetAll(x => x.Id == documentId).FirstOrDefault();
      if (document == null)
      {
        Logger.DebugFormat("AddRegistrationStamp: document with id {0} not found.", documentId);
        return;
      }
      
      var version = document.Versions.SingleOrDefault(v => v.Id == versionId);
      if (version == null)
      {
        Logger.DebugFormat("AddRegistrationStamp: version not found. Document id - {0}, version number - {1}.", documentId, versionId);
        return;
      }
      
      if (!Locks.TryLock(version.Body))
      {
        Logger.DebugFormat("AddRegistrationStamp: version is locked. Document id - {0}, version number - {1}.", documentId, versionId);
        args.Retry = true;
        return;
      }
      
      var registrationStamp = Docflow.Functions.OfficialDocument.GetRegistrationStampAsHtml(document);
      var result = Docflow.Functions.Module.ConvertToPdfWithStamp(document, versionId, registrationStamp, false, rightIndent, bottomIndent);
      Locks.Unlock(version.Body);
      
      if (result.HasErrors)
      {
        Logger.DebugFormat("AddRegistrationStamp: {0}", result.ErrorMessage);
        if (result.HasLockError)
        {
          args.Retry = true;
        }
        else
        {
          var operation = new Enumeration(Constants.OfficialDocument.Operation.ConvertToPdf);
          document.History.Write(operation, operation, string.Empty, version.Number);
          document.Save();
        }
      }
      
      Logger.DebugFormat("AddRegistrationStamp: document {0} successfully converted to pdf.", documentId);
    }

    public virtual void ExecuteApprovalFunction(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.ExecuteApprovalFunctionInvokeArgs args)
    {
      Logger.DebugFormat("ExecuteApprovalFunction: Start for queue item id {0}. Retry iteration: {1}", args.QueueItemId, args.RetryIteration);
      
      var queueItem = ApprovalFunctionQueueItems.GetAll(t => t.Id == args.QueueItemId).FirstOrDefault();
      if (queueItem == null)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. Queue item {0} not found", args.QueueItemId);
        return;
      }

      var task = ApprovalTasks.GetAll(t => t.Id == queueItem.TaskId).FirstOrDefault();
      if (task == null)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. Task {0} not found", queueItem.TaskId);
        ApprovalFunctionQueueItems.Delete(queueItem);
        return;
      }

      if (task.Status != Docflow.ApprovalTask.Status.InProcess)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. Task status {0}", task.Status);
        ApprovalFunctionQueueItems.Delete(queueItem);
        return;
      }
      
      if (task.StartId != queueItem.TaskStartId)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. StartId was changed. Value in queue item {0}, value in task {1} ", queueItem.TaskStartId, task.StartId);
        ApprovalFunctionQueueItems.Delete(queueItem);
        return;
      }
      
      var stage = task.ApprovalRule.Stages
        .Where(s => s.StageType == Docflow.ApprovalRuleBaseStages.StageType.Function)
        .FirstOrDefault(s => s.Number == task.StageNumber);
      if (stage == null)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. Stage with type 'Function' not found, current stage number {0}", task.StageNumber);
        ApprovalFunctionQueueItems.Delete(queueItem);
        return;
      }
      
      var approvalFunctionStage = ApprovalFunctionStageBases.As(stage.StageBase);
      if (approvalFunctionStage == null)
      {
        Logger.Debug("ExecuteApprovalFunction: asynchronous handler was terminated. Property 'StageBase' is not 'ApprovalFunctionStageBase' type");
        ApprovalFunctionQueueItems.Delete(queueItem);
        return;
      }
      
      var result = Docflow.Functions.ApprovalFunctionStageBase.GetSuccessResult(approvalFunctionStage);
      
      try
      {
        result = Functions.ApprovalFunctionStageBase.Execute(approvalFunctionStage, task);
      }
      catch (Exception ex)
      {
        result = Docflow.Functions.ApprovalFunctionStageBase.GetRetryResult(approvalFunctionStage, ex.Message);
        Logger.ErrorFormat("ExecuteApprovalFunction: unhandled exception in method 'Execute'", ex);
      }
      
      queueItem = ApprovalFunctionQueueItems.GetAll(t => t.Id == args.QueueItemId).FirstOrDefault();
      if (queueItem == null)
      {
        Logger.DebugFormat("ExecuteApprovalFunction: asynchronous handler was terminated. Queue item {0} not found after execute", args.QueueItemId);
        return;
      }
      
      if (result.Success)
      {
        queueItem.ProcessingStatus = Docflow.ApprovalFunctionQueueItem.ProcessingStatus.Completed;
        queueItem.Save();
        task.Blocks.ExecuteAllMonitoringBlocks();
        Logger.Debug("ExecuteApprovalFunction: function execution result - success, processing status: completed");
      }
      else
      {
        if (!result.Retry)
        {
          queueItem.ProcessingStatus = Docflow.ApprovalFunctionQueueItem.ProcessingStatus.Error;
          queueItem.ErrorMessage = result.ErrorMessage;
          queueItem.Save();
          task.Blocks.ExecuteAllMonitoringBlocks();
          Logger.DebugFormat("ExecuteApprovalFunction: function execution result - error without retry, processing status: error, message: {0}", result.ErrorMessage);
        }
        else
        {
          args.Retry = true;
          queueItem.ErrorMessage = result.ErrorMessage;
          queueItem.Save();
          Logger.DebugFormat("ExecuteApprovalFunction: function execution result - error, asynс handler will be retried, message: {0}", result.ErrorMessage);
        }
      }
      
      Logger.DebugFormat("ExecuteApprovalFunction: Done for queue item id {0}", args.QueueItemId);
    }

    /// <summary>
    /// Установка статусов документа при прекращении задачи на согласование.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void SetDocumentStateAborted(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.SetDocumentStateAbortedInvokeArgs args)
    {
      var task = ApprovalTasks.GetAll(t => t.Id == args.TaskId).FirstOrDefault();
      if (task == null)
        return;
      
      var document = task.DocumentGroup.OfficialDocuments.FirstOrDefault();
      if (document == null)
        return;
      
      var documentTaskIds = Functions.OfficialDocument.GetTaskIdsWhereDocumentInRequredGroup(document);
      var hasNewApprovalTasks = ApprovalTasks.GetAll(t => documentTaskIds.Contains(t.Id) && t.Started > args.AbortedDate).Any();
      if (hasNewApprovalTasks)
      {
        Logger.DebugFormat("SetDocumentStateAborted: has new tasks for document {0}", document.Id);
        return;
      }
      
      if (args.NeedSetState)
      {
        Functions.ApprovalTask.SetDocumentStateAborted(task, args.SetObsolete);
        document.Save();
      }
      
      if (args.NeedGrantAccessRightsOnDocument)
        Functions.ApprovalTask.GrantAccessRightsForAttachmentsToInitiatorOnAbort(task);
    }

    /// <summary>
    /// Копирование номенклатуры дел.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void CopyCaseFiles(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.CopyCaseFilesInvokeArgs args)
    {
      PublicFunctions.CaseFile.Remote.CopyCaseFiles(args.UserId,
                                                    args.SourcePeriodStartDate, args.SourcePeriodEndDate,
                                                    args.TargetPeriodStartDate, args.TargetPeriodEndDate,
                                                    args.BusinessUnitId,
                                                    args.DepartmentId);
    }

    /// <summary>
    /// Сконвертировать документы в pdf.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void ConvertDocumentToPdf(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.ConvertDocumentToPdfInvokeArgs args)
    {
      int documentId = args.DocumentId;
      int versionId = args.VersionId;
      
      Logger.DebugFormat("ConvertDocumentToPdf: start convert document to pdf. Document id - {0}.", documentId);
      
      var document = OfficialDocuments.GetAll(x => x.Id == documentId).FirstOrDefault();
      if (document == null)
      {
        Logger.DebugFormat("ConvertDocumentToPdf: not found document with id {0}.", documentId);
        return;
      }
      
      var version = document.Versions.SingleOrDefault(v => v.Id == versionId);
      if (version == null)
      {
        Logger.DebugFormat("ConvertDocumentToPdf: not found version. Document id - {0}, version number - {1}.", documentId, versionId);
        return;
      }
      
      if (!Locks.TryLock(version.Body))
      {
        Logger.DebugFormat("ConvertDocumentToPdf: version is locked. Document id - {0}, version number - {1}.", documentId, versionId);
        args.Retry = true;
        return;
      }
      
      var result = Docflow.Functions.OfficialDocument.ConvertToPdfAndAddSignatureMark(document, version.Id);
      Locks.Unlock(version.Body);
      
      if (result.HasErrors)
      {
        Logger.DebugFormat("ConvertDocumentToPdf: {0}", result.ErrorMessage);
        if (result.HasLockError)
        {
          args.Retry = true;
        }
        else
        {
          var operation = new Enumeration(Constants.OfficialDocument.Operation.ConvertToPdf);
          document.History.Write(operation, operation, string.Empty, version.Number);
          document.Save();
        }
      }
      
      Logger.DebugFormat("ConvertDocumentToPdf: convert document {0} to pdf successfully.", documentId);
    }

    public virtual void SetDocumentStorage(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.SetDocumentStorageInvokeArgs args)
    {
      int documentId = args.DocumentId;
      int storageId = args.StorageId;
      
      Logger.DebugFormat("SetDocumentStorage: start set storage to document {0}.", documentId);
      
      var document = OfficialDocuments.GetAll(d => d.Id == documentId).FirstOrDefault();
      if (document == null)
      {
        Logger.DebugFormat("SetDocumentStorage: not found document with id {0}.", documentId);
        return;
      }
      
      var storage = Storages.GetAll(s => s.Id == storageId).FirstOrDefault();
      if (storage == null)
      {
        Logger.DebugFormat("SetDocumentStorage: not found storage with id {0}.", storageId);
        return;
      }
      
      if (Locks.GetLockInfo(document).IsLockedByOther)
      {
        Logger.DebugFormat("SetDocumentStorage: cannot change storage, document {0} is locked.", documentId);
        args.Retry = true;
        return;
      }
      
      var versions = document.Versions.Where(v => !Equals(v.Body.Storage, storage) || !Equals(v.PublicBody.Storage, storage));
      var retry = false;
      foreach (var version in versions)
      {
        if (Locks.GetLockInfo(version.Body).IsLockedByOther)
        {
          Logger.DebugFormat("SetDocumentStorage: cannot change storage, body is locked. Document {0} (version id {1}).", documentId, version.Id);
          retry = true;
        }
        if (Locks.GetLockInfo(version.PublicBody).IsLockedByOther)
        {
          Logger.DebugFormat("SetDocumentStorage: cannot change storage, public body is locked. Document {0} (version id {1}).", documentId, version.Id);
          retry = true;
        }
      }
      if (retry)
      {
        args.Retry = true;
        return;
      }
      
      try
      {
        foreach (var version in versions)
        {
          if (!Equals(version.Body.Storage, storage))
            version.Body.SetStorage(storage);
          
          if (!Equals(version.PublicBody.Storage, storage))
            version.PublicBody.SetStorage(storage);
        }
        
        document.Storage = storage;
        
        ((Domain.Shared.IExtendedEntity)document).Params[Docflow.PublicConstants.OfficialDocument.DontUpdateModified] = true;
        document.Save();
      }
      catch (Exception ex)
      {
        Logger.Error("SetDocumentStorage: cannot change storage.", ex);
        args.Retry = true;
        return;
      }
      Logger.DebugFormat("SetDocumentStorage: set storage to document {0} successfully.", documentId);
      
    }

    /// <summary>
    /// Асинхронная выдача прав на документы от правила.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void GrantAccessRightsToDocumentsByRule(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.GrantAccessRightsToDocumentsByRuleInvokeArgs args)
    {
      int ruleId = args.RuleId;
      string launchId = args.LaunchId;
      var logMessagePrefix = string.Format("AccessRightsBulkProcessing. GrantAccessRightsToDocumentsByRuleAsync. Rule(ID={0},Launch={1}), RetryIteration({2}).", ruleId, launchId, args.RetryIteration);
      Logger.DebugFormat("{0} Start creating documents queue items", logMessagePrefix);
      
      var rule = AccessRightsRules.GetAll(r => r.Id == ruleId).FirstOrDefault();
      if (rule == null)
      {
        Logger.DebugFormat("{0} No rule with this id found", logMessagePrefix);
        return;
      }

      var documents = Functions.AccessRightsRule.GetDocumentsByRule(rule);

      if (documents.Any())
      {
        var batchSize = Functions.Module.GetAccessRightsBulkProcessingBatchSize();
        Logger.DebugFormat("{0} Documents for processing: {1}. Batch size: {2}", logMessagePrefix, documents.Count, batchSize);
        
        var documentsCount = documents.Count;
        var asyncHandlersCount = Math.Ceiling((decimal)documentsCount / batchSize);
        var docsProcessed = 0;
        while (docsProcessed < documentsCount)
        {
          var batch = documents.Skip(docsProcessed).Take(batchSize).ToList();
          try
          {
            var newQueueItem = Functions.Module.CreateAccessRightsBulkQueueItem(rule.Id, launchId, batch);
            newQueueItem.Save();
          }
          catch (Exception ex)
          {
            Logger.ErrorFormat("{0} Error in creating queue item: {1}", ex, logMessagePrefix, ex.Message);
          }
          
          docsProcessed += batch.Count;
        }
        
        Logger.DebugFormat("{0} Documents queue items created successfully", logMessagePrefix);
      }
      else
        Logger.DebugFormat("{0} No documents found", logMessagePrefix);
    }
    
    /// <summary>
    /// Асинхронная выдача прав на документ.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void GrantAccessRightsToDocument(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.GrantAccessRightsToDocumentInvokeArgs args)
    {
      int documentId = args.DocumentId;
      string stringRuleIds = args.RuleIds;
      
      var document = OfficialDocuments.GetAll(d => d.Id == documentId).FirstOrDefault();
      if (document == null)
      {
        Logger.DebugFormat("GrantAccessRightsToDocument: no document with id {0}", documentId);
        return;
      }

      if (Locks.GetLockInfo(document).IsLockedByOther)
      {
        Logger.DebugFormat("GrantAccessRightsToDocument: document with id {0} is blocked", documentId);
        args.Retry = true;
        return;
      }

      var ruleIds = new List<int>();
      if (!string.IsNullOrWhiteSpace(stringRuleIds))
      {
        try
        {
          ruleIds = stringRuleIds.Split(new string[] { Constants.AccessRightsRule.DocumentIdsSeparator }, StringSplitOptions.None)
            .Select(r => int.Parse(r)).ToList();
        }
        catch
        {
          Logger.DebugFormat("GrantAccessRightsToDocument: incorrect right ids for document {0}", documentId);
          return;
        }
      }
      
      var availableRuleIds = Docflow.Functions.Module.GetAvailableRuleIds(document, ruleIds);
      if (!availableRuleIds.Any())
      {
        Logger.DebugFormat("GrantAccessRightsToDocument: no suitable rules for document {0}", documentId);
        return;
      }
      
      Logger.DebugFormat("GrantAccessRightsToDocument: start grant rights for document {0}", documentId);
      
      var isGranted = Docflow.Functions.Module.GrantAccessRightsToDocumentByRule(document, availableRuleIds, args.GrantRightToChildDocuments);
      if (!isGranted)
      {
        Logger.DebugFormat("GrantAccessRightsToDocument: cannot grant rights for document {0}", documentId);
        args.Retry = true;
      }
      else
        Logger.DebugFormat("GrantAccessRightsToDocument: done for document {0}", documentId);
    }

    /// <summary>
    /// Асинхронная пакетная выдача прав на документы.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void GrantAccessRightsToDocumentsBulk(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.GrantAccessRightsToDocumentsBulkInvokeArgs args)
    {
      int queueItemID = args.QueueItemId;
      var queueItem = AccessRightsBulkQueueItems.GetAll(l => l.Id == queueItemID).FirstOrDefault();
      if (queueItem == null)
      {
        Logger.DebugFormat("AccessRightsBulkProcessing. GrantAccessRightsToDocumentsBulkAsync. Queue item (ID={0}) not found.", queueItemID);
        return;
      }
      
      var ruleId = queueItem.RuleId;
      var logMessagePrefix = string.Format("AccessRightsBulkProcessing. GrantAccessRightsToDocumentsBulkAsync. Queue item (ID={0}). Rule(ID={1},Launch={2}).", queueItemID, ruleId, queueItem.LaunchId);
      Logger.DebugFormat("{0} Start granting access rights", logMessagePrefix);
      
      var retriesLimit = Functions.Module.GetAccessRightsBulkProcessingRetriesLimit();
      if (args.RetryIteration >= retriesLimit)
      {
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusSuspended(queueItem);
        Logger.DebugFormat("{0} Retries limit {1} reached. QueueItem processing suspended.", logMessagePrefix, retriesLimit);
        return;
      }
      
      if (!Functions.AccessRightsBulkQueueItem.SetProcessingStatusInProcess(queueItem))
      {
        Logger.DebugFormat("{0} Cannot update QueueItem status.", logMessagePrefix);
        return;
      }

      if (string.IsNullOrWhiteSpace(queueItem.DocumentsIds))
      {
        Logger.DebugFormat("{0} No document ids passed to async handler", logMessagePrefix);
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
        return;
      }

      if (!ruleId.HasValue)
      {
        Logger.DebugFormat("{0} No rule id passed to async handler", logMessagePrefix);
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
        return;
      }
      
      var rule = AccessRightsRules.GetAll(x => x.Id == ruleId).FirstOrDefault();
      if (rule == null)
      {
        Logger.DebugFormat("{0} No rule found", logMessagePrefix);
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
        return;
      }
      
      if (queueItem.LaunchId != rule.LaunchId)
      {
        Logger.DebugFormat("{0} Queue item's launch id was outdated. Rule was modified. Current rule launch id={1}", logMessagePrefix, rule.LaunchId);
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
        return;
      }
      
      var documentsIds = new List<int>();
      try
      {
        documentsIds = queueItem.DocumentsIds.Split(new string[] { Constants.AccessRightsRule.DocumentIdsSeparator }, StringSplitOptions.None).Select(x => int.Parse(x)).ToList();
      }
      catch
      {
        Logger.DebugFormat("{0} Incorrect document ids", logMessagePrefix);
        Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
        return;
      }
      
      var documents = OfficialDocuments.GetAll(x => documentsIds.Contains(x.Id));
      var documentsForRetry = new List<IOfficialDocument>();
      foreach (var document in documents)
      {
        Logger.DebugFormat("{0} Start processing for document {1}", logMessagePrefix, document.Id);
        if (Locks.GetLockInfo(document).IsLockedByOther)
        {
          documentsForRetry.Add(document);
          Logger.DebugFormat("{0} Document with id {1} is blocked", logMessagePrefix, document.Id);
          continue;
        }
        
        var ruleIds = new List<int> { ruleId.Value };
        var availableRuleIds = Docflow.Functions.Module.GetAvailableRuleIds(document, ruleIds);
        if (!availableRuleIds.Any())
        {
          Logger.DebugFormat("{0} No suitable rules for document {1}", logMessagePrefix, document.Id);
          continue;
        }
        
        var isGranted = Docflow.Functions.Module.GrantAccessRightsToDocumentByRule(document, ruleIds, false);
        if (!isGranted)
          documentsForRetry.Add(document);
      }
      
      if (documentsForRetry.Any())
      {
        try
        {
          var newQueueItem = Functions.Module.CreateAccessRightsBulkQueueItem(queueItem.RuleId.Value, queueItem.LaunchId, documentsForRetry.Select(l => l.Id).ToList());
          Functions.AccessRightsBulkQueueItem.SetLowPriority(newQueueItem);
          
          // Увеличить счетчик переповторов элемента очереди и если он превышает пороговое значение, то при следующем запуске элемент не будет обработан.
          var nextRetriesCount = queueItem.Retries.HasValue ? queueItem.Retries.Value + 1 : 1;
          newQueueItem.Retries = nextRetriesCount;
          if (nextRetriesCount >= retriesLimit)
            newQueueItem.ProcessingStatus = Docflow.AccessRightsBulkQueueItem.ProcessingStatus.Suspended;
          newQueueItem.Save();
          Logger.DebugFormat("{0} Some documents ({1}) have been sent for re-processing", logMessagePrefix, documentsForRetry.Count());
        }
        catch (Exception ex)
        {
          Logger.ErrorFormat("{0} Some documents ({1}) have not been sent for re-processing: {2}", ex, logMessagePrefix, documentsForRetry.Count(), ex.Message);
        }
      }

      Functions.AccessRightsBulkQueueItem.SetProcessingStatusProcessed(queueItem);
      Logger.DebugFormat("{0} Done", logMessagePrefix);
    }
    
    /// <summary>
    /// Очистка статуса обработки правила назначения прав.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void ClearAccessRightsRuleState(Sungero.Docflow.Server.AsyncHandlerInvokeArgs.ClearAccessRightsRuleStateInvokeArgs args)
    {
      var ruleId = args.RuleId;
      var rule = AccessRightsRules.GetAll(x => x.Id == args.RuleId).FirstOrDefault();
      if (rule == null)
      {
        Logger.DebugFormat("AccessRightsBulkProcessing. ClearStateAccessRightsRuleAsync. Rule (ID={0}) No rule found", ruleId);
        return;
      }

      var logMessagePrefix = string.Format("AccessRightsBulkProcessing. ClearStateAccessRightsRuleAsync. Rule (ID={0},Launch={1}), RetryIteration({2}).", ruleId, rule.LaunchId, args.RetryIteration);
      Logger.DebugFormat("{0} Start clearing BulkProcessingState", logMessagePrefix);
      try
      {
        rule.BulkProcessingState = null;
        rule.Save();
        Logger.DebugFormat("{0} Done", logMessagePrefix);
      }
      catch (Exception ex)
      {
        // В фоновом процессе GrantAccessRightsToDocuments при каждом запуске создается этот АО, поэтому в переповторе нет необходимости.
        Logger.DebugFormat("{0} Cannot clear BulkProcessingState: {1}", logMessagePrefix, ex.Message);
      }
    }

  }
}