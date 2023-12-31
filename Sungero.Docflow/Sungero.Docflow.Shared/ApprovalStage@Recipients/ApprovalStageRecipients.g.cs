
// ==================================================================
// ApprovalStageRecipientsState.g.cs
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
  public class ApprovalStageRecipientsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalStageRecipientsState
  {
    public ApprovalStageRecipientsState(global::Sungero.Docflow.IApprovalStageRecipients entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalStageRecipientsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageRecipientsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageRecipientsPropertyStates(entity);
    }


  }


  public class ApprovalStageRecipientsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalStageRecipientsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> ApprovalStage 
            {
              get { return this.InternalApprovalStage; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> InternalApprovalStage
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalStage>("ApprovalStage"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> Recipient 
            {
              get { return this.InternalRecipient; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> InternalRecipient
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IRecipient>("Recipient"); }
            }


    protected internal ApprovalStageRecipientsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalStageRecipientsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalStageRecipientsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalStageRecipients
  {
    public new global::Sungero.Docflow.IApprovalStageRecipientsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageRecipientsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageRecipientsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalStageRecipientsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalStageRecipientsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalStageRecipientsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalStage
        {
          get { return this.GetChildPropertySummaryState("ApprovalStage"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Recipient
        {
          get { return this.GetChildPropertySummaryState("Recipient"); }
        }


    protected internal ApprovalStageRecipientsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalStageRecipientsInfo.g.cs
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
  public class ApprovalStageRecipientsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalStageRecipientsInfo
  {
    public ApprovalStageRecipientsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalStageRecipientsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageRecipientsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageRecipientsPropertiesInfo(entityType);
    }

  }

  public class ApprovalStageRecipientsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalStageRecipientsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage> ApprovalStage 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalStage");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage>(propertyMetadata);
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


    protected internal ApprovalStageRecipientsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
