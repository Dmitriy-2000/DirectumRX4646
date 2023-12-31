
// ==================================================================
// MinutesVersionsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Shared
{
  public class MinutesVersionsState : 
    global::Sungero.Docflow.Shared.MinutesBaseVersionsState, global::Sungero.Meetings.IMinutesVersionsState
  {
    public MinutesVersionsState(global::Sungero.Meetings.IMinutesVersions entity) : base(entity) { }

    public new global::Sungero.Meetings.IMinutesVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Meetings.IMinutesVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Meetings.Shared.MinutesVersionsPropertyStates(entity);
    }


  }


  public class MinutesVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.MinutesBaseVersionsPropertyStates, global::Sungero.Meetings.IMinutesVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Meetings.IMinutes> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Meetings.IMinutes>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Meetings.IMinutes>("ElectronicDocument"); }
            }


    protected internal MinutesVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MinutesVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.MinutesBaseVersionsCollectionPropertyState<T>, global::Sungero.Meetings.IMinutesVersionsCollectionPropertyState<T>
    where T : global::Sungero.Meetings.IMinutesVersions
  {
    public new global::Sungero.Meetings.IMinutesVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Meetings.IMinutesVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Meetings.Shared.MinutesVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal MinutesVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class MinutesVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.MinutesBaseVersionsCollectionPropertyStates, global::Sungero.Meetings.IMinutesVersionsCollectionPropertyStates
  {

    protected internal MinutesVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// MinutesVersionsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Shared
{
  public class MinutesVersionsInfo : 
    global::Sungero.Docflow.Shared.MinutesBaseVersionsInfo, global::Sungero.Meetings.IMinutesVersionsInfo
  {
    public MinutesVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Meetings.IMinutesVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Meetings.IMinutesVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Meetings.Shared.MinutesVersionsPropertiesInfo(entityType);
    }

  }

  public class MinutesVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.MinutesBaseVersionsPropertiesInfo, global::Sungero.Meetings.IMinutesVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Meetings.IMinutesInfo, global::Sungero.Meetings.IMinutes> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Meetings.IMinutesInfo, global::Sungero.Meetings.IMinutes>(propertyMetadata);
          }
        }


    protected internal MinutesVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
