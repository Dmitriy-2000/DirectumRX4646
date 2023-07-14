
// ==================================================================
// ApprovalStageApprovalRolesState.g.cs
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
  public class ApprovalStageApprovalRolesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalStageApprovalRolesState
  {
    public ApprovalStageApprovalRolesState(global::Sungero.Docflow.IApprovalStageApprovalRoles entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalStageApprovalRolesPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageApprovalRolesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageApprovalRolesPropertyStates(entity);
    }


  }


  public class ApprovalStageApprovalRolesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalStageApprovalRolesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> ApprovalStage 
            {
              get { return this.InternalApprovalStage; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> InternalApprovalStage
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalStage>("ApprovalStage"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRoleBase> ApprovalRole 
            {
              get { return this.InternalApprovalRole; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRoleBase> InternalApprovalRole
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRoleBase>("ApprovalRole"); }
            }


    protected internal ApprovalStageApprovalRolesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalStageApprovalRolesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalStageApprovalRolesCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalStageApprovalRoles
  {
    public new global::Sungero.Docflow.IApprovalStageApprovalRolesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageApprovalRolesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageApprovalRolesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalStageApprovalRolesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalStageApprovalRolesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalStageApprovalRolesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalStage
        {
          get { return this.GetChildPropertySummaryState("ApprovalStage"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalRole
        {
          get { return this.GetChildPropertySummaryState("ApprovalRole"); }
        }


    protected internal ApprovalStageApprovalRolesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalStageApprovalRolesInfo.g.cs
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
  public class ApprovalStageApprovalRolesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalStageApprovalRolesInfo
  {
    public ApprovalStageApprovalRolesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalStageApprovalRolesPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalStageApprovalRolesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageApprovalRolesPropertiesInfo(entityType);
    }

  }

  public class ApprovalStageApprovalRolesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalStageApprovalRolesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage> ApprovalStage 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalStage");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRoleBaseInfo, global::Sungero.Docflow.IApprovalRoleBase> ApprovalRole 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRole");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRoleBaseInfo, global::Sungero.Docflow.IApprovalRoleBase>(propertyMetadata);
          }
        }


    protected internal ApprovalStageApprovalRolesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}