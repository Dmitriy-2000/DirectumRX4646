
// ==================================================================
// ApprovalRuleBaseStages.g.cs
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
  public class ApprovalRuleBaseStages :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalRuleBaseStages
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3314a57a-07b7-4131-bfc3-413b38507ed1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRuleBaseStages.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleBaseStages, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.StageBase == null ? string.Empty : this.StageBase.ToString(); }
        set { throw new global::System.NotSupportedException(global::CommonLibrary.Properties.Resources.SpecifiedPropertyIsNotSupportedFormat("DisplayValue")); }
      }

      public override string DisplayPropertyName
      {
        get { return "StageBase"; }
      }


    public new global::Sungero.Docflow.IApprovalRuleBaseStagesState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseStagesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseStagesState(this);
    }

    public new global::Sungero.Docflow.IApprovalRuleBaseStagesInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseStagesInfo)base.Info;
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

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Number;

        public virtual global::System.Int32? Number
        {
          get { return this._Number.Value; }
          set { this._Number.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _StageType;

        public virtual global::Sungero.Core.Enumeration? StageType
        {
          get { return this._StageType.Value; }
          set { this._StageType.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _StageTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalRuleBaseStages.StageType),
          typeof(global::Sungero.Docflow.Client.ApprovalRuleBaseStages),
          "StageType");

        public static global::Sungero.Domain.Shared.EnumerationItems StageTypeItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalRuleBaseStages._StageTypeItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems StageTypeAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalRuleBaseStages.StageTypeItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IApprovalStage> _Stage;

              public virtual global::Sungero.Docflow.IApprovalStage Stage
              {
              get
              {
                return this._Stage.Value as global::Sungero.Docflow.IApprovalStage;
              }

              set
              {
                (this._Stage as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IApprovalStageBase> _StageBase;

              public virtual global::Sungero.Docflow.IApprovalStageBase StageBase
              {
              get
              {
                return this._StageBase.Value as global::Sungero.Docflow.IApprovalStageBase;
              }

              set
              {
                (this._StageBase as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseStagesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void StageChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalRuleBaseStagesStageChangedEventArgs(this.State.Properties.Stage, this.Stage, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseStagesSharedHandlers)this.SharedHandlers).StagesStageChanged(args);
    }

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseStagesSharedHandlers)this.SharedHandlers).StagesNumberChanged(args);
    }

    protected void StageTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.StageType, this.StageType, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseStagesSharedHandlers)this.SharedHandlers).StagesStageTypeChanged(args);
    }

    protected void StageBaseChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalRuleBaseStagesStageBaseChangedEventArgs(this.State.Properties.StageBase, this.StageBase, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseStagesSharedHandlers)this.SharedHandlers).StagesStageBaseChanged(args);
    }



  protected global::Sungero.Docflow.IApprovalStage StageValueInputHandler(global::Sungero.Docflow.IApprovalStage value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalRuleBaseStagesStageValueInputEventArgs(this.Stage, value, this, this.Info.Properties.Stage);
    ((global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers)this.Handlers).StagesStageValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? NumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Number, value, this, this.Info.Properties.Number);
    ((global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers)this.Handlers).StagesNumberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? StageTypeValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.StageType, value, this, this.Info.Properties.StageType);
    ((global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers)this.Handlers).StagesStageTypeValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Docflow.IApprovalStageBase StageBaseValueInputHandler(global::Sungero.Docflow.IApprovalStageBase value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalRuleBaseStagesStageBaseValueInputEventArgs(this.StageBase, value, this, this.Info.Properties.StageBase);
    ((global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers)this.Handlers).StagesStageBaseValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> StageTypeFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalRuleBaseStagesClientHandlers)this.Handlers).StagesStageTypeFiltering(this.StageTypeAllowedItems);
  }



    #endregion

    #region Constructors



              protected virtual void InitStageNavigationProperty()
              {
                this._Stage = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage>("Stage", this);
                this._Stage.ValueChanged += (sender, e) => { this.StageChangedHandler(); };
                this.AddProperty(this._Stage as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitStageBaseNavigationProperty()
              {
                this._StageBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStageBase>("StageBase", this);
                this._StageBase.ValueChanged += (sender, e) => { this.StageBaseChangedHandler(); };
                this.AddProperty(this._StageBase as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalRuleBaseStages()
    {
      this._ApprovalRuleBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRuleBase>("ApprovalRuleBase", this, true);

            this._Number = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Number", this);
            this._Number.ValueChanged += (sender, e) => { this.NumberChangedHandler(); };
            this.AddProperty(this._Number);

            this._StageType = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("StageType", this);
            this._StageType.ValueChanged += (sender, e) => { this.StageTypeChangedHandler(); };
            this.AddProperty(this._StageType);

            this.InitStageNavigationProperty();

            this.InitStageBaseNavigationProperty();








    }

    #endregion

  }
}
