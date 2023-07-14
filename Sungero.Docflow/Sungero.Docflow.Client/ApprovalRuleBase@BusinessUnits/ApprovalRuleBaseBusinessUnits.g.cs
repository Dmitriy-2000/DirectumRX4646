
// ==================================================================
// ApprovalRuleBaseBusinessUnits.g.cs
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
  public class ApprovalRuleBaseBusinessUnits :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c52d30d2-0379-4259-8cc4-b800f9a23bc7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRuleBaseBusinessUnits.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleBaseBusinessUnits, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsState(this);
    }

    public new global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRuleBase> _ApprovalRuleBase;

    public global::Sungero.Docflow.IApprovalRuleBase ApprovalRuleBase
    {
      get { return this._ApprovalRuleBase.Value; }
      set { this._ApprovalRuleBase.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalRuleBase; }
      set { this.ApprovalRuleBase = (global::Sungero.Docflow.IApprovalRuleBase)value; }
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
      return new global::Sungero.Docflow.ApprovalRuleBaseBusinessUnitsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseBusinessUnitsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BusinessUnitChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsBusinessUnitChangedEventArgs(this.State.Properties.BusinessUnit, this.BusinessUnit, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsSharedHandlers)this.SharedHandlers).BusinessUnitsBusinessUnitChanged(args);
    }



  protected global::Sungero.Company.IBusinessUnit BusinessUnitValueInputHandler(global::Sungero.Company.IBusinessUnit value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalRuleBaseBusinessUnitsBusinessUnitValueInputEventArgs(this.BusinessUnit, value, this, this.Info.Properties.BusinessUnit);
    ((global::Sungero.Docflow.ApprovalRuleBaseBusinessUnitsClientHandlers)this.Handlers).BusinessUnitsBusinessUnitValueInput(args);
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




    public ApprovalRuleBaseBusinessUnits()
    {
      this._ApprovalRuleBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRuleBase>("ApprovalRuleBase", this, true);


            this.InitBusinessUnitNavigationProperty();








    }

    #endregion

  }
}
