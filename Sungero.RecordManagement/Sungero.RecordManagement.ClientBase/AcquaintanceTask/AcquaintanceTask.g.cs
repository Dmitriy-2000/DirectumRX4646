
// ==================================================================
// AcquaintanceTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
}

// ==================================================================
// AcquaintanceTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class AcquaintanceTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceTaskFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceTaskFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTask _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTask)this.Entity; }
    }

    public virtual void ReceiveOnCompletionValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }




    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReceiveOnCompletionFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }




    public AcquaintanceTaskClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTask entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskPerformersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskPerformers _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskPerformers)this.Entity; }
    }
    public virtual void PerformersPerformerValueInput(global::Sungero.RecordManagement.Client.AcquaintanceTaskPerformersPerformerValueInputEventArgs e) { }


    public AcquaintanceTaskPerformersClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskPerformers entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskAcquaintanceVersionsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersions _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersions)this.Entity; }
    }
    public virtual void AcquaintanceVersionsNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsHashValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsIsMainDocumentValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsDocumentIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public AcquaintanceTaskAcquaintanceVersionsClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersions entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskAcquaintersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters)this.Entity; }
    }
    public virtual void AcquaintersAcquainterValueInput(global::Sungero.RecordManagement.Client.AcquaintanceTaskAcquaintersAcquainterValueInputEventArgs e) { }


    public AcquaintanceTaskAcquaintersClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskExcludedPerformersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformers _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformers)this.Entity; }
    }
    public virtual void ExcludedPerformersExcludedPerformerValueInput(global::Sungero.RecordManagement.Client.AcquaintanceTaskExcludedPerformersExcludedPerformerValueInputEventArgs e) { }


    public AcquaintanceTaskExcludedPerformersClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformers entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskAddedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskAddedAddenda _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAddedAddenda)this.Entity; }
    }
    public virtual void AddedAddendaAddendumIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public AcquaintanceTaskAddedAddendaClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskAddedAddenda entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskRemovedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddenda _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddenda)this.Entity; }
    }
    public virtual void RemovedAddendaAddendumIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public AcquaintanceTaskRemovedAddendaClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddenda entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceTask _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTask)this.Entity; }
    }

    public AcquaintanceTaskFunctions(global::Sungero.RecordManagement.IAcquaintanceTask entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class AcquaintanceTask
  {
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.AcquaintanceTaskFunctions" />
    internal static  global::System.Boolean IsEditableDocumentFormat(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Docflow.IOfficialDocument document)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsEditableDocumentFormat", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document });
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.AcquaintanceTaskFunctions" />
    internal static  global::System.Boolean NeedShowSignRecommendation(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::System.Boolean isElectronicAcquaintance, global::Sungero.Docflow.IOfficialDocument document)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedShowSignRecommendation", new System.Type[] { typeof(global::System.Boolean), typeof(global::Sungero.Docflow.IOfficialDocument) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isElectronicAcquaintance, document });
    }

    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Boolean ValidateAcquaintanceTaskStart(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateAcquaintanceTaskStart", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void StoreAcquaintanceVersion(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Content.IElectronicDocument document, global::System.Boolean isMainDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("StoreAcquaintanceVersion", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, isMainDocument });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Boolean SchemeVersionSupportsExcludeFromAcquaintance(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SchemeVersionSupportsExcludeFromAcquaintance", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void SynchronizeAddendaAndAttachmentsGroup(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeAddendaAndAttachmentsGroup", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument> GetAddendaGroupAttachments(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddendaGroupAttachments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int32> GetAddedAddenda(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int32>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int32> GetRemovedAddenda(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRemovedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int32>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void AddedAddendaRemove(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void RemovedAddendaRemove(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  global::System.Boolean HasDocumentAndCanRead(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasDocumentAndCanRead", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceTaskFunctions" />
    internal static  void FillFromAcquaintanceList(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::Sungero.RecordManagement.IAcquaintanceList acquaintanceList)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillFromAcquaintanceList", new System.Type[] { typeof(global::Sungero.RecordManagement.IAcquaintanceList) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { acquaintanceList });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetStateView(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.Structures.AcquaintanceTask.StartValidationMessage> GetStartValidationMessage(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.RecordManagement.Structures.AcquaintanceTask.StartValidationMessage>>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetStartValidationMessage(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Company.IEmployee> GetNotAutomatedParticipants(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetNotAutomatedParticipants(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetParticipants(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetParticipants(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Boolean IsDocumentVersionReaded(global::Sungero.Docflow.IOfficialDocument document, global::System.Int32 version)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "IsDocumentVersionReaded(global::Sungero.Docflow.IOfficialDocument,global::System.Int32)"
      , document, version);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Boolean IsDocumentVersionSignatureValid(global::Sungero.Docflow.IOfficialDocument document, global::System.Int32 version)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "IsDocumentVersionSignatureValid(global::Sungero.Docflow.IOfficialDocument,global::System.Int32)"
      , document, version);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Company.IEmployee> GetAcquaintancePerformers(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetAcquaintancePerformers(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.IAcquaintanceAssignment> GetAcquaintanceAssignments(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> performers)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.RecordManagement.IAcquaintanceAssignment>>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "GetAcquaintanceAssignments(global::Sungero.RecordManagement.IAcquaintanceTask,global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)"
          , acquaintanceTask, performers);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceTaskFunctions" />
      internal static  global::System.Boolean AllAcquaintanceAssignmentsCreated(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"),
          "AllAcquaintanceAssignmentsCreated(global::Sungero.RecordManagement.IAcquaintanceTask)"
          , acquaintanceTask);
      }

    }
  }
}

// ==================================================================
// AcquaintanceTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceTaskClientPublicFunctions
  {
    public global::System.Boolean NeedShowSignRecommendation(global::Sungero.RecordManagement.IAcquaintanceTask acquaintanceTask, global::System.Boolean isElectronicAcquaintance, global::Sungero.Docflow.IOfficialDocument document)
    {
      return global::Sungero.RecordManagement.Functions.AcquaintanceTask.NeedShowSignRecommendation(acquaintanceTask, isElectronicAcquaintance, document);
    }
  }
}

// ==================================================================
// AcquaintanceTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceTask _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceTask)this.Entity; } }
    public AcquaintanceTaskActions(global::Sungero.RecordManagement.IAcquaintanceTask entity) : base(entity) { }
  }

  public partial class AcquaintanceTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceTask>(this.Entities); }
    }
  }

  public partial class AcquaintanceTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AcquaintanceTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class AcquaintanceTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
