
// ==================================================================
// RegistrationGroupRecipientLinksState.g.cs
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
  public class RegistrationGroupRecipientLinksState : 
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksState, global::Sungero.Docflow.IRegistrationGroupRecipientLinksState
  {
    public RegistrationGroupRecipientLinksState(global::Sungero.Docflow.IRegistrationGroupRecipientLinks entity) : base(entity) { }

    public new global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupRecipientLinksPropertyStates(entity);
    }


  }


  public class RegistrationGroupRecipientLinksPropertyStates : 
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksPropertyStates, global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationGroup> Group
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationGroup>)base.Group; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IGroup> InternalGroup
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IRegistrationGroup>("Group"); }
            }


    protected internal RegistrationGroupRecipientLinksPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RegistrationGroupRecipientLinksCollectionPropertyState<T> :
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksCollectionPropertyState<T>, global::Sungero.Docflow.IRegistrationGroupRecipientLinksCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IRegistrationGroupRecipientLinks
  {
    public new global::Sungero.Docflow.IRegistrationGroupRecipientLinksCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupRecipientLinksCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupRecipientLinksCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal RegistrationGroupRecipientLinksCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class RegistrationGroupRecipientLinksCollectionPropertyStates :
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksCollectionPropertyStates, global::Sungero.Docflow.IRegistrationGroupRecipientLinksCollectionPropertyStates
  {

    protected internal RegistrationGroupRecipientLinksCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// RegistrationGroupRecipientLinksInfo.g.cs
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
  public class RegistrationGroupRecipientLinksInfo : 
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksInfo, global::Sungero.Docflow.IRegistrationGroupRecipientLinksInfo
  {
    public RegistrationGroupRecipientLinksInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupRecipientLinksPropertiesInfo(entityType);
    }

  }

  public class RegistrationGroupRecipientLinksPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.GroupRecipientLinksPropertiesInfo, global::Sungero.Docflow.IRegistrationGroupRecipientLinksPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IRegistrationGroupInfo, global::Sungero.Docflow.IRegistrationGroup> Group
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Group");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IRegistrationGroupInfo, global::Sungero.Docflow.IRegistrationGroup>(propertyMetadata);
          }
        }


    protected internal RegistrationGroupRecipientLinksPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
