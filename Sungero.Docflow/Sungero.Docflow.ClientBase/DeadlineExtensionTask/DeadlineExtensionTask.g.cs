
// ==================================================================
// DeadlineExtensionTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class DeadlineExtensionTaskAssigneeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.CoreEntities.IUser>
  {
    public DeadlineExtensionTaskAssigneeValueInputEventArgs(global::Sungero.CoreEntities.IUser oldValue, global::Sungero.CoreEntities.IUser newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



}

// ==================================================================
// DeadlineExtensionTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

  public partial class DeadlineExtensionTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDeadlineExtensionTaskFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDeadlineExtensionTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineExtensionTaskFilteringClientHandler(global::Sungero.Docflow.IDeadlineExtensionTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineExtensionTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DeadlineExtensionTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; }
    }

    public virtual void AssigneeValueInput(global::Sungero.Docflow.Client.DeadlineExtensionTaskAssigneeValueInputEventArgs e) { }



    public virtual void CurrentDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public DeadlineExtensionTaskClientHandlers(global::Sungero.Docflow.IDeadlineExtensionTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DeadlineExtensionTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; }
    }

    public DeadlineExtensionTaskFunctions(global::Sungero.Docflow.IDeadlineExtensionTask entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class DeadlineExtensionTask
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DeadlineExtensionTaskFunctions" />
    internal static  global::System.Boolean ValidateDeadlineExtensionTaskStart(global::Sungero.Docflow.IDeadlineExtensionTask deadlineExtensionTask, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)deadlineExtensionTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateDeadlineExtensionTaskStart", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.DeadlineExtensionTask.ActionItemAssignees GetAssigneesForActionItemExecutionTask(global::Sungero.RecordManagement.IActionItemExecutionAssignment parent)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.DeadlineExtensionTask.ActionItemAssignees>(
          global::System.Guid.Parse("ef92411f-9fd6-4009-8e8f-92c8a2419a0c"),
          "GetAssigneesForActionItemExecutionTask(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , parent);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
      internal static  global::Sungero.Docflow.IDeadlineExtensionTask GetDeadlineExtension(global::Sungero.Workflow.IAssignment assignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IDeadlineExtensionTask>(
          global::System.Guid.Parse("ef92411f-9fd6-4009-8e8f-92c8a2419a0c"),
          "GetDeadlineExtension(global::Sungero.Workflow.IAssignment)"
      , assignment);
      }

    }
  }
}

// ==================================================================
// DeadlineExtensionTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class DeadlineExtensionTaskClientPublicFunctions : global::Sungero.Docflow.Client.IDeadlineExtensionTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineExtensionTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class DeadlineExtensionTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj { get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; } }
    public DeadlineExtensionTaskActions(global::Sungero.Docflow.IDeadlineExtensionTask entity) : base(entity) { }
  }

  public partial class DeadlineExtensionTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDeadlineExtensionTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDeadlineExtensionTask>(this.Entities); }
    }
  }

  public partial class DeadlineExtensionTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DeadlineExtensionTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class DeadlineExtensionTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
