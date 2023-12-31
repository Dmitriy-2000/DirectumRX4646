
// ==================================================================
// AccessRightsRuleDocumentKinds.g.cs
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
  public class AccessRightsRuleDocumentKinds :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IAccessRightsRuleDocumentKinds
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("81f24b4f-47ee-455e-bd98-80aa839c3f12");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.AccessRightsRuleDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccessRightsRuleDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IAccessRightsRuleDocumentKindsState State
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleDocumentKindsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsRuleDocumentKindsState(this);
    }

    public new global::Sungero.Docflow.IAccessRightsRuleDocumentKindsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleDocumentKindsInfo)base.Info;
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




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IDocumentKind> _DocumentKind;

              public virtual global::Sungero.Docflow.IDocumentKind DocumentKind
              {
              get
              {
                return this._DocumentKind.Value as global::Sungero.Docflow.IDocumentKind;
              }

              set
              {
                (this._DocumentKind as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.AccessRightsRuleDocumentKindsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AccessRightsRuleDocumentKindsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DocumentKindChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.AccessRightsRuleDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.IAccessRightsRuleDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



  protected global::Sungero.Docflow.IDocumentKind DocumentKindValueInputHandler(global::Sungero.Docflow.IDocumentKind value)
  {
    var args = new global::Sungero.Docflow.Client.AccessRightsRuleDocumentKindsDocumentKindValueInputEventArgs(this.DocumentKind, value, this, this.Info.Properties.DocumentKind);
    ((global::Sungero.Docflow.AccessRightsRuleDocumentKindsClientHandlers)this.Handlers).DocumentKindsDocumentKindValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitDocumentKindNavigationProperty()
              {
                this._DocumentKind = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentKind>("DocumentKind", this);
                this._DocumentKind.ValueChanged += (sender, e) => { this.DocumentKindChangedHandler(); };
                this.AddProperty(this._DocumentKind as global::Sungero.Domain.Client.IProperty);
              }




    public AccessRightsRuleDocumentKinds()
    {
      this._AccessRightsRule = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule>("AccessRightsRule", this, true);


            this.InitDocumentKindNavigationProperty();








    }

    #endregion

  }
}
