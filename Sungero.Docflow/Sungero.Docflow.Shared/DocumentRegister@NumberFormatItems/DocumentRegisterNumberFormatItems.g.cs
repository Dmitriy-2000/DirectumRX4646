
// ==================================================================
// DocumentRegisterNumberFormatItemsState.g.cs
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
  public class DocumentRegisterNumberFormatItemsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsState
  {
    public DocumentRegisterNumberFormatItemsState(global::Sungero.Docflow.IDocumentRegisterNumberFormatItems entity) : base(entity) { }

    public new global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentRegisterNumberFormatItemsPropertyStates(entity);
    }


  }


  public class DocumentRegisterNumberFormatItemsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentRegister> DocumentRegister 
            {
              get { return this.InternalDocumentRegister; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentRegister> InternalDocumentRegister
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentRegister>("DocumentRegister"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Number 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Number"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Separator 
            {
              get { return this.GetPropertyState<global::System.String>("Separator"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> Element 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("Element"); }
            }


    protected internal DocumentRegisterNumberFormatItemsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DocumentRegisterNumberFormatItemsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IDocumentRegisterNumberFormatItems
  {
    public new global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.DocumentRegisterNumberFormatItemsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal DocumentRegisterNumberFormatItemsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class DocumentRegisterNumberFormatItemsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentRegister
        {
          get { return this.GetChildPropertySummaryState("DocumentRegister"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Number
        {
          get { return this.GetChildPropertySummaryState("Number"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Separator
        {
          get { return this.GetChildPropertySummaryState("Separator"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Element
        {
          get { return this.GetChildPropertySummaryState("Element"); }
        }


    protected internal DocumentRegisterNumberFormatItemsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// DocumentRegisterNumberFormatItemsInfo.g.cs
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
  public class DocumentRegisterNumberFormatItemsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsInfo
  {
    public DocumentRegisterNumberFormatItemsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.DocumentRegisterNumberFormatItemsPropertiesInfo(entityType);
    }

  }

  public class DocumentRegisterNumberFormatItemsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IDocumentRegisterNumberFormatItemsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentRegisterInfo, global::Sungero.Docflow.IDocumentRegister> DocumentRegister 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentRegister");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentRegisterInfo, global::Sungero.Docflow.IDocumentRegister>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo Number 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("Number");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Separator 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Separator");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo Element 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("Element");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal DocumentRegisterNumberFormatItemsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}