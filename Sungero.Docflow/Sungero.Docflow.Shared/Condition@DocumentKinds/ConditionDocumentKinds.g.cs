
// ==================================================================
// ConditionDocumentKindsState.g.cs
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
  public class ConditionDocumentKindsState : 
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsState, global::Sungero.Docflow.IConditionDocumentKindsState
  {
    public ConditionDocumentKindsState(global::Sungero.Docflow.IConditionDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Docflow.IConditionDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IConditionDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ConditionDocumentKindsPropertyStates(entity);
    }


  }


  public class ConditionDocumentKindsPropertyStates : 
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsPropertyStates, global::Sungero.Docflow.IConditionDocumentKindsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ICondition> ConditionBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ICondition>)base.ConditionBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IConditionBase> InternalConditionBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ICondition>("ConditionBase"); }
            }


    protected internal ConditionDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ConditionDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsCollectionPropertyState<T>, global::Sungero.Docflow.IConditionDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IConditionDocumentKinds
  {
    public new global::Sungero.Docflow.IConditionDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IConditionDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ConditionDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ConditionDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ConditionDocumentKindsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsCollectionPropertyStates, global::Sungero.Docflow.IConditionDocumentKindsCollectionPropertyStates
  {

    protected internal ConditionDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ConditionDocumentKindsInfo.g.cs
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
  public class ConditionDocumentKindsInfo : 
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsInfo, global::Sungero.Docflow.IConditionDocumentKindsInfo
  {
    public ConditionDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IConditionDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IConditionDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ConditionDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class ConditionDocumentKindsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsPropertiesInfo, global::Sungero.Docflow.IConditionDocumentKindsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IConditionInfo, global::Sungero.Docflow.ICondition> ConditionBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ConditionBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IConditionInfo, global::Sungero.Docflow.ICondition>(propertyMetadata);
          }
        }


    protected internal ConditionDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
