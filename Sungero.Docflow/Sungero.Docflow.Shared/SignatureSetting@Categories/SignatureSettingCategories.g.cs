
// ==================================================================
// SignatureSettingCategoriesState.g.cs
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
  public class SignatureSettingCategoriesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.ISignatureSettingCategoriesState
  {
    public SignatureSettingCategoriesState(global::Sungero.Docflow.ISignatureSettingCategories entity) : base(entity) { }

    public new global::Sungero.Docflow.ISignatureSettingCategoriesPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategoriesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingCategoriesPropertyStates(entity);
    }


  }


  public class SignatureSettingCategoriesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.ISignatureSettingCategoriesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
            {
              get { return this.InternalSignatureSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> InternalSignatureSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ISignatureSetting>("SignatureSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentGroupBase> Category 
            {
              get { return this.InternalCategory; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentGroupBase> InternalCategory
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentGroupBase>("Category"); }
            }


    protected internal SignatureSettingCategoriesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SignatureSettingCategoriesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.ISignatureSettingCategoriesCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ISignatureSettingCategories
  {
    public new global::Sungero.Docflow.ISignatureSettingCategoriesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategoriesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingCategoriesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SignatureSettingCategoriesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SignatureSettingCategoriesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.ISignatureSettingCategoriesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SignatureSetting
        {
          get { return this.GetChildPropertySummaryState("SignatureSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Category
        {
          get { return this.GetChildPropertySummaryState("Category"); }
        }


    protected internal SignatureSettingCategoriesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SignatureSettingCategoriesInfo.g.cs
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
  public class SignatureSettingCategoriesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.ISignatureSettingCategoriesInfo
  {
    public SignatureSettingCategoriesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ISignatureSettingCategoriesPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategoriesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingCategoriesPropertiesInfo(entityType);
    }

  }

  public class SignatureSettingCategoriesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.ISignatureSettingCategoriesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("SignatureSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseInfo, global::Sungero.Docflow.IDocumentGroupBase> Category 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Category");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseInfo, global::Sungero.Docflow.IDocumentGroupBase>(propertyMetadata);
          }
        }


    protected internal SignatureSettingCategoriesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
