
// ==================================================================
// ExchangeDocumentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ExchangeDocumentState : 
    global::Sungero.Docflow.Shared.OfficialDocumentState, global::Sungero.Docflow.IExchangeDocumentState
  {
    public ExchangeDocumentState(global::Sungero.Docflow.IExchangeDocument entity) : base(entity) { }

    public new global::Sungero.Docflow.IExchangeDocumentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IExchangeDocumentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentControlStates(entity);
    }

    public new global::Sungero.Docflow.IExchangeDocumentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentPageStates(entity);
    }

  }


  public class ExchangeDocumentControlStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentControlStates, global::Sungero.Docflow.IExchangeDocumentControlStates
  {

    protected internal ExchangeDocumentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ExchangeDocumentPageStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentPageStates, global::Sungero.Docflow.IExchangeDocumentPageStates
  {

    protected internal ExchangeDocumentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ExchangeDocumentPropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentPropertyStates, global::Sungero.Docflow.IExchangeDocumentPropertyStates
  {
            public new global::Sungero.Docflow.IExchangeDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentVersions> Versions
            {
              get { return (global::Sungero.Docflow.IExchangeDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ExchangeDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentVersions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IExchangeDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentTracking> Tracking
            {
              get { return (global::Sungero.Docflow.IExchangeDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ExchangeDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IExchangeDocumentTracking>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> Counterparty 
            {
              get { return this.InternalCounterparty; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCounterparty
            {
              get { return this.GetPropertyState<global::Sungero.Parties.ICounterparty>("Counterparty"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> BusinessUnitBox 
            {
              get { return this.InternalBusinessUnitBox; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> InternalBusinessUnitBox
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox>("BusinessUnitBox"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> CounterpartySignatory 
            {
              get { return this.InternalCounterpartySignatory; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> InternalCounterpartySignatory
            {
              get { return this.GetPropertyState<global::Sungero.Parties.IContact>("CounterpartySignatory"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> CounterpartySigningReason 
            {
              get { return this.GetPropertyState<global::System.String>("CounterpartySigningReason"); }
            }


    protected internal ExchangeDocumentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ExchangeDocumentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ExchangeDocumentInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentInfo, global::Sungero.Docflow.IExchangeDocumentInfo
  {
    public ExchangeDocumentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IExchangeDocumentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentPropertiesInfo(entityType);
    }

  }

  public class ExchangeDocumentPropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentPropertiesInfo, global::Sungero.Docflow.IExchangeDocumentPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IExchangeDocumentVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IExchangeDocumentVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IExchangeDocumentTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IExchangeDocumentTrackingPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty> Counterparty 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Counterparty");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox> BusinessUnitBox 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("BusinessUnitBox");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact> CounterpartySignatory 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("CounterpartySignatory");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo CounterpartySigningReason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("CounterpartySigningReason");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal ExchangeDocumentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ExchangeDocumentHandlers.g.cs
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
  public partial class ExchangeDocumentSharedHandlers : global::Sungero.Docflow.OfficialDocumentSharedHandlers, IExchangeDocumentSharedHandlers
  {
    private global::Sungero.Docflow.IExchangeDocument _obj
    {
      get { return (global::Sungero.Docflow.IExchangeDocument)this.Entity; }
    }
    public virtual void CounterpartyChanged(global::Sungero.Docflow.Shared.ExchangeDocumentCounterpartyChangedEventArgs e) { }


    public virtual void BusinessUnitBoxChanged(global::Sungero.Docflow.Shared.ExchangeDocumentBusinessUnitBoxChangedEventArgs e) { }


    public virtual void CounterpartySignatoryChanged(global::Sungero.Docflow.Shared.ExchangeDocumentCounterpartySignatoryChangedEventArgs e) { }


    public virtual void CounterpartySigningReasonChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public ExchangeDocumentSharedHandlers(global::Sungero.Docflow.IExchangeDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExchangeDocumentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ExchangeDocument
{
  /// <summary>
  /// Represents ExchangeDocument resources.
  /// </summary>
  public class ExchangeDocumentResources : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentResources, global::Sungero.Docflow.ExchangeDocument.IExchangeDocumentResources
  {
    public virtual global::CommonLibrary.LocalizedString ChangeDocumentTypeHint
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument) , "ChangeDocumentTypeHint");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ChangeDocumentTypeHintFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument), "ChangeDocumentTypeHint", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString From
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument) , "From");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FromFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument), "From", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString TypeChange
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument) , "TypeChange");
      }
    }

    public virtual global::CommonLibrary.LocalizedString TypeChangeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument), "TypeChange", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ChangeDocumentTypeLockError
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument) , "ChangeDocumentTypeLockError");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ChangeDocumentTypeLockErrorFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IExchangeDocument), "ChangeDocumentTypeLockError", false, args);
    }

  }
}

// ==================================================================
// ExchangeDocumentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ExchangeDocumentFunctions : global::Sungero.Docflow.Shared.OfficialDocumentFunctions
  {
    private global::Sungero.Docflow.IExchangeDocument _obj
    {
      get { return (global::Sungero.Docflow.IExchangeDocument)this.Entity; }
    }

    public ExchangeDocumentFunctions(global::Sungero.Docflow.IExchangeDocument entity) : base(entity) { }
  }
}

// ==================================================================
// ExchangeDocumentFunctions.g.cs
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
  internal static class ExchangeDocument
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  global::System.String GetCounterpartySigningReason(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartySigningReason", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void FillCounterpartySignatory(global::Sungero.Docflow.IExchangeDocument exchangeDocument, global::Sungero.Parties.IContact signatory)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySignatory", new System.Type[] { typeof(global::Sungero.Parties.IContact) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signatory });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void FillCounterpartySigningReason(global::Sungero.Docflow.IExchangeDocument exchangeDocument, global::System.String signingReason)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySigningReason", new System.Type[] { typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signingReason });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IExchangeDocument exchangeDocument, global::System.Boolean isEnabled, global::System.Boolean counterpartyCodeInNumber)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, counterpartyCodeInNumber });
    }

  }
}

// ==================================================================
// ExchangeDocumentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ExchangeDocument
{

  public class ExchangeDocumentFilterInfo : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentFilterInfo,
    global::Sungero.Docflow.IExchangeDocumentFilterInfo
  {
  }

  public class ExchangeDocumentFilterState : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentFilterState,
    global::Sungero.Docflow.IExchangeDocumentFilterState
  {



    public new Sungero.Docflow.IExchangeDocumentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IExchangeDocumentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ExchangeDocument.ExchangeDocumentFilterInfo();
    }

  }
}

// ==================================================================
// ExchangeDocumentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ExchangeDocumentSharedPublicFunctions : global::Sungero.Docflow.Shared.IExchangeDocumentSharedPublicFunctions
  {
    public global::System.String GetCounterpartySigningReason(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      return global::Sungero.Docflow.Functions.ExchangeDocument.GetCounterpartySigningReason(exchangeDocument);
    }
  }
}
