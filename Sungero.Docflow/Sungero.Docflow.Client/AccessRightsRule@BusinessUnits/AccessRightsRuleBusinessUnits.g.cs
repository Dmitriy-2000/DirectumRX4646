
// ==================================================================
// AccessRightsRuleBusinessUnits.g.cs
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
  public class AccessRightsRuleBusinessUnits :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IAccessRightsRuleBusinessUnits
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4620e695-a132-44e6-8d01-d946f7b8775a");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.AccessRightsRuleBusinessUnits.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccessRightsRuleBusinessUnits, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IAccessRightsRuleBusinessUnitsState State
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleBusinessUnitsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsRuleBusinessUnitsState(this);
    }

    public new global::Sungero.Docflow.IAccessRightsRuleBusinessUnitsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleBusinessUnitsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule> _AccessRightsRule;

    public global::Sungero.Docflow.IAccessRightsRule AccessRightsRule
    {
      get { return this._AccessRightsRule.Value; }
      set { this._AccessRightsRule.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AccessRightsRule; }
      set { this.AccessRightsRule = (global::Sungero.Docflow.IAccessRightsRule)value; }
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
      return new global::Sungero.Docflow.AccessRightsRuleBusinessUnitsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AccessRightsRuleBusinessUnitsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BusinessUnitChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.AccessRightsRuleBusinessUnitsBusinessUnitChangedEventArgs(this.State.Properties.BusinessUnit, this.BusinessUnit, this);
     ((global::Sungero.Docflow.IAccessRightsRuleBusinessUnitsSharedHandlers)this.SharedHandlers).BusinessUnitsBusinessUnitChanged(args);
    }



  protected global::Sungero.Company.IBusinessUnit BusinessUnitValueInputHandler(global::Sungero.Company.IBusinessUnit value)
  {
    var args = new global::Sungero.Docflow.Client.AccessRightsRuleBusinessUnitsBusinessUnitValueInputEventArgs(this.BusinessUnit, value, this, this.Info.Properties.BusinessUnit);
    ((global::Sungero.Docflow.AccessRightsRuleBusinessUnitsClientHandlers)this.Handlers).BusinessUnitsBusinessUnitValueInput(args);
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




    public AccessRightsRuleBusinessUnits()
    {
      this._AccessRightsRule = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule>("AccessRightsRule", this, true);


            this.InitBusinessUnitNavigationProperty();








    }

    #endregion

  }
}
