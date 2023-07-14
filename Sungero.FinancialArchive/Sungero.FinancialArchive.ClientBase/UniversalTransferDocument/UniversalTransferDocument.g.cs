
// ==================================================================
// UniversalTransferDocumentEventArgs.g.cs
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
// UniversalTransferDocumentHandlers.g.cs
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

  public partial class UniversalTransferDocumentFilteringClientHandler
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringClientHandler
  {
    private global::Sungero.FinancialArchive.IUniversalTransferDocumentFilterState _filter
    {
      get
      {
        return (Sungero.FinancialArchive.IUniversalTransferDocumentFilterState)this.Filter;
      }
    }

    public UniversalTransferDocumentFilteringClientHandler(global::Sungero.FinancialArchive.IUniversalTransferDocumentFilterState filter)
    : base(filter)
    {
    }

    protected UniversalTransferDocumentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class UniversalTransferDocumentClientHandlers : global::Sungero.Docflow.AccountingDocumentBaseClientHandlers
  {
    private global::Sungero.FinancialArchive.IUniversalTransferDocument _obj
    {
      get { return (global::Sungero.FinancialArchive.IUniversalTransferDocument)this.Entity; }
    }

    public UniversalTransferDocumentClientHandlers(global::Sungero.FinancialArchive.IUniversalTransferDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// UniversalTransferDocumentClientFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Client
{
  public partial class UniversalTransferDocumentFunctions : global::Sungero.Docflow.Client.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IUniversalTransferDocument _obj
    {
      get { return (global::Sungero.FinancialArchive.IUniversalTransferDocument)this.Entity; }
    }

    public UniversalTransferDocumentFunctions(global::Sungero.FinancialArchive.IUniversalTransferDocument entity) : base(entity) { }
  }
}

// ==================================================================
// UniversalTransferDocumentFunctions.g.cs
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
  internal static class UniversalTransferDocument
  {
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.UniversalTransferDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTypesAvailableForChange", new System.Type[] {  });
      return (global::System.Collections.Generic.List<Domain.Shared.IEntityInfo>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.UniversalTransferDocumentFunctions" />
    internal static  global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument, global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> types)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentType", new System.Type[] { typeof(global::System.Collections.Generic.List<Domain.Shared.IEntityInfo>) });
      return (global::Sungero.Docflow.IOfficialDocument)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { types });
    }
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.UniversalTransferDocumentFunctions" />
    internal static  global::System.Boolean CanChangeDocumentType(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanChangeDocumentType", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.UniversalTransferDocumentFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentResponsibleEmployee(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentResponsibleEmployee", new System.Type[] {  });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.UniversalTransferDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmailAddressees", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.UniversalTransferDocumentFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)universalTransferDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// UniversalTransferDocumentClientPublicFunctions.g.cs
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
  public class UniversalTransferDocumentClientPublicFunctions : global::Sungero.FinancialArchive.Client.IUniversalTransferDocumentClientPublicFunctions
  {
    public global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.FinancialArchive.IUniversalTransferDocument universalTransferDocument, global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> types)
    {
      return global::Sungero.FinancialArchive.Functions.UniversalTransferDocument.ChangeDocumentType(universalTransferDocument, types);
    }
  }
}

// ==================================================================
// UniversalTransferDocumentActions.g.cs
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
  public partial class UniversalTransferDocumentActions : global::Sungero.Docflow.Client.AccountingDocumentBaseActions
  {
    private global::Sungero.FinancialArchive.IUniversalTransferDocument _obj { get { return (global::Sungero.FinancialArchive.IUniversalTransferDocument)this.Entity; } }
    public UniversalTransferDocumentActions(global::Sungero.FinancialArchive.IUniversalTransferDocument entity) : base(entity) { }
  }

  public partial class UniversalTransferDocumentCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.FinancialArchive.IUniversalTransferDocument> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.FinancialArchive.IUniversalTransferDocument>(this.Entities); }
    }
  }

  public partial class UniversalTransferDocumentCollectionBulkActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class UniversalTransferDocumentAnyChildEntityActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityActions
  {
  }

  public partial class UniversalTransferDocumentAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
