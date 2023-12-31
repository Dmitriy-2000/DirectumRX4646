
// ==================================================================
// BusinessUnitBoxFormalizedPoAInfos.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{


  public class BusinessUnitBoxFormalizedPoAInfos :
    global::Sungero.Domain.ChildEntity, global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfos
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("104002d1-f1a5-4ddc-9f4f-cdf25384c9cf");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Server.BusinessUnitBoxFormalizedPoAInfos.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfos, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosState State
    {
      get { return (global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.BusinessUnitBoxFormalizedPoAInfosState(this);
    }

    public new virtual global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosInfo Info
    {
      get { return (global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosInfo)base.Info; }
    }


    public global::Sungero.ExchangeCore.IBusinessUnitBox BusinessUnitBox { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.BusinessUnitBox; }
      set { this.BusinessUnitBox = (global::Sungero.ExchangeCore.IBusinessUnitBox)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.BusinessUnitBoxFormalizedPoAInfosSharedHandlers(this);
    }

    private global::System.String _UnifiedRegistrationNumber;
    public virtual global::System.String UnifiedRegistrationNumber
    {
      get
      {
        return this._UnifiedRegistrationNumber;
      }

      set
      {
        this.SetPropertyValue("UnifiedRegistrationNumber", this._UnifiedRegistrationNumber, value, (propertyValue) => { this._UnifiedRegistrationNumber = propertyValue; }, this.UnifiedRegistrationNumberChangedHandler);
      }
    }
    private global::System.String _Url;
    public virtual global::System.String Url
    {
      get
      {
        return this._Url;
      }

      set
      {
        this.SetPropertyValue("Url", this._Url, value, (propertyValue) => { this._Url = propertyValue; }, this.UrlChangedHandler);
      }
    }
    private global::System.String _Description;
    public virtual global::System.String Description
    {
      get
      {
        return this._Description;
      }

      set
      {
        this.SetPropertyValue("Description", this._Description, value, (propertyValue) => { this._Description = propertyValue; }, this.DescriptionChangedHandler);
      }
    }










    #region Framework events

    protected void UnifiedRegistrationNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.UnifiedRegistrationNumber, this.UnifiedRegistrationNumber, this);
     ((global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosSharedHandlers)this.SharedHandlers).FormalizedPoAInfosUnifiedRegistrationNumberChanged(args);
    }

    protected void UrlChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Url, this.Url, this);
     ((global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosSharedHandlers)this.SharedHandlers).FormalizedPoAInfosUrlChanged(args);
    }

    protected void DescriptionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Description, this.Description, this);
     ((global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfosSharedHandlers)this.SharedHandlers).FormalizedPoAInfosDescriptionChanged(args);
    }



    #endregion


    public BusinessUnitBoxFormalizedPoAInfos()
    {
    }

  }
}

// ==================================================================
// BusinessUnitBoxFormalizedPoAInfosHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{

}

// ==================================================================
// BusinessUnitBoxFormalizedPoAInfosEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
}
