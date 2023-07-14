
// ==================================================================
// VisibilityRuleRecipientsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class VisibilityRuleRecipientsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Company.IVisibilityRuleRecipientsState
  {
    public VisibilityRuleRecipientsState(global::Sungero.Company.IVisibilityRuleRecipients entity) : base(entity) { }

    public new global::Sungero.Company.IVisibilityRuleRecipientsPropertyStates Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipientsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.VisibilityRuleRecipientsPropertyStates(entity);
    }


  }


  public class VisibilityRuleRecipientsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Company.IVisibilityRuleRecipientsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IVisibilityRule> VisibilityRule 
            {
              get { return this.InternalVisibilityRule; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IVisibilityRule> InternalVisibilityRule
            {
              get { return this.GetPropertyState<global::Sungero.Company.IVisibilityRule>("VisibilityRule"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> Recipient 
            {
              get { return this.InternalRecipient; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> InternalRecipient
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IRecipient>("Recipient"); }
            }


    protected internal VisibilityRuleRecipientsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class VisibilityRuleRecipientsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyState<T>
    where T : global::Sungero.Company.IVisibilityRuleRecipients
  {
    public new global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleRecipientsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal VisibilityRuleRecipientsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class VisibilityRuleRecipientsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState VisibilityRule
        {
          get { return this.GetChildPropertySummaryState("VisibilityRule"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Recipient
        {
          get { return this.GetChildPropertySummaryState("Recipient"); }
        }


    protected internal VisibilityRuleRecipientsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// VisibilityRuleRecipientsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class VisibilityRuleRecipientsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Company.IVisibilityRuleRecipientsInfo
  {
    public VisibilityRuleRecipientsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Company.IVisibilityRuleRecipientsPropertiesInfo Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipientsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Company.Shared.VisibilityRuleRecipientsPropertiesInfo(entityType);
    }

  }

  public class VisibilityRuleRecipientsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Company.IVisibilityRuleRecipientsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IVisibilityRuleInfo, global::Sungero.Company.IVisibilityRule> VisibilityRule 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("VisibilityRule");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IVisibilityRuleInfo, global::Sungero.Company.IVisibilityRule>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient> Recipient 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Recipient");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient>(propertyMetadata);
          }
        }


    protected internal VisibilityRuleRecipientsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
