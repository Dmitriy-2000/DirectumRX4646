
// ==================================================================
// DocumentReviewTaskEventArgs.g.cs
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
  public class DocumentReviewTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public DocumentReviewTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }








}

// ==================================================================
// DocumentReviewTaskHandlers.g.cs
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

  public partial class DocumentReviewTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IDocumentReviewTaskFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDocumentReviewTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentReviewTaskFilteringClientHandler(global::Sungero.RecordManagement.IDocumentReviewTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentReviewTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DocumentReviewTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; }
    }

    public virtual void AddresseeValueInput(global::Sungero.RecordManagement.Client.DocumentReviewTaskAddresseeValueInputEventArgs e) { }


    public virtual void DeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void ResolutionTextValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public virtual void NeedDeleteActionItemsValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }





    public DocumentReviewTaskClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity)
    {
    }
  }

  public partial class DocumentReviewTaskResolutionObserversClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers)this.Entity; }
    }
    public virtual void ResolutionObserversObserverValueInput(global::Sungero.RecordManagement.Client.DocumentReviewTaskResolutionObserversObserverValueInputEventArgs e) { }


    public DocumentReviewTaskResolutionObserversClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers entity) : base(entity)
    {
    }
  }

  public partial class DocumentReviewTaskAddresseesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskAddressees _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskAddressees)this.Entity; }
    }
    public virtual void AddresseesAddresseeValueInput(global::Sungero.RecordManagement.Client.DocumentReviewTaskAddresseesAddresseeValueInputEventArgs e) { }


    public virtual void AddresseesTaskCreatedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public DocumentReviewTaskAddresseesClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTaskAddressees entity) : base(entity)
    {
    }
  }

  public partial class DocumentReviewTaskAddedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddenda _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddenda)this.Entity; }
    }
    public virtual void AddedAddendaAddendumIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public DocumentReviewTaskAddedAddendaClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddenda entity) : base(entity)
    {
    }
  }

  public partial class DocumentReviewTaskRemovedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddenda _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddenda)this.Entity; }
    }
    public virtual void RemovedAddendaAddendumIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public DocumentReviewTaskRemovedAddendaClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddenda entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentReviewTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class DocumentReviewTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; }
    }

    public DocumentReviewTaskFunctions(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentReviewTaskFunctions.g.cs
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
  internal static class DocumentReviewTask
  {
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  global::Sungero.RecordManagement.IActionItemExecutionTask CreateActionItemExecution(global::Sungero.Workflow.IAssignment parentAssignment, global::Sungero.RecordManagement.IDocumentReviewTask mainTask, global::System.String resolutionText)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.Client.DocumentReviewTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CreateActionItemExecution",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Workflow.IAssignment), typeof(global::Sungero.RecordManagement.IDocumentReviewTask), typeof(global::System.String) }, null);
        return (global::Sungero.RecordManagement.IActionItemExecutionTask)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { parentAssignment, mainTask, resolutionText });
      }
      else
      {
        return global::Sungero.RecordManagement.Client.DocumentReviewTaskFunctions.CreateActionItemExecution(parentAssignment, mainTask, resolutionText);
      }
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  void CheckOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckOverdueActionItemExecutionTasks", new System.Type[] { typeof(Sungero.Workflow.Client.ExecuteResultActionArgs) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean CanPrepareDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanPrepareDraftResolution", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  void AddResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddResolution", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  void OpenDraftResolutionReport(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::System.String resolutionText, global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask> actionItems)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("OpenDraftResolutionReport", new System.Type[] { typeof(global::System.String), typeof(global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { resolutionText, actionItems });
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean ReviewStartedFromApproval(global::Sungero.Workflow.ITask task)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.Client.DocumentReviewTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ReviewStartedFromApproval",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Workflow.ITask) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { task });
      }
      else
      {
        return global::Sungero.RecordManagement.Client.DocumentReviewTaskFunctions.ReviewStartedFromApproval(task);
      }
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean ShowDeletingDraftResolutionsConfirmationDialog(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::System.String message, global::System.String description, global::System.String dialogId)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ShowDeletingDraftResolutionsConfirmationDialog", new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.String) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { message, description, dialogId });
    }

    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.Structures.DocumentReviewTask.StartValidationMessage> GetStartValidationMessages(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStartValidationMessages", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.RecordManagement.Structures.DocumentReviewTask.StartValidationMessage>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean ValidateDocumentReviewTaskStart(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateDocumentReviewTaskStart", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean IncomingDocumentRegistered(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("IncomingDocumentRegistered",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { document });
      }
      else
      {
        return global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions.IncomingDocumentRegistered(document);
      }
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean IsDocumentReviewTaskCompleted(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsDocumentReviewTaskCompleted", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask> GetDraftOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDraftOverdueActionItemExecutionTasks", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean SchemeVersionSupportsRework(global::Sungero.Workflow.ITask task)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("SchemeVersionSupportsRework",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Workflow.ITask) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { task });
      }
      else
      {
        return global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions.SchemeVersionSupportsRework(task);
      }
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SynchronizeAddressees(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Docflow.IOfficialDocument document)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeAddressees", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SetAddressees(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> addressees)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetAddressees", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addressees });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SetDeadline(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::System.Nullable<global::System.Int32> days, global::System.Nullable<global::System.Int32> hours)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetDeadline", new System.Type[] { typeof(global::System.Nullable<global::System.Int32>), typeof(global::System.Nullable<global::System.Int32>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { days, hours });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean HasDocumentAndCanRead(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasDocumentAndCanRead", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SynchronizeAddendaAndAttachmentsGroup(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeAddendaAndAttachmentsGroup", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SynchronizeAddendaToDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeAddendaToDraftResolution", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void SynchronizeDocumentReviewAddendaToActionItem(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.RecordManagement.IActionItemExecutionTask actionItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeDocumentReviewAddendaToActionItem", new System.Type[] { typeof(global::Sungero.RecordManagement.IActionItemExecutionTask) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { actionItem });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument> GetAddendaGroupAttachments(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddendaGroupAttachments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int32> GetAddedAddenda(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int32>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int32> GetRemovedAddenda(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRemovedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int32>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void AddedAddendaRemove(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void RemovedAddendaRemove(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  global::System.Boolean CurrentUserIsPerformerOrSubstitute(global::Sungero.CoreEntities.IUser performer)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "CurrentUserIsPerformerOrSubstitute(global::Sungero.CoreEntities.IUser)"
      , performer);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  global::System.String GetStateViewXml(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "GetStateViewXml(global::Sungero.RecordManagement.IDocumentReviewTask)"
          , documentReviewTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "GetStateView(global::Sungero.RecordManagement.IDocumentReviewTask)"
          , documentReviewTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  void StartActionItemsForDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Workflow.IAssignment parentAssignment)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "StartActionItemsForDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask,global::Sungero.Workflow.IAssignment)"
          , documentReviewTask, parentAssignment);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  global::System.Boolean CanAuthorPrepareResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "CanAuthorPrepareResolution(global::Sungero.RecordManagement.IDocumentReviewTask)"
          , documentReviewTask);
      }

    }
  }
}

// ==================================================================
// DocumentReviewTaskClientPublicFunctions.g.cs
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
  public class DocumentReviewTaskClientPublicFunctions : global::Sungero.RecordManagement.Client.IDocumentReviewTaskClientPublicFunctions
  {
    public void AddResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
global::Sungero.RecordManagement.Functions.DocumentReviewTask.AddResolution(documentReviewTask);
    }
  }
}

// ==================================================================
// DocumentReviewTaskActions.g.cs
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
  public partial class DocumentReviewTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj { get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; } }
    public DocumentReviewTaskActions(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity) { }
  }

  public partial class DocumentReviewTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IDocumentReviewTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IDocumentReviewTask>(this.Entities); }
    }
  }

  public partial class DocumentReviewTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DocumentReviewTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class DocumentReviewTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
