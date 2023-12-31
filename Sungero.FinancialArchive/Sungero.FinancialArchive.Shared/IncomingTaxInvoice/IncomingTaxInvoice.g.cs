
// ==================================================================
// IncomingTaxInvoiceState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{
  public class IncomingTaxInvoiceState : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseState, global::Sungero.FinancialArchive.IIncomingTaxInvoiceState
  {
    public IncomingTaxInvoiceState(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity) : base(entity) { }

    public new global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertyStates Properties
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoicePropertyStates(entity);
    }


    public new global::Sungero.FinancialArchive.IIncomingTaxInvoiceControlStates Controls
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceControlStates(entity);
    }

    public new global::Sungero.FinancialArchive.IIncomingTaxInvoicePageStates Pages
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoicePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoicePageStates(entity);
    }

  }


  public class IncomingTaxInvoiceControlStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseControlStates, global::Sungero.FinancialArchive.IIncomingTaxInvoiceControlStates
  {

    protected internal IncomingTaxInvoiceControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class IncomingTaxInvoicePageStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePageStates, global::Sungero.FinancialArchive.IIncomingTaxInvoicePageStates
  {

    protected internal IncomingTaxInvoicePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class IncomingTaxInvoicePropertyStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePropertyStates, global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertyStates
  {
            public new global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions> Versions
            {
              get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceVersionsCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions>(entity, propertyName);
            }
            public new global::Sungero.FinancialArchive.IIncomingTaxInvoiceTrackingCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking> Tracking
            {
              get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceTrackingCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceTrackingCollectionPropertyState<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking>(entity, propertyName);
            }


    protected internal IncomingTaxInvoicePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// IncomingTaxInvoiceInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{
  public class IncomingTaxInvoiceInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseInfo, global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo
  {
    public IncomingTaxInvoiceInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertiesInfo Properties
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoicePropertiesInfo(entityType);
    }

  }

  public class IncomingTaxInvoicePropertiesInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBasePropertiesInfo, global::Sungero.FinancialArchive.IIncomingTaxInvoicePropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTrackingPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal IncomingTaxInvoicePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// IncomingTaxInvoiceHandlers.g.cs
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
  public partial class IncomingTaxInvoiceSharedHandlers : global::Sungero.Docflow.AccountingDocumentBaseSharedHandlers, IIncomingTaxInvoiceSharedHandlers
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _obj
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Entity; }
    }


    public IncomingTaxInvoiceSharedHandlers(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// IncomingTaxInvoiceResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared.IncomingTaxInvoice
{
  /// <summary>
  /// Represents IncomingTaxInvoice resources.
  /// </summary>
  public class IncomingTaxInvoiceResources : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseResources, global::Sungero.FinancialArchive.IncomingTaxInvoice.IIncomingTaxInvoiceResources
  {
    public override global::CommonLibrary.LocalizedString NamePartForContractor
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.FinancialArchive.IIncomingTaxInvoice) , "NamePartForContractor");
      }
    }

    public override global::CommonLibrary.LocalizedString NamePartForContractorFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.FinancialArchive.IIncomingTaxInvoice), "NamePartForContractor", false, args);
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceSharedFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Shared
{
  public partial class IncomingTaxInvoiceFunctions : global::Sungero.Docflow.Shared.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _obj
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Entity; }
    }

    public IncomingTaxInvoiceFunctions(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity) : base(entity) { }
  }
}

// ==================================================================
// IncomingTaxInvoiceFunctions.g.cs
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
  internal static class IncomingTaxInvoice
  {
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions" />
    internal static  void FillName(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingTaxInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingTaxInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmailAddressees", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)incomingTaxInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceFilterState.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Shared.IncomingTaxInvoice
{

  public class IncomingTaxInvoiceFilterInfo : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseFilterInfo,
    global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterInfo
  {
  }

  public class IncomingTaxInvoiceFilterState : global::Sungero.Docflow.Shared.AccountingDocumentBase.AccountingDocumentBaseFilterState,
    global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState
  {



    public new Sungero.FinancialArchive.IIncomingTaxInvoiceFilterInfo Info
    {
      get
      {
        return (Sungero.FinancialArchive.IIncomingTaxInvoiceFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.FinancialArchive.Shared.IncomingTaxInvoice.IncomingTaxInvoiceFilterInfo();
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{
  public class IncomingTaxInvoiceSharedPublicFunctions : global::Sungero.FinancialArchive.Shared.IIncomingTaxInvoiceSharedPublicFunctions
  {
    public global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      return global::Sungero.FinancialArchive.Functions.IncomingTaxInvoice.GetEmailAddressees(incomingTaxInvoice);
    }
    public global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      return global::Sungero.FinancialArchive.Functions.IncomingTaxInvoice.IsVerificationModeSupported(incomingTaxInvoice);
    }
  }
}
