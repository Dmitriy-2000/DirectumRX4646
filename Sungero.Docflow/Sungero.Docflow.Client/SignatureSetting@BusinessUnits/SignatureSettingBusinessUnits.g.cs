
// ==================================================================
// SignatureSettingBusinessUnits.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class SignatureSettingBusinessUnits :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.ISignatureSettingBusinessUnits
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8de9438e-0af4-47df-8155-4b7b90c8d3d1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.SignatureSettingBusinessUnits.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISignatureSettingBusinessUnits, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.ISignatureSettingBusinessUnitsState State
    {
      get
      {
        return (global::Sungero.Docflow.ISignatureSettingBusinessUnitsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingBusinessUnitsState(this);
    }

    public new global::Sungero.Docflow.ISignatureSettingBusinessUnitsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.ISignatureSettingBusinessUnitsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.ISignatureSetting> _SignatureSetting;

    public global::Sungero.Docflow.ISignatureSetting SignatureSetting
    {
      get { return this._SignatureSetting.Value; }
      set { this._SignatureSetting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SignatureSetting; }
      set { this.SignatureSetting = (global::Sungero.Docflow.ISignatureSetting)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IBusinessUnit> _BusinessUnit;

              public virtual global::Sungero.Company.IBusinessUnit BusinessUnit
              {
              get
              {
                return this._BusinessUnit.Value as global::Sungero.Company.IBusinessUnit;
              }

              set
              {
                (this._BusinessUnit as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.SignatureSettingBusinessUnitsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SignatureSettingBusinessUnitsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BusinessUnitChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.SignatureSettingBusinessUnitsBusinessUnitChangedEventArgs(this.State.Properties.BusinessUnit, this.BusinessUnit, this);
     ((global::Sungero.Docflow.ISignatureSettingBusinessUnitsSharedHandlers)this.SharedHandlers).BusinessUnitsBusinessUnitChanged(args);
    }



  protected global::Sungero.Company.IBusinessUnit BusinessUnitValueInputHandler(global::Sungero.Company.IBusinessUnit value)
  {
    var args = new global::Sungero.Docflow.Client.SignatureSettingBusinessUnitsBusinessUnitValueInputEventArgs(this.BusinessUnit, value, this, this.Info.Properties.BusinessUnit);
    ((global::Sungero.Docflow.SignatureSettingBusinessUnitsClientHandlers)this.Handlers).BusinessUnitsBusinessUnitValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitBusinessUnitNavigationProperty()
              {
                this._BusinessUnit = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IBusinessUnit>("BusinessUnit", this);
                this._BusinessUnit.ValueChanged += (sender, e) => { this.BusinessUnitChangedHandler(); };
                this.AddProperty(this._BusinessUnit as global::Sungero.Domain.Client.IProperty);
              }




    public SignatureSettingBusinessUnits()
    {
      this._SignatureSetting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.ISignatureSetting>("SignatureSetting", this, true);


            this.InitBusinessUnitNavigationProperty();








    }

    #endregion

  }
}
