
// ==================================================================
// Module.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public partial class FinancialArchiveModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"); }
    }

    public override string Name
    {
      get { return "Sungero.FinancialArchive"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f2f5774d-5ca3-4725-b31d-ac618f6b8850"), new Sungero.FinancialArchive.Shared.ContractStatementInfo(typeof(global::Sungero.FinancialArchive.IContractStatement)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IContractStatementClientPublicFunctions, global::Sungero.FinancialArchive.Client.ContractStatementClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IContractStatementSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.ContractStatementSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("b3aa9cb5-17a0-4570-97f7-cc5635cd94df"), new Sungero.FinancialArchive.Shared.ContractStatementTrackingInfo(typeof(global::Sungero.FinancialArchive.IContractStatementTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ae5566c8-cefa-412f-81ee-b1a84f153024"), new Sungero.FinancialArchive.Shared.ContractStatementVersionsInfo(typeof(global::Sungero.FinancialArchive.IContractStatementVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("74c9ddd4-4bc4-42b6-8bb0-c91d5e21fb8a"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IIncomingTaxInvoiceClientPublicFunctions, global::Sungero.FinancialArchive.Client.IncomingTaxInvoiceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IIncomingTaxInvoiceSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("422752c6-5348-46bc-bbfd-0d2520f09ca2"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceTrackingInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("bb90f6e2-57e5-42ed-9c8a-9d37cbe6f593"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceVersionsInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f50c4d8a-56bc-43ef-bac3-856f57ca70be"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IOutgoingTaxInvoiceClientPublicFunctions, global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IOutgoingTaxInvoiceSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("efde70aa-7f41-4673-aeab-0f996a1e8215"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceTrackingInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("9c4a7356-509e-4e63-bc4f-f2fae3350447"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceVersionsInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("58986e23-2b0a-4082-af37-bd1991bc6f7e"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocument)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IUniversalTransferDocumentClientPublicFunctions, global::Sungero.FinancialArchive.Client.UniversalTransferDocumentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IUniversalTransferDocumentSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.UniversalTransferDocumentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("edffd4a9-b71c-43e1-aaf8-0d537258a027"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentTrackingInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocumentTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("7f57a617-9c0e-412e-8dcf-920360cc8976"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentVersionsInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocumentVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4e81f9ca-b95a-4fd4-bf76-ea7176c215a7"), new Sungero.FinancialArchive.Shared.WaybillInfo(typeof(global::Sungero.FinancialArchive.IWaybill)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IWaybillClientPublicFunctions, global::Sungero.FinancialArchive.Client.WaybillClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IWaybillSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.WaybillSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("831a7d69-593c-4f19-a953-9b8c43efe03c"), new Sungero.FinancialArchive.Shared.WaybillTrackingInfo(typeof(global::Sungero.FinancialArchive.IWaybillTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1c506636-1d50-4c79-a0c7-09746718d016"), new Sungero.FinancialArchive.Shared.WaybillVersionsInfo(typeof(global::Sungero.FinancialArchive.IWaybillVersions)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IContractStatementFilterState, global::Sungero.FinancialArchive.Shared.ContractStatement.ContractStatementFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState, global::Sungero.FinancialArchive.Shared.IncomingTaxInvoice.IncomingTaxInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceFilterState, global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoice.OutgoingTaxInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IUniversalTransferDocumentFilterState, global::Sungero.FinancialArchive.Shared.UniversalTransferDocument.UniversalTransferDocumentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IWaybillFilterState, global::Sungero.FinancialArchive.Shared.Waybill.WaybillFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Client.IModuleClientPublicFunctions, global::Sungero.FinancialArchive.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IModuleSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.ModuleSharedPublicFunctions>();
    }
  }
}
