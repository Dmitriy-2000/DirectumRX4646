
// ==================================================================
// StampSettingBusinessUnits.g.cs
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
  public class StampSettingBusinessUnits :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IStampSettingBusinessUnits
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("2a84998a-677d-4528-984b-1903e45d9424");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.StampSettingBusinessUnits.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IStampSettingBusinessUnits, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IStampSettingBusinessUnitsState State
    {
      get
      {
        return (global::Sungero.Docflow.IStampSettingBusinessUnitsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.StampSettingBusinessUnitsState(this);
    }

    public new global::Sungero.Docflow.IStampSettingBusinessUnitsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IStampSettingBusinessUnitsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IStampSetting> _StampSetting;

    public global::Sungero.Docflow.IStampSetting StampSetting
    {
      get { return this._StampSetting.Value; }
      set { this._StampSetting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.StampSetting; }
      set { this.StampSetting = (global::Sungero.Docflow.IStampSetting)value; }
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
      return new global::Sungero.Docflow.StampSettingBusinessUnitsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.StampSettingBusinessUnitsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BusinessUnitChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.StampSettingBusinessUnitsBusinessUnitChangedEventArgs(this.State.Properties.BusinessUnit, this.BusinessUnit, this);
     ((global::Sungero.Docflow.IStampSettingBusinessUnitsSharedHandlers)this.SharedHandlers).BusinessUnitsBusinessUnitChanged(args);
    }



  protected global::Sungero.Company.IBusinessUnit BusinessUnitValueInputHandler(global::Sungero.Company.IBusinessUnit value)
  {
    var args = new global::Sungero.Docflow.Client.StampSettingBusinessUnitsBusinessUnitValueInputEventArgs(this.BusinessUnit, value, this, this.Info.Properties.BusinessUnit);
    ((global::Sungero.Docflow.StampSettingBusinessUnitsClientHandlers)this.Handlers).BusinessUnitsBusinessUnitValueInput(args);
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




    public StampSettingBusinessUnits()
    {
      this._StampSetting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IStampSetting>("StampSetting", this, true);


            this.InitBusinessUnitNavigationProperty();








    }

    #endregion

  }
}
