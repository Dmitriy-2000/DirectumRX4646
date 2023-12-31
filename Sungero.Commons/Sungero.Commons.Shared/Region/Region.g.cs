
// ==================================================================
// RegionState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class RegionState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Commons.IRegionState
  {
    public RegionState(global::Sungero.Commons.IRegion entity) : base(entity) { }

    public new global::Sungero.Commons.IRegionPropertyStates Properties
    {
      get { return (global::Sungero.Commons.IRegionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.RegionPropertyStates(entity);
    }


    public new global::Sungero.Commons.IRegionControlStates Controls
    {
      get { return (global::Sungero.Commons.IRegionControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.RegionControlStates(entity);
    }

    public new global::Sungero.Commons.IRegionPageStates Pages
    {
      get { return (global::Sungero.Commons.IRegionPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.RegionPageStates(entity);
    }

  }


  public class RegionControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Commons.IRegionControlStates
  {

    protected internal RegionControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class RegionPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Commons.IRegionPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal RegionPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RegionPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Commons.IRegionPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.ICountry> Country 
            {
              get { return this.InternalCountry; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.ICountry> InternalCountry
            {
              get { return this.GetPropertyState<global::Sungero.Commons.ICountry>("Country"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Code 
            {
              get { return this.GetPropertyState<global::System.String>("Code"); }
            }


    protected internal RegionPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// RegionInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class RegionInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Commons.IRegionInfo
  {
    public RegionInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Commons.IRegionPropertiesInfo Properties
    {
      get { return (global::Sungero.Commons.IRegionPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.RegionPropertiesInfo(entityType);
    }

  }

  public class RegionPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Commons.IRegionPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Commons.ICountryInfo, global::Sungero.Commons.ICountry> Country 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Country");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Commons.ICountryInfo, global::Sungero.Commons.ICountry>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Code 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Code");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal RegionPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// RegionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{
  public partial class RegionSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IRegionSharedHandlers
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void CountryChanged(global::Sungero.Commons.Shared.RegionCountryChangedEventArgs e) { }


    public virtual void CodeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public RegionSharedHandlers(global::Sungero.Commons.IRegion entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RegionResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared.Region
{
  /// <summary>
  /// Represents Region resources.
  /// </summary>
  public class RegionResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Commons.Region.IRegionResources
  {
    public virtual global::CommonLibrary.LocalizedString CodeDuplicate
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Commons.IRegion) , "CodeDuplicate");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CodeDuplicateFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Commons.IRegion), "CodeDuplicate", false, args);
    }

  }
}

// ==================================================================
// RegionSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Shared
{
  public partial class RegionFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public RegionFunctions(global::Sungero.Commons.IRegion entity) : base(entity) { }
  }
}

// ==================================================================
// RegionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class Region
  {
  }
}

// ==================================================================
// RegionFilterState.g.cs
// ==================================================================

namespace Sungero.Commons.Shared.Region
{

  public class RegionFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Commons.IRegionFilterInfo
  {
  }

  public class RegionFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Commons.IRegionFilterState
  {



    public new Sungero.Commons.IRegionFilterInfo Info
    {
      get
      {
        return (Sungero.Commons.IRegionFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Commons.Shared.Region.RegionFilterInfo();
    }

  }
}

// ==================================================================
// RegionSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class RegionSharedPublicFunctions : global::Sungero.Commons.Shared.IRegionSharedPublicFunctions
  {
  }
}
