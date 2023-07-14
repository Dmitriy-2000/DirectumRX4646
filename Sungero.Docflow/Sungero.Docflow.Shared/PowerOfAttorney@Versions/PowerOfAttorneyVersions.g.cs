
// ==================================================================
// PowerOfAttorneyVersionsState.g.cs
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
  public class PowerOfAttorneyVersionsState : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsState, global::Sungero.Docflow.IPowerOfAttorneyVersionsState
  {
    public PowerOfAttorneyVersionsState(global::Sungero.Docflow.IPowerOfAttorneyVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyVersionsPropertyStates(entity);
    }


  }


  public class PowerOfAttorneyVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorney> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorney>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IPowerOfAttorney>("ElectronicDocument"); }
            }


    protected internal PowerOfAttorneyVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PowerOfAttorneyVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IPowerOfAttorneyVersions
  {
    public new global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal PowerOfAttorneyVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class PowerOfAttorneyVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsCollectionPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyVersionsCollectionPropertyStates
  {

    protected internal PowerOfAttorneyVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// PowerOfAttorneyVersionsInfo.g.cs
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
  public class PowerOfAttorneyVersionsInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsInfo, global::Sungero.Docflow.IPowerOfAttorneyVersionsInfo
  {
    public PowerOfAttorneyVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyVersionsPropertiesInfo(entityType);
    }

  }

  public class PowerOfAttorneyVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsPropertiesInfo, global::Sungero.Docflow.IPowerOfAttorneyVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyInfo, global::Sungero.Docflow.IPowerOfAttorney> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyInfo, global::Sungero.Docflow.IPowerOfAttorney>(propertyMetadata);
          }
        }


    protected internal PowerOfAttorneyVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}