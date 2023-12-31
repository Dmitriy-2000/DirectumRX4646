
// ==================================================================
// BusinessUnitBoxExchangeServiceCertificatesState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class BusinessUnitBoxExchangeServiceCertificatesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesState
  {
    public BusinessUnitBoxExchangeServiceCertificatesState(global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificates entity) : base(entity) { }

    public new global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.BusinessUnitBoxExchangeServiceCertificatesPropertyStates(entity);
    }


  }


  public class BusinessUnitBoxExchangeServiceCertificatesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> BusinessUnitBox 
            {
              get { return this.InternalBusinessUnitBox; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> InternalBusinessUnitBox
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox>("BusinessUnitBox"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.ICertificate> Certificate 
            {
              get { return this.InternalCertificate; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.ICertificate> InternalCertificate
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.ICertificate>("Certificate"); }
            }


    protected internal BusinessUnitBoxExchangeServiceCertificatesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class BusinessUnitBoxExchangeServiceCertificatesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesCollectionPropertyState<T>
    where T : global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificates
  {
    public new global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.ExchangeCore.Shared.BusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal BusinessUnitBoxExchangeServiceCertificatesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class BusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState BusinessUnitBox
        {
          get { return this.GetChildPropertySummaryState("BusinessUnitBox"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Certificate
        {
          get { return this.GetChildPropertySummaryState("Certificate"); }
        }


    protected internal BusinessUnitBoxExchangeServiceCertificatesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// BusinessUnitBoxExchangeServiceCertificatesInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class BusinessUnitBoxExchangeServiceCertificatesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesInfo
  {
    public BusinessUnitBoxExchangeServiceCertificatesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertiesInfo Properties
    {
      get { return (global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.BusinessUnitBoxExchangeServiceCertificatesPropertiesInfo(entityType);
    }

  }

  public class BusinessUnitBoxExchangeServiceCertificatesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificatesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox> BusinessUnitBox 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("BusinessUnitBox");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.ICertificateInfo, global::Sungero.CoreEntities.ICertificate> Certificate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Certificate");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.ICertificateInfo, global::Sungero.CoreEntities.ICertificate>(propertyMetadata);
          }
        }


    protected internal BusinessUnitBoxExchangeServiceCertificatesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
