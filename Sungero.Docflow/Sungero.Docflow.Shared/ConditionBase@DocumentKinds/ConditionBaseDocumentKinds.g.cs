
// ==================================================================
// ConditionBaseDocumentKindsState.g.cs
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
  public class ConditionBaseDocumentKindsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IConditionBaseDocumentKindsState
  {
    public ConditionBaseDocumentKindsState(global::Sungero.Docflow.IConditionBaseDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Docflow.IConditionBaseDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsPropertyStates(entity);
    }


  }


  public class ConditionBaseDocumentKindsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IConditionBaseDocumentKindsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IConditionBase> ConditionBase 
            {
              get { return this.InternalConditionBase; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IConditionBase> InternalConditionBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IConditionBase>("ConditionBase"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> DocumentKind 
            {
              get { return this.InternalDocumentKind; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> InternalDocumentKind
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentKind>("DocumentKind"); }
            }


    protected internal ConditionBaseDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ConditionBaseDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IConditionBaseDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IConditionBaseDocumentKinds
  {
    public new global::Sungero.Docflow.IConditionBaseDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ConditionBaseDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ConditionBaseDocumentKindsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IConditionBaseDocumentKindsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ConditionBase
        {
          get { return this.GetChildPropertySummaryState("ConditionBase"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentKind
        {
          get { return this.GetChildPropertySummaryState("DocumentKind"); }
        }


    protected internal ConditionBaseDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ConditionBaseDocumentKindsInfo.g.cs
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
  public class ConditionBaseDocumentKindsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IConditionBaseDocumentKindsInfo
  {
    public ConditionBaseDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IConditionBaseDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class ConditionBaseDocumentKindsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IConditionBaseDocumentKindsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IConditionBaseInfo, global::Sungero.Docflow.IConditionBase> ConditionBase 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ConditionBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IConditionBaseInfo, global::Sungero.Docflow.IConditionBase>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentKindInfo, global::Sungero.Docflow.IDocumentKind> DocumentKind 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentKind");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentKindInfo, global::Sungero.Docflow.IDocumentKind>(propertyMetadata);
          }
        }


    protected internal ConditionBaseDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
