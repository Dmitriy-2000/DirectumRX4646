
// ==================================================================
// ModuleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    internal static void FindAccountingDocuments(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.Boolean incomingTaxInvoice, global::System.Boolean outgoingTaxInvoice, global::System.Boolean contractStatement, global::System.Boolean waybill, global::System.Boolean universalTransferDocument)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindAccountingDocuments", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, incomingTaxInvoice, outgoingTaxInvoice, contractStatement, waybill, universalTransferDocument});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindAccountingDocuments(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, incomingTaxInvoice, outgoingTaxInvoice, contractStatement, waybill, universalTransferDocument);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindOutgoingTaxInvoice(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindOutgoingTaxInvoice", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindOutgoingTaxInvoice(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindIncomingTaxInvoice(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindIncomingTaxInvoice", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindIncomingTaxInvoice(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindIncomingContractStatement(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindIncomingContractStatement", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindIncomingContractStatement(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindOutgoingContractStatement(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindOutgoingContractStatement", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindOutgoingContractStatement(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindIncomingWayBill(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindIncomingWayBill", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindIncomingWayBill(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindOutgoingWayBill(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String corrective, global::System.String sysid)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("FindOutgoingWayBill", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid});
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).FindOutgoingWayBill(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, sysid);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    internal static void ImportAndShowDocumentFromFileDialog()
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ImportAndShowDocumentFromFileDialog", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).ImportAndShowDocumentFromFileDialog();
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    internal static global::Sungero.Docflow.IAccountingDocumentBase ImportFormalizedDocument(global::System.String file, global::System.Boolean requireFtsId)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ImportFormalizedDocument", new global::System.Type[]{typeof(global::System.String), typeof(global::System.Boolean)});
        return (global::Sungero.Docflow.IAccountingDocumentBase)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{file, requireFtsId});
      }
      else
      {
        return ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).ImportFormalizedDocument(file, requireFtsId);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.ClientBase" type="Sungero.FinancialArchive.Client.ModuleFunctions" />
    internal static global::Sungero.Docflow.IAccountingDocumentBase ImportFormalizedDocument(global::Sungero.Docflow.Structures.Module.IByteArray xml, global::System.Boolean requireFtsId)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ImportFormalizedDocument", new global::System.Type[]{typeof(global::Sungero.Docflow.Structures.Module.IByteArray), typeof(global::System.Boolean)});
        return (global::Sungero.Docflow.IAccountingDocumentBase)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{xml, requireFtsId});
      }
      else
      {
        return ((global::Sungero.FinancialArchive.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).ImportFormalizedDocument(xml, requireFtsId);
      }
    }

    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.Docflow.IAccountingDocumentBase document)
    {
      var __moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.FinancialArchive.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetEmailAddressees", new global::System.Type[]{typeof(global::Sungero.Docflow.IAccountingDocumentBase)});
        return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
        return ((global::Sungero.FinancialArchive.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetEmailAddressees(document);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Docflow.IAccountingDocumentBase> FindAccountingDocuments(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.Boolean corrective, global::System.Boolean incomingTaxInvoice, global::System.Boolean outgoingTaxInvoice, global::System.Boolean contractStatement, global::System.Boolean waybill, global::System.Boolean universalTransferDocument)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IAccountingDocumentBase>>(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "FindAccountingDocuments(global::System.String,global::System.String,global::System.String,global::System.String,global::System.String,global::System.String,global::System.String,global::System.Boolean,global::System.Boolean,global::System.Boolean,global::System.Boolean,global::System.Boolean,global::System.Boolean)", number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, incomingTaxInvoice, outgoingTaxInvoice, contractStatement, waybill, universalTransferDocument);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static global::Sungero.FinancialArchive.Structures.Module.IImportResult ImportFormalizedDocument(global::Sungero.Docflow.Structures.Module.IByteArray file, global::System.Boolean requireFtsId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.FinancialArchive.Structures.Module.IImportResult>(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "ImportFormalizedDocument(global::Sungero.Docflow.Structures.Module.IByteArray,global::System.Boolean)", file, requireFtsId);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static global::System.Boolean HasSellerSignatoryInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "HasSellerSignatoryInfo(global::Sungero.Docflow.IAccountingDocumentBase)", document);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static global::System.Boolean HasSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "HasSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase)", document);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static void AddOrReplaceSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "AddOrReplaceSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase)", document);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static void GenerateSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase statement, global::Sungero.Docflow.Structures.AccountingDocumentBase.ISellerTitle sellerTitle)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "GenerateSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Docflow.Structures.AccountingDocumentBase.ISellerTitle)", statement, sellerTitle);
      }
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
      internal static global::System.Boolean HasUnsignedSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase statement)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"),
          "HasUnsignedSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase)", statement);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.FinancialArchive.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType, global::Sungero.Metadata.ModuleMetadata finalModuleMetadatda)
    {
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      var methodInfo = moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static);
      return global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, null, null);
    }
  }
}

// ==================================================================
// ModuleClientPublicFunctions.g.cs
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
  public partial class ModuleClientPublicFunctions : global::Sungero.FinancialArchive.Client.IModuleClientPublicFunctions
  {
    public void ImportAndShowDocumentFromFileDialog()
    {
global::Sungero.FinancialArchive.Functions.Module.ImportAndShowDocumentFromFileDialog();
    }
    public global::Sungero.Docflow.IAccountingDocumentBase ImportFormalizedDocument(global::System.String file, global::System.Boolean requireFtsId)
    {
      return global::Sungero.FinancialArchive.Functions.Module.ImportFormalizedDocument(file, requireFtsId);
    }
    public global::Sungero.Docflow.IAccountingDocumentBase ImportFormalizedDocument(global::Sungero.Docflow.Structures.Module.IByteArray xml, global::System.Boolean requireFtsId)
    {
      return global::Sungero.FinancialArchive.Functions.Module.ImportFormalizedDocument(xml, requireFtsId);
    }
  }
}

// ==================================================================
// ModuleWidgetHandlers.g.cs
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
}

// ==================================================================
// ModuleHandlers.g.cs
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

}

