
// ==================================================================
// ContractConditionConditionDocumentKindsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractConditionConditionDocumentKindsState : 
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsState, global::Sungero.Contracts.IContractConditionConditionDocumentKindsState
  {
    public ContractConditionConditionDocumentKindsState(global::Sungero.Contracts.IContractConditionConditionDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractConditionConditionDocumentKindsPropertyStates(entity);
    }


  }


  public class ContractConditionConditionDocumentKindsPropertyStates : 
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsPropertyStates, global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractCondition> ConditionBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractCondition>)base.ConditionBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IConditionBase> InternalConditionBase
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IContractCondition>("ConditionBase"); }
            }


    protected internal ContractConditionConditionDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractConditionConditionDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsCollectionPropertyState<T>, global::Sungero.Contracts.IContractConditionConditionDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Contracts.IContractConditionConditionDocumentKinds
  {
    public new global::Sungero.Contracts.IContractConditionConditionDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractConditionConditionDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Contracts.Shared.ContractConditionConditionDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ContractConditionConditionDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ContractConditionConditionDocumentKindsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsCollectionPropertyStates, global::Sungero.Contracts.IContractConditionConditionDocumentKindsCollectionPropertyStates
  {

    protected internal ContractConditionConditionDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ContractConditionConditionDocumentKindsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractConditionConditionDocumentKindsInfo : 
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsInfo, global::Sungero.Contracts.IContractConditionConditionDocumentKindsInfo
  {
    public ContractConditionConditionDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.ContractConditionConditionDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class ContractConditionConditionDocumentKindsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ConditionBaseConditionDocumentKindsPropertiesInfo, global::Sungero.Contracts.IContractConditionConditionDocumentKindsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IContractConditionInfo, global::Sungero.Contracts.IContractCondition> ConditionBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ConditionBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IContractConditionInfo, global::Sungero.Contracts.IContractCondition>(propertyMetadata);
          }
        }


    protected internal ContractConditionConditionDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
