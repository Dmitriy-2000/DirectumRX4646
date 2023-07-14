
// ==================================================================
// ApprovalRegistrationAssignmentEventArgs.g.cs
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
  public class ApprovalRegistrationAssignmentSignatoryValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalRegistrationAssignmentSignatoryValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalRegistrationAssignmentAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalRegistrationAssignmentAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalRegistrationAssignmentDeliveryMethodValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IMailDeliveryMethod>
  {
    public ApprovalRegistrationAssignmentDeliveryMethodValueInputEventArgs(global::Sungero.Docflow.IMailDeliveryMethod oldValue, global::Sungero.Docflow.IMailDeliveryMethod newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ApprovalRegistrationAssignmentExchangeServiceValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IExchangeService>
  {
    public ApprovalRegistrationAssignmentExchangeServiceValueInputEventArgs(global::Sungero.ExchangeCore.IExchangeService oldValue, global::Sungero.ExchangeCore.IExchangeService newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalRegistrationAssignmentReworkPerformerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalRegistrationAssignmentReworkPerformerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ApprovalRegistrationAssignmentHandlers.g.cs
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

  public partial class ApprovalRegistrationAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalRegistrationAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalRegistrationAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalRegistrationAssignmentFilteringClientHandler(global::Sungero.Docflow.IApprovalRegistrationAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalRegistrationAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalRegistrationAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRegistrationAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignment)this.Entity; }
    }

    public virtual void SignatoryValueInput(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentSignatoryValueInputEventArgs e) { }



    public virtual void AddresseeValueInput(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentAddresseeValueInputEventArgs e) { }


    public virtual void StageNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void DeliveryMethodValueInput(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentDeliveryMethodValueInputEventArgs e) { }


    public virtual void ExchangeServiceValueInput(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentExchangeServiceValueInputEventArgs e) { }


    public virtual void DeliveryMethodDescriptionValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ReworkPerformerValueInput(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentReworkPerformerValueInputEventArgs e) { }


    public ApprovalRegistrationAssignmentClientHandlers(global::Sungero.Docflow.IApprovalRegistrationAssignment entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRegistrationAssignmentCollapsedStagesTypesRegClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg)this.Entity; }
    }
    public virtual void CollapsedStagesTypesRegStageTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> CollapsedStagesTypesRegStageTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public ApprovalRegistrationAssignmentCollapsedStagesTypesRegClientHandlers(global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalRegistrationAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalRegistrationAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalRegistrationAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignment)this.Entity; }
    }

    public ApprovalRegistrationAssignmentFunctions(global::Sungero.Docflow.IApprovalRegistrationAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRegistrationAssignmentFunctions.g.cs
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
  internal static class ApprovalRegistrationAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRegistrationAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalRegistrationAssignment approvalRegistrationAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("a3b19bde-a0a5-4c7b-9ad4-5a7e800156a9"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalRegistrationAssignment)"
          , approvalRegistrationAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalRegistrationAssignmentClientPublicFunctions.g.cs
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
  public class ApprovalRegistrationAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalRegistrationAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalRegistrationAssignmentActions.g.cs
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
  public partial class ApprovalRegistrationAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IApprovalRegistrationAssignment _obj { get { return (global::Sungero.Docflow.IApprovalRegistrationAssignment)this.Entity; } }
    public ApprovalRegistrationAssignmentActions(global::Sungero.Docflow.IApprovalRegistrationAssignment entity) : base(entity) { }
  }

  public partial class ApprovalRegistrationAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalRegistrationAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalRegistrationAssignment>(this.Entities); }
    }
  }

  public partial class ApprovalRegistrationAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ApprovalRegistrationAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ApprovalRegistrationAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}