
// ==================================================================
// ReviewResolutionAssignmentEventArgs.g.cs
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
// ReviewResolutionAssignmentHandlers.g.cs
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

  public partial class ReviewResolutionAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewResolutionAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewResolutionAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ReviewResolutionAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }

    public virtual void ResolutionTextValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public ReviewResolutionAssignmentClientHandlers(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewResolutionAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class ReviewResolutionAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }

    public ReviewResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentFunctions.g.cs
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
  internal static class ReviewResolutionAssignment
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentClientPublicFunctions.g.cs
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
  public class ReviewResolutionAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IReviewResolutionAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentActions.g.cs
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
  public partial class ReviewResolutionAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj { get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; } }
    public ReviewResolutionAssignmentActions(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity) { }
  }

  public partial class ReviewResolutionAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IReviewResolutionAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IReviewResolutionAssignment>(this.Entities); }
    }
  }

  public partial class ReviewResolutionAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ReviewResolutionAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ReviewResolutionAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}