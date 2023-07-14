
// ==================================================================
// IncomingInvoiceState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class IncomingInvoiceState : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseState, global::Sungero.Contracts.IIncomingInvoiceState
  {
    public IncomingInvoiceState(global::Sungero.Contracts.IIncomingInvoice entity) : base(entity) { }

    public new global::Sungero.Contracts.IIncomingInvoicePropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IIncomingInvoicePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoicePropertyStates(entity);
    }


    public new global::Sungero.Contracts.IIncomingInvoiceControlStates Controls
    {
      get { return (global::Sungero.Contracts.IIncomingInvoiceControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoiceControlStates(entity);
    }

    public new global::Sungero.Contracts.IIncomingInvoicePageStates Pages
    {
      get { return (global::Sungero.Contracts.IIncomingInvoicePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoicePageStates(entity);
    }

  }


  public class IncomingInvoiceControlStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseControlStates, global::Sungero.Contracts.IIncomingInvoiceControlStates
  {

    protected internal IncomingInvoiceControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class IncomingInvoicePageStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePageStates, global::Sungero.Contracts.IIncomingInvoicePageStates
  {

    protected internal IncomingInvoicePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class IncomingInvoicePropertyStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePropertyStates, global::Sungero.Contracts.IIncomingInvoicePropertyStates
  {
            public new global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceVersions> Versions
            {
              get { return (global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Contracts.Shared.IncomingInvoiceVersionsCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceVersions>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractualDocument> Contract 
            {
              get { return this.InternalContract; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractualDocument> InternalContract
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IContractualDocument>("Contract"); }
            }
            public new global::Sungero.Contracts.IIncomingInvoiceTrackingCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceTracking> Tracking
            {
              get { return (global::Sungero.Contracts.IIncomingInvoiceTrackingCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Contracts.Shared.IncomingInvoiceTrackingCollectionPropertyState<global::Sungero.Contracts.IIncomingInvoiceTracking>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> PaymentDueDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("PaymentDueDate"); }
            }


    protected internal IncomingInvoicePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// IncomingInvoiceInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class IncomingInvoiceInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseInfo, global::Sungero.Contracts.IIncomingInvoiceInfo
  {
    public IncomingInvoiceInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IIncomingInvoicePropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IIncomingInvoicePropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Contracts.IIncomingInvoiceActionsInfo Actions
    {
      get { return (global::Sungero.Contracts.IIncomingInvoiceActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoicePropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoiceActionsInfo(entityType);
    }
  }

  public class IncomingInvoicePropertiesInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePropertiesInfo, global::Sungero.Contracts.IIncomingInvoicePropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IContractualDocumentInfo, global::Sungero.Contracts.IContractualDocument> Contract 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Contract");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IContractualDocumentInfo, global::Sungero.Contracts.IContractualDocument>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceTrackingPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo PaymentDueDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("PaymentDueDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }


    protected internal IncomingInvoicePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class IncomingInvoiceActionsInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseActionsInfo, global::Sungero.Contracts.IIncomingInvoiceActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo ShowDuplicates 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowDuplicates")); }
        }


    protected internal IncomingInvoiceActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// IncomingInvoiceHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{
  public partial class IncomingInvoiceSharedHandlers : global::Sungero.Docflow.AccountingDocumentBaseSharedHandlers, IIncomingInvoiceSharedHandlers
  {
    private global::Sungero.Contracts.IIncomingInvoice _obj
    {
      get { return (global::Sungero.Contracts.IIncomingInvoice)this.Entity; }
    }
    public virtual void PaymentDueDateChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }




    public IncomingInvoiceSharedHandlers(global::Sungero.Contracts.IIncomingInvoice entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// IncomingInvoiceResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared.IncomingInvoice
{
  /// <summary>
  /// Represents IncomingInvoice resources.
  /// </summary>
  public class IncomingInvoiceResources : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseResources, global::Sungero.Contracts.IncomingInvoice.IIncomingInvoiceResources
  {
    public virtual global::CommonLibrary.LocalizedString NamePartForCounterparty
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice) , "NamePartForCounterparty");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NamePartForCounterpartyFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice), "NamePartForCounterparty", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString TotalAmountMustBePositive
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice) , "TotalAmountMustBePositive");
      }
    }

    public virtual global::CommonLibrary.LocalizedString TotalAmountMustBePositiveFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice), "TotalAmountMustBePositive", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DuplicateDetected
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice) , "DuplicateDetected");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DuplicateDetectedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice), "DuplicateDetected", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DuplicateNotFound
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice) , "DuplicateNotFound");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DuplicateNotFoundFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice), "DuplicateNotFound", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DatePaymentDeadlineValidationMessage
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice) , "DatePaymentDeadlineValidationMessage");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DatePaymentDeadlineValidationMessageFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IIncomingInvoice), "DatePaymentDeadlineValidationMessage", false, args);
    }

  }
}

// ==================================================================
// IncomingInvoiceSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Shared
{
  public partial class IncomingInvoiceFunctions : global::Sungero.Docflow.Shared.AccountingDocumentBaseFunctions
  {
    private global::Sungero.Contracts.IIncomingInvoice _obj
    {
      get { return (global::Sungero.Contracts.IIncomingInvoice)this.Entity; }
    }

    public IncomingInvoiceFunctions(global::Sungero.Contracts.IIncomingInvoice entity) : base(entity) { }
  }
}

