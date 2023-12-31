
// ==================================================================
// PowerOfAttorneyState.g.cs
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
  public class PowerOfAttorneyState : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseState, global::Sungero.Docflow.IPowerOfAttorneyState
  {
    public PowerOfAttorneyState(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IPowerOfAttorneyControlStates Controls
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyControlStates(entity);
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyPageStates Pages
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyPageStates(entity);
    }

  }


  public class PowerOfAttorneyControlStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseControlStates, global::Sungero.Docflow.IPowerOfAttorneyControlStates
  {

    protected internal PowerOfAttorneyControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class PowerOfAttorneyPageStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBasePageStates, global::Sungero.Docflow.IPowerOfAttorneyPageStates
  {

    protected internal PowerOfAttorneyPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PowerOfAttorneyPropertyStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBasePropertyStates, global::Sungero.Docflow.IPowerOfAttorneyPropertyStates
  {
            public new global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyVersions> Versions
            {
              get { return (global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.PowerOfAttorneyVersionsCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyVersions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyTracking> Tracking
            {
              get { return (global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.PowerOfAttorneyTrackingCollectionPropertyState<global::Sungero.Docflow.IPowerOfAttorneyTracking>(entity, propertyName);
            }


    protected internal PowerOfAttorneyPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// PowerOfAttorneyInfo.g.cs
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
  public class PowerOfAttorneyInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseInfo, global::Sungero.Docflow.IPowerOfAttorneyInfo
  {
    public PowerOfAttorneyInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyPropertiesInfo(entityType);
    }

  }

  public class PowerOfAttorneyPropertiesInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBasePropertiesInfo, global::Sungero.Docflow.IPowerOfAttorneyPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal PowerOfAttorneyPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// PowerOfAttorneyHandlers.g.cs
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
  public partial class PowerOfAttorneySharedHandlers : global::Sungero.Docflow.PowerOfAttorneyBaseSharedHandlers, IPowerOfAttorneySharedHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }


    public PowerOfAttorneySharedHandlers(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.PowerOfAttorney
{
  /// <summary>
  /// Represents PowerOfAttorney resources.
  /// </summary>
  public class PowerOfAttorneyResources : global::Sungero.Docflow.Shared.PowerOfAttorneyBase.PowerOfAttorneyBaseResources, global::Sungero.Docflow.PowerOfAttorney.IPowerOfAttorneyResources
  {
  }
}

// ==================================================================
// PowerOfAttorneySharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class PowerOfAttorneyFunctions : global::Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyFunctions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyFunctions.g.cs
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
  internal static class PowerOfAttorney
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney> GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee employee, global::System.Nullable<global::System.DateTime> date)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney>>(
          global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627"),
          "GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee,global::System.Nullable<global::System.DateTime>)"
      , employee, date);
      }

    }
  }
}

// ==================================================================
// PowerOfAttorneyFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.PowerOfAttorney
{

  public class PowerOfAttorneyFilterInfo : global::Sungero.Docflow.Shared.PowerOfAttorneyBase.PowerOfAttorneyBaseFilterInfo,
    global::Sungero.Docflow.IPowerOfAttorneyFilterInfo
  {
  }

  public class PowerOfAttorneyFilterState : global::Sungero.Docflow.Shared.PowerOfAttorneyBase.PowerOfAttorneyBaseFilterState,
    global::Sungero.Docflow.IPowerOfAttorneyFilterState
  {



    public new Sungero.Docflow.IPowerOfAttorneyFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.PowerOfAttorney.PowerOfAttorneyFilterInfo();
    }

  }
}

// ==================================================================
// PowerOfAttorneySharedPublicFunctions.g.cs
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
  public class PowerOfAttorneySharedPublicFunctions : global::Sungero.Docflow.Shared.IPowerOfAttorneySharedPublicFunctions
  {
    public global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney> Remote_GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee employee, global::System.Nullable<global::System.DateTime> date)
    {
      return global::Sungero.Docflow.Functions.PowerOfAttorney.Remote.GetActivePowerOfAttorneys(employee, date);
    }
  }
}
