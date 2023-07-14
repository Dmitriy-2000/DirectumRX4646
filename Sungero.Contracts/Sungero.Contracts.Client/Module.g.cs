
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

namespace Sungero.Contracts.Client
{
  public partial class ContractsModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("f9d15b1c-2784-4c84-8348-1e162d70b988"); }
    }

    public override string Name
    {
      get { return "Sungero.Contracts"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("16aa8863-3f80-486b-be94-069e6f7b4d94"), new Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageInfo(typeof(global::Sungero.Contracts.IApprovalIncInvoicePaidStage)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IApprovalIncInvoicePaidStageClientPublicFunctions, global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IApprovalIncInvoicePaidStageSharedPublicFunctions, global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f37c7e63-b134-4446-9b5b-f8811f6c9666"), new Sungero.Contracts.Shared.ContractInfo(typeof(global::Sungero.Contracts.IContract)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractClientPublicFunctions, global::Sungero.Contracts.Client.ContractClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a8df1a5c-e08a-40a7-a9e4-dc41dd326303"), new Sungero.Contracts.Shared.ContractStagesInfo(typeof(global::Sungero.Contracts.IContractStages)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("c3c85262-6f62-400a-b238-27a76aa4e860"), new Sungero.Contracts.Shared.ContractTrackingInfo(typeof(global::Sungero.Contracts.IContractTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("6fd4c4b8-1bf8-466d-b4a7-7958ec225672"), new Sungero.Contracts.Shared.ContractVersionsInfo(typeof(global::Sungero.Contracts.IContractVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("03a2d2f4-a15a-4b5b-a97b-71140a938cbe"), new Sungero.Contracts.Shared.ContractApprovalRoleInfo(typeof(global::Sungero.Contracts.IContractApprovalRole)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractApprovalRoleClientPublicFunctions, global::Sungero.Contracts.Client.ContractApprovalRoleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractApprovalRoleSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractApprovalRoleSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("306da7fa-dc27-437c-bb83-42c92436b7e2"), new Sungero.Contracts.Shared.ContractBaseInfo(typeof(global::Sungero.Contracts.IContractBase)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractBaseClientPublicFunctions, global::Sungero.Contracts.Client.ContractBaseClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractBaseSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractBaseSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ed27ede9-3dd2-4d4a-b1fc-2ca9eae265b5"), new Sungero.Contracts.Shared.ContractBaseStagesInfo(typeof(global::Sungero.Contracts.IContractBaseStages)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("af611b7d-7a97-4c85-bd0e-44335ba5a989"), new Sungero.Contracts.Shared.ContractBaseTrackingInfo(typeof(global::Sungero.Contracts.IContractBaseTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("c7a89d8e-e835-42f5-81af-6c741c43d259"), new Sungero.Contracts.Shared.ContractBaseVersionsInfo(typeof(global::Sungero.Contracts.IContractBaseVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("eb34ad64-f23b-4c9f-9d48-74834fbbe33e"), new Sungero.Contracts.Shared.ContractCategoryInfo(typeof(global::Sungero.Contracts.IContractCategory)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractCategoryClientPublicFunctions, global::Sungero.Contracts.Client.ContractCategoryClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractCategorySharedPublicFunctions, global::Sungero.Contracts.Shared.ContractCategorySharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a9ad8c06-3d46-4302-be22-43b3b909f718"), new Sungero.Contracts.Shared.ContractCategoryDocumentKindsInfo(typeof(global::Sungero.Contracts.IContractCategoryDocumentKinds)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("0523387b-a689-41e5-bed3-95892df6922c"), new Sungero.Contracts.Shared.ContractConditionInfo(typeof(global::Sungero.Contracts.IContractCondition)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractConditionClientPublicFunctions, global::Sungero.Contracts.Client.ContractConditionClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractConditionSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractConditionSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("2e3a82a6-98cf-46f8-a9cc-17fa8a307a97"), new Sungero.Contracts.Shared.ContractConditionConditionDocumentKindsInfo(typeof(global::Sungero.Contracts.IContractConditionConditionDocumentKinds)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("540bb138-651c-45f8-a3ca-7c2ea6ff8e21"), new Sungero.Contracts.Shared.ContractConditionCurrenciesInfo(typeof(global::Sungero.Contracts.IContractConditionCurrencies)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("d355936d-7ee2-4bd6-a9e8-889e3d036082"), new Sungero.Contracts.Shared.ContractConditionDeliveryMethodsInfo(typeof(global::Sungero.Contracts.IContractConditionDeliveryMethods)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4034e012-3db7-424b-b4c0-de5c610a7664"), new Sungero.Contracts.Shared.ContractConditionDocumentKindsInfo(typeof(global::Sungero.Contracts.IContractConditionDocumentKinds)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("dcbf9c6f-9bb6-4b61-b501-db35df320207"), new Sungero.Contracts.Shared.ContractsApprovalRuleInfo(typeof(global::Sungero.Contracts.IContractsApprovalRule)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractsApprovalRuleClientPublicFunctions, global::Sungero.Contracts.Client.ContractsApprovalRuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractsApprovalRuleSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractsApprovalRuleSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("31dab68e-7567-4c19-9586-ba447b36562c"), new Sungero.Contracts.Shared.ContractsApprovalRuleBusinessUnitsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleBusinessUnits)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("421977df-8d98-4833-ad4e-a97214c8660b"), new Sungero.Contracts.Shared.ContractsApprovalRuleConditionsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleConditions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("6c966139-e0f7-4c62-8c83-ed8702ca54c5"), new Sungero.Contracts.Shared.ContractsApprovalRuleDepartmentsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleDepartments)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("9039aab1-4ce6-4769-ab73-2eb1f47f6cb7"), new Sungero.Contracts.Shared.ContractsApprovalRuleDocumentGroupsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleDocumentGroups)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f611b903-a654-4664-8147-ed891c0713d3"), new Sungero.Contracts.Shared.ContractsApprovalRuleDocumentKindsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleDocumentKinds)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ea6de446-e4d2-4ae0-97f1-2cba6e7b0424"), new Sungero.Contracts.Shared.ContractsApprovalRuleStagesInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleStages)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("303c6866-a2ef-4864-8350-1cc9dcbcb6ee"), new Sungero.Contracts.Shared.ContractsApprovalRuleTransitionsInfo(typeof(global::Sungero.Contracts.IContractsApprovalRuleTransitions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("59079f7f-a326-4947-bbd6-0ae6dfb5f59b"), new Sungero.Contracts.Shared.ContractualDocumentInfo(typeof(global::Sungero.Contracts.IContractualDocument)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IContractualDocumentClientPublicFunctions, global::Sungero.Contracts.Client.ContractualDocumentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IContractualDocumentSharedPublicFunctions, global::Sungero.Contracts.Shared.ContractualDocumentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("478d3e3d-4519-4bb0-b009-c43f7fbe0b95"), new Sungero.Contracts.Shared.ContractualDocumentMilestonesInfo(typeof(global::Sungero.Contracts.IContractualDocumentMilestones)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("19c5aee5-f67f-497e-ac1b-ab98bab0901b"), new Sungero.Contracts.Shared.ContractualDocumentTrackingInfo(typeof(global::Sungero.Contracts.IContractualDocumentTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("fff6fbcb-3478-43fb-b8d4-888d2c5038c2"), new Sungero.Contracts.Shared.ContractualDocumentVersionsInfo(typeof(global::Sungero.Contracts.IContractualDocumentVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a523a263-bc00-40f9-810d-f582bae2205d"), new Sungero.Contracts.Shared.IncomingInvoiceInfo(typeof(global::Sungero.Contracts.IIncomingInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IIncomingInvoiceClientPublicFunctions, global::Sungero.Contracts.Client.IncomingInvoiceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IIncomingInvoiceSharedPublicFunctions, global::Sungero.Contracts.Shared.IncomingInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("b8a7adc0-8df8-4b1f-8623-c529b7ddb7cb"), new Sungero.Contracts.Shared.IncomingInvoiceTrackingInfo(typeof(global::Sungero.Contracts.IIncomingInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4ca628f6-b2c8-4892-8629-8f77041f4392"), new Sungero.Contracts.Shared.IncomingInvoiceVersionsInfo(typeof(global::Sungero.Contracts.IIncomingInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("58ad01fb-6805-426b-9152-4de16d83b258"), new Sungero.Contracts.Shared.OutgoingInvoiceInfo(typeof(global::Sungero.Contracts.IOutgoingInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IOutgoingInvoiceClientPublicFunctions, global::Sungero.Contracts.Client.OutgoingInvoiceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IOutgoingInvoiceSharedPublicFunctions, global::Sungero.Contracts.Shared.OutgoingInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("dc209078-76ad-4603-a249-91e4b377d276"), new Sungero.Contracts.Shared.OutgoingInvoiceTrackingInfo(typeof(global::Sungero.Contracts.IOutgoingInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("5101183d-0a1a-4904-9361-96d9777244d3"), new Sungero.Contracts.Shared.OutgoingInvoiceVersionsInfo(typeof(global::Sungero.Contracts.IOutgoingInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("265f2c57-6a8a-4a15-833b-ca00e8047fa5"), new Sungero.Contracts.Shared.SupAgreementInfo(typeof(global::Sungero.Contracts.ISupAgreement)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.ISupAgreementClientPublicFunctions, global::Sungero.Contracts.Client.SupAgreementClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.ISupAgreementSharedPublicFunctions, global::Sungero.Contracts.Shared.SupAgreementSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("cece0295-1cc2-465f-bb38-f193e0a786a0"), new Sungero.Contracts.Shared.SupAgreementStagesInfo(typeof(global::Sungero.Contracts.ISupAgreementStages)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("3a1afee8-f45c-4c4e-aa45-6bd6cf2d38a2"), new Sungero.Contracts.Shared.SupAgreementTrackingInfo(typeof(global::Sungero.Contracts.ISupAgreementTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("cb6cb813-eb9a-4672-806d-29f32e24a29e"), new Sungero.Contracts.Shared.SupAgreementVersionsInfo(typeof(global::Sungero.Contracts.ISupAgreementVersions)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState, global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStage.ApprovalIncInvoicePaidStageFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractFilterState, global::Sungero.Contracts.Shared.Contract.ContractFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractApprovalRoleFilterState, global::Sungero.Contracts.Shared.ContractApprovalRole.ContractApprovalRoleFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractBaseFilterState, global::Sungero.Contracts.Shared.ContractBase.ContractBaseFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractCategoryFilterState, global::Sungero.Contracts.Shared.ContractCategory.ContractCategoryFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractConditionFilterState, global::Sungero.Contracts.Shared.ContractCondition.ContractConditionFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractsApprovalRuleFilterState, global::Sungero.Contracts.Shared.ContractsApprovalRule.ContractsApprovalRuleFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IContractualDocumentFilterState, global::Sungero.Contracts.Shared.ContractualDocument.ContractualDocumentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IIncomingInvoiceFilterState, global::Sungero.Contracts.Shared.IncomingInvoice.IncomingInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.IOutgoingInvoiceFilterState, global::Sungero.Contracts.Shared.OutgoingInvoice.OutgoingInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.ISupAgreementFilterState, global::Sungero.Contracts.Shared.SupAgreement.SupAgreementFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Client.IModuleClientPublicFunctions, global::Sungero.Contracts.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Contracts.Shared.IModuleSharedPublicFunctions, global::Sungero.Contracts.Shared.ModuleSharedPublicFunctions>();
    }
  }
}