// ==================================================================
// IncomingInvoiceFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Functions
{
  internal static class IncomingInvoice
  {
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void FillName(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void AddRelatedDocumentsToAttachmentGroup(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup group)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddRelatedDocumentsToAttachmentGroup", new System.Type[] { typeof(Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { group });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void RemoveRelatedDocumentsFromAttachmentGroup(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup group)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemoveRelatedDocumentsFromAttachmentGroup", new System.Type[] { typeof(Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { group });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void UpdateLifeCycle(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::System.Nullable<global::Sungero.Core.Enumeration> registrationState, global::System.Nullable<global::Sungero.Core.Enumeration> approvalState, global::System.Nullable<global::Sungero.Core.Enumeration> counterpartyApprovalState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("UpdateLifeCycle", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { registrationState, approvalState, counterpartyApprovalState });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::Sungero.Docflow.IDocumentKind documentKind, global::System.String number, global::System.Nullable<global::System.DateTime> date, global::System.Nullable<global::System.Double> totalAmount, global::Sungero.Commons.ICurrency currency, global::Sungero.Parties.ICounterparty counterparty)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Shared.IncomingInvoiceFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("HaveDuplicates",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Contracts.IIncomingInvoice), typeof(global::Sungero.Docflow.IDocumentKind), typeof(global::System.String), typeof(global::System.Nullable<global::System.DateTime>), typeof(global::System.Nullable<global::System.Double>), typeof(global::Sungero.Commons.ICurrency), typeof(global::Sungero.Parties.ICounterparty) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { incomingInvoice, documentKind, number, date, totalAmount, currency, counterparty });
      }
      else
      {
        return global::Sungero.Contracts.Shared.IncomingInvoiceFunctions.HaveDuplicates(incomingInvoice, documentKind, number, date, totalAmount, currency, counterparty);
      }
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.IncomingInvoiceFunctions" />
    internal static  void FillLeadingDocument(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillLeadingDocument", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { leadingDocument });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.IncomingInvoiceFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Contracts.IIncomingInvoice> GetDuplicates(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::Sungero.Docflow.IDocumentKind documentKind, global::System.String number, global::System.Nullable<global::System.DateTime> date, global::System.Nullable<global::System.Double> totalAmount, global::Sungero.Commons.ICurrency currency, global::Sungero.Parties.ICounterparty counterparty)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Contracts.IIncomingInvoice>>(
          global::System.Guid.Parse("a523a263-bc00-40f9-810d-f582bae2205d"),
          "GetDuplicates(global::Sungero.Contracts.IIncomingInvoice,global::Sungero.Docflow.IDocumentKind,global::System.String,global::System.Nullable<global::System.DateTime>,global::System.Nullable<global::System.Double>,global::Sungero.Commons.ICurrency,global::Sungero.Parties.ICounterparty)"
      , incomingInvoice, documentKind, number, date, totalAmount, currency, counterparty);
      }

    }
  }
}

// ==================================================================
// IncomingInvoiceFilterState.g.cs
// ==================================================================

namespace Sungero.Contracts.Shared.IncomingInvoice
{

  public class IncomingInvoiceFilterInfo : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseFilterInfo,
    global::Sungero.Contracts.IIncomingInvoiceFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo Draft
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Draft");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo OnApproval
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("OnApproval");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PayAccepted
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PayAccepted");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PayComplete
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PayComplete");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PayRejected
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PayRejected");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Last7daysInvoice
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Last7daysInvoice");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Last30daysInvoice
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Last30daysInvoice");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo ManualPeriodInvoice
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ManualPeriodInvoice");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeInvoiceFrom
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeInvoiceFrom");
      }
    }
    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeInvoiceTo
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeInvoiceTo");
      }
    }


  }

  public class IncomingInvoiceFilterState : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseFilterState,
    global::Sungero.Contracts.IIncomingInvoiceFilterState
  {
    public bool Draft
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool OnApproval
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PayAccepted
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PayComplete
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PayRejected
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool Last7daysInvoice
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool Last30daysInvoice
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool ManualPeriodInvoice
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }




    public global::System.DateTime? DateRangeInvoiceFrom
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }
    public global::System.DateTime? DateRangeInvoiceTo
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }



    public new Sungero.Contracts.IIncomingInvoiceFilterInfo Info
    {
      get
      {
        return (Sungero.Contracts.IIncomingInvoiceFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Contracts.Shared.IncomingInvoice.IncomingInvoiceFilterInfo();
    }

  }
}

// ==================================================================
// IncomingInvoiceSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class IncomingInvoiceSharedPublicFunctions : global::Sungero.Contracts.Shared.IIncomingInvoiceSharedPublicFunctions
  {
    public void FillLeadingDocument(global::Sungero.Contracts.IIncomingInvoice incomingInvoice, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
global::Sungero.Contracts.Functions.IncomingInvoice.FillLeadingDocument(incomingInvoice, leadingDocument);
    }
    public global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      return global::Sungero.Contracts.Functions.IncomingInvoice.HasEmptyRequiredProperties(incomingInvoice);
    }
    public global::System.Boolean IsVerificationModeSupported(global::Sungero.Contracts.IIncomingInvoice incomingInvoice)
    {
      return global::Sungero.Contracts.Functions.IncomingInvoice.IsVerificationModeSupported(incomingInvoice);
    }
  }
}