
// ==================================================================
// WaybillEventArgs.g.cs
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
// WaybillHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{

  public partial class WaybillFilteringClientHandler
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringClientHandler
  {
    private global::Sungero.FinancialArchive.IWaybillFilterState _filter
    {
      get
      {
        return (Sungero.FinancialArchive.IWaybillFilterState)this.Filter;
      }
    }

    public WaybillFilteringClientHandler(global::Sungero.FinancialArchive.IWaybillFilterState filter)
    : base(filter)
    {
    }

    protected WaybillFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class WaybillClientHandlers : global::Sungero.Docflow.AccountingDocumentBaseClientHandlers
  {
    private global::Sungero.FinancialArchive.IWaybill _obj
    {
      get { return (global::Sungero.FinancialArchive.IWaybill)this.Entity; }
    }

    public WaybillClientHandlers(global::Sungero.FinancialArchive.IWaybill entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// WaybillClientFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Client
{
  public partial class WaybillFunctions : global::Sungero.Docflow.Client.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IWaybill _obj
    {
      get { return (global::Sungero.FinancialArchive.IWaybill)this.Entity; }
    }

    public WaybillFunctions(global::Sungero.FinancialArchive.IWaybill entity) : base(entity) { }
  }
}

// ==================================================================
// WaybillFunctions.g.cs
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
  internal static class Waybill
  {
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.WaybillFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.FinancialArchive.IWaybill waybill)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTypesAvailableForChange", new System.Type[] {  });
      return (global::System.Collections.Generic.List<Domain.Shared.IEntityInfo>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.WaybillFunctions" />
    internal static  global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.FinancialArchive.IWaybill waybill, global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> types)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentType", new System.Type[] { typeof(global::System.Collections.Generic.List<Domain.Shared.IEntityInfo>) });
      return (global::Sungero.Docflow.IOfficialDocument)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { types });
    }
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.WaybillFunctions" />
    internal static  global::System.Boolean CanChangeDocumentType(global::Sungero.FinancialArchive.IWaybill waybill)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanChangeDocumentType", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.WaybillFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentResponsibleEmployee(global::Sungero.FinancialArchive.IWaybill waybill)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentResponsibleEmployee", new System.Type[] {  });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.WaybillFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.FinancialArchive.IWaybill waybill)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmailAddressees", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.WaybillFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IWaybill waybill)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)waybill).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// WaybillClientPublicFunctions.g.cs
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
  public class WaybillClientPublicFunctions : global::Sungero.FinancialArchive.Client.IWaybillClientPublicFunctions
  {
    public global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.FinancialArchive.IWaybill waybill, global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> types)
    {
      return global::Sungero.FinancialArchive.Functions.Waybill.ChangeDocumentType(waybill, types);
    }
  }
}

// ==================================================================
// WaybillActions.g.cs
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
  public partial class WaybillActions : global::Sungero.Docflow.Client.AccountingDocumentBaseActions
  {
    private global::Sungero.FinancialArchive.IWaybill _obj { get { return (global::Sungero.FinancialArchive.IWaybill)this.Entity; } }
    public WaybillActions(global::Sungero.FinancialArchive.IWaybill entity) : base(entity) { }
  }

  public partial class WaybillCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.FinancialArchive.IWaybill> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.FinancialArchive.IWaybill>(this.Entities); }
    }
  }

  public partial class WaybillCollectionBulkActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class WaybillAnyChildEntityActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityActions
  {
  }

  public partial class WaybillAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
