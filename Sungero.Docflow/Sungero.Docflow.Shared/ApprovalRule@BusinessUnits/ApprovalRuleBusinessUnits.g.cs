
// ==================================================================
// ApprovalRuleBusinessUnitsState.g.cs
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
  public class ApprovalRuleBusinessUnitsState : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsState, global::Sungero.Docflow.IApprovalRuleBusinessUnitsState
  {
    public ApprovalRuleBusinessUnitsState(global::Sungero.Docflow.IApprovalRuleBusinessUnits entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBusinessUnitsPropertyStates(entity);
    }


  }


  public class ApprovalRuleBusinessUnitsPropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsPropertyStates, global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRule> ApprovalRuleBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRule>)base.ApprovalRuleBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRuleBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRule>("ApprovalRuleBase"); }
            }


    protected internal ApprovalRuleBusinessUnitsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRuleBusinessUnitsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalRuleBusinessUnits
  {
    public new global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBusinessUnitsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalRuleBusinessUnitsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalRuleBusinessUnitsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsCollectionPropertyStates, global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyStates
  {

    protected internal ApprovalRuleBusinessUnitsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalRuleBusinessUnitsInfo.g.cs
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
  public class ApprovalRuleBusinessUnitsInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsInfo, global::Sungero.Docflow.IApprovalRuleBusinessUnitsInfo
  {
    public ApprovalRuleBusinessUnitsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBusinessUnitsPropertiesInfo(entityType);
    }

  }

  public class ApprovalRuleBusinessUnitsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsPropertiesInfo, global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleInfo, global::Sungero.Docflow.IApprovalRule> ApprovalRuleBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRuleBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleInfo, global::Sungero.Docflow.IApprovalRule>(propertyMetadata);
          }
        }


    protected internal ApprovalRuleBusinessUnitsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
