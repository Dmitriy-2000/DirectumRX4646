
// ==================================================================
// DeadlineRejectionAssignmentEventArgs.g.cs
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
}

// ==================================================================
// DeadlineRejectionAssignmentHandlers.g.cs
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

  public partial class DeadlineRejectionAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDeadlineRejectionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDeadlineRejectionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineRejectionAssignmentFilteringClientHandler(global::Sungero.Docflow.IDeadlineRejectionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineRejectionAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DeadlineRejectionAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineRejectionAssignment)this.Entity; }
    }

    public virtual void CurrentDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public DeadlineRejectionAssignmentClientHandlers(global::Sungero.Docflow.IDeadlineRejectionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DeadlineRejectionAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineRejectionAssignment)this.Entity; }
    }

    public DeadlineRejectionAssignmentFunctions(global::Sungero.Docflow.IDeadlineRejectionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentFunctions.g.cs
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
  internal static class DeadlineRejectionAssignment
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DeadlineRejectionAssignmentFunctions" />
    internal static  global::System.Boolean ValidateDeadlineRejectionAssignment(global::Sungero.Docflow.IDeadlineRejectionAssignment deadlineRejectionAssignment, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)deadlineRejectionAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateDeadlineRejectionAssignment", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

  }
}

// ==================================================================
// DeadlineRejectionAssignmentClientPublicFunctions.g.cs
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
  public class DeadlineRejectionAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IDeadlineRejectionAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineRejectionAssignmentActions.g.cs
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
  public partial class DeadlineRejectionAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IDeadlineRejectionAssignment _obj { get { return (global::Sungero.Docflow.IDeadlineRejectionAssignment)this.Entity; } }
    public DeadlineRejectionAssignmentActions(global::Sungero.Docflow.IDeadlineRejectionAssignment entity) : base(entity) { }
  }

  public partial class DeadlineRejectionAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDeadlineRejectionAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDeadlineRejectionAssignment>(this.Entities); }
    }
  }

  public partial class DeadlineRejectionAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DeadlineRejectionAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class DeadlineRejectionAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}