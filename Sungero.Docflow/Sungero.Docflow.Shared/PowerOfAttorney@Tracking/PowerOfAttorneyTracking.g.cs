
// ==================================================================
// PowerOfAttorneyTrackingState.g.cs
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
  public class PowerOfAttorneyTrackingState : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingState, global::Sungero.Docflow.IPowerOfAttorneyTrackingState
  {
    public PowerOfAttorneyTrackingState(global::Sungero.Docflow.IPowerOfAttorneyTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyTrackingPropertyStates(entity);
    }


  }


  public class PowerOfAttorneyTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorney> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorney>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IPowerOfAttorney>("OfficialDocument"); }
            }


    protected internal PowerOfAttorneyTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PowerOfAttorneyTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingCollectionPropertyState<T>, global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IPowerOfAttorneyTracking
  {
    public new global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal PowerOfAttorneyTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class PowerOfAttorneyTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingCollectionPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyTrackingCollectionPropertyStates
  {

    protected internal PowerOfAttorneyTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// PowerOfAttorneyTrackingInfo.g.cs
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
  public class PowerOfAttorneyTrackingInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingInfo, global::Sungero.Docflow.IPowerOfAttorneyTrackingInfo
  {
    public PowerOfAttorneyTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyTrackingPropertiesInfo(entityType);
    }

  }

  public class PowerOfAttorneyTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingPropertiesInfo, global::Sungero.Docflow.IPowerOfAttorneyTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyInfo, global::Sungero.Docflow.IPowerOfAttorney> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyInfo, global::Sungero.Docflow.IPowerOfAttorney>(propertyMetadata);
          }
        }


    protected internal PowerOfAttorneyTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
