
// ==================================================================
// ApprovalSigningAssignmentEventArgs.g.cs
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
  public class ApprovalSigningAssignmentStageValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IApprovalStage>
  {
    public ApprovalSigningAssignmentStageValueInputEventArgs(global::Sungero.Docflow.IApprovalStage oldValue, global::Sungero.Docflow.IApprovalStage newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





  public class ApprovalSigningAssignmentDeliveryMethodValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IMailDeliveryMethod>
  {
    public ApprovalSigningAssignmentDeliveryMethodValueInputEventArgs(global::Sungero.Docflow.IMailDeliveryMethod oldValue, global::Sungero.Docflow.IMailDeliveryMethod newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ApprovalSigningAssignmentExchangeServiceValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IExchangeService>
  {
    public ApprovalSigningAssignmentExchangeServiceValueInputEventArgs(global::Sungero.ExchangeCore.IExchangeService oldValue, global::Sungero.ExchangeCore.IExchangeService newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalSigningAssignmentReworkPerformerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalSigningAssignmentReworkPerformerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ApprovalSigningAssignmentHandlers.g.cs
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

  public partial class ApprovalSigningAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalSigningAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalSigningAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalSigningAssignmentFilteringClientHandler(global::Sungero.Docflow.IApprovalSigningAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalSigningAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalSigningAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IApprovalSigningAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignment)this.Entity; }
    }

    public virtual void StageValueInput(global::Sungero.Docflow.Client.ApprovalSigningAssignmentStageValueInputEventArgs e) { }


    public virtual void IsCollapsedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void IsConfirmSigningValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }



    public virtual void StageNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void DeliveryMethodValueInput(global::Sungero.Docflow.Client.ApprovalSigningAssignmentDeliveryMethodValueInputEventArgs e) { }


    public virtual void ExchangeServiceValueInput(global::Sungero.Docflow.Client.ApprovalSigningAssignmentExchangeServiceValueInputEventArgs e) { }


    public virtual void DeliveryMethodDescriptionValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ReworkPerformerValueInput(global::Sungero.Docflow.Client.ApprovalSigningAssignmentReworkPerformerValueInputEventArgs e) { }


    public ApprovalSigningAssignmentClientHandlers(global::Sungero.Docflow.IApprovalSigningAssignment entity) : base(entity)
    {
    }
  }

  public partial class ApprovalSigningAssignmentCollapsedStagesTypesSigClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig)this.Entity; }
    }
    public virtual void CollapsedStagesTypesSigStageTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> CollapsedStagesTypesSigStageTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public ApprovalSigningAssignmentCollapsedStagesTypesSigClientHandlers(global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalSigningAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalSigningAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalSigningAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignment)this.Entity; }
    }

    public ApprovalSigningAssignmentFunctions(global::Sungero.Docflow.IApprovalSigningAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalSigningAssignmentFunctions.g.cs
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
  internal static class ApprovalSigningAssignment
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalSigningAssignmentFunctions" />
    internal static  global::System.Boolean NeedViewDocumentSummary(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalSigningAssignment).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedViewDocumentSummary", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalSigningAssignmentFunctions" />
    internal static  void ApproveDocument(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment, global::System.Boolean needStrongSign, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalSigningAssignment).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ApproveDocument", new System.Type[] { typeof(global::System.Boolean), typeof(Sungero.Domain.Client.ExecuteActionArgs) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needStrongSign, eventArgs });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSigningAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("db516acc-0f02-4ea7-960a-08f3f734db4f"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalSigningAssignment)"
          , approvalSigningAssignment);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSigningAssignmentFunctions" />
      internal static global::System.String  GetDocumentSummary(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("db516acc-0f02-4ea7-960a-08f3f734db4f"),
          "GetDocumentSummary(global::Sungero.Docflow.IApprovalSigningAssignment)"
          , approvalSigningAssignment);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSigningAssignmentFunctions" />
      internal static global::System.String  GetApprovalListState(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("db516acc-0f02-4ea7-960a-08f3f734db4f"),
          "GetApprovalListState(global::Sungero.Docflow.IApprovalSigningAssignment)"
          , approvalSigningAssignment);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSigningAssignmentFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.BeforeSign ValidateBeforeSign(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.BeforeSign>(
          global::System.Guid.Parse("db516acc-0f02-4ea7-960a-08f3f734db4f"),
          "ValidateBeforeSign(global::Sungero.Docflow.IApprovalSigningAssignment)"
          , approvalSigningAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalSigningAssignmentClientPublicFunctions.g.cs
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
  public class ApprovalSigningAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalSigningAssignmentClientPublicFunctions
  {
    public global::System.Boolean NeedViewDocumentSummary(global::Sungero.Docflow.IApprovalSigningAssignment approvalSigningAssignment)
    {
      return global::Sungero.Docflow.Functions.ApprovalSigningAssignment.NeedViewDocumentSummary(approvalSigningAssignment);
    }
  }
}

// ==================================================================
// ApprovalSigningAssignmentActions.g.cs
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
  public partial class ApprovalSigningAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IApprovalSigningAssignment _obj { get { return (global::Sungero.Docflow.IApprovalSigningAssignment)this.Entity; } }
    public ApprovalSigningAssignmentActions(global::Sungero.Docflow.IApprovalSigningAssignment entity) : base(entity) { }
  }

  public partial class ApprovalSigningAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalSigningAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalSigningAssignment>(this.Entities); }
    }
  }

  public partial class ApprovalSigningAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ApprovalSigningAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ApprovalSigningAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
