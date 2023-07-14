
// ==================================================================
// ReviewManagerAssignmentEventArgs.g.cs
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
  public class ReviewManagerAssignmentAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ReviewManagerAssignmentAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ReviewManagerAssignmentHandlers.g.cs
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

  public partial class ReviewManagerAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IReviewManagerAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewManagerAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewManagerAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IReviewManagerAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewManagerAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ReviewManagerAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IReviewManagerAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewManagerAssignment)this.Entity; }
    }

    public virtual void ReworkDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void AddresseeValueInput(global::Sungero.RecordManagement.Client.ReviewManagerAssignmentAddresseeValueInputEventArgs e) { }


    public ReviewManagerAssignmentClientHandlers(global::Sungero.RecordManagement.IReviewManagerAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewManagerAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class ReviewManagerAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewManagerAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewManagerAssignment)this.Entity; }
    }

    public ReviewManagerAssignmentFunctions(global::Sungero.RecordManagement.IReviewManagerAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewManagerAssignmentFunctions.g.cs
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
  internal static class ReviewManagerAssignment
  {
  }
}

// ==================================================================
// ReviewManagerAssignmentClientPublicFunctions.g.cs
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
  public class ReviewManagerAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IReviewManagerAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ReviewManagerAssignmentActions.g.cs
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
  public partial class ReviewManagerAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IReviewManagerAssignment _obj { get { return (global::Sungero.RecordManagement.IReviewManagerAssignment)this.Entity; } }
    public ReviewManagerAssignmentActions(global::Sungero.RecordManagement.IReviewManagerAssignment entity) : base(entity) { }
  }

  public partial class ReviewManagerAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IReviewManagerAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IReviewManagerAssignment>(this.Entities); }
    }
  }

  public partial class ReviewManagerAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ReviewManagerAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ReviewManagerAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
