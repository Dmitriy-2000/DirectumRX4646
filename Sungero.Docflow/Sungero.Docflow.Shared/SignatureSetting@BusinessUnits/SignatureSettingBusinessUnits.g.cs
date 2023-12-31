
// ==================================================================
// SignatureSettingBusinessUnitsState.g.cs
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
  public class SignatureSettingBusinessUnitsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.ISignatureSettingBusinessUnitsState
  {
    public SignatureSettingBusinessUnitsState(global::Sungero.Docflow.ISignatureSettingBusinessUnits entity) : base(entity) { }

    public new global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingBusinessUnitsPropertyStates(entity);
    }


  }


  public class SignatureSettingBusinessUnitsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
            {
              get { return this.InternalSignatureSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> InternalSignatureSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ISignatureSetting>("SignatureSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IBusinessUnit> BusinessUnit 
            {
              get { return this.InternalBusinessUnit; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IBusinessUnit> InternalBusinessUnit
            {
              get { return this.GetPropertyState<global::Sungero.Company.IBusinessUnit>("BusinessUnit"); }
            }


    protected internal SignatureSettingBusinessUnitsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SignatureSettingBusinessUnitsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.ISignatureSettingBusinessUnitsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ISignatureSettingBusinessUnits
  {
    public new global::Sungero.Docflow.ISignatureSettingBusinessUnitsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingBusinessUnitsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingBusinessUnitsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SignatureSettingBusinessUnitsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SignatureSettingBusinessUnitsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.ISignatureSettingBusinessUnitsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SignatureSetting
        {
          get { return this.GetChildPropertySummaryState("SignatureSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState BusinessUnit
        {
          get { return this.GetChildPropertySummaryState("BusinessUnit"); }
        }


    protected internal SignatureSettingBusinessUnitsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SignatureSettingBusinessUnitsInfo.g.cs
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
  public class SignatureSettingBusinessUnitsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.ISignatureSettingBusinessUnitsInfo
  {
    public SignatureSettingBusinessUnitsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingBusinessUnitsPropertiesInfo(entityType);
    }

  }

  public class SignatureSettingBusinessUnitsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.ISignatureSettingBusinessUnitsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("SignatureSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IBusinessUnitInfo, global::Sungero.Company.IBusinessUnit> BusinessUnit 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("BusinessUnit");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IBusinessUnitInfo, global::Sungero.Company.IBusinessUnit>(propertyMetadata);
          }
        }


    protected internal SignatureSettingBusinessUnitsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
