
// ==================================================================
// SmartProcessingSettingProcessingRules.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{


  public class SmartProcessingSettingProcessingRules :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.ISmartProcessingSettingProcessingRules
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ccdb4976-9dbb-455d-80b7-61047f3c4e5c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.SmartProcessingSettingProcessingRules.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISmartProcessingSettingProcessingRules, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesState State
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingProcessingRulesState(this);
    }

    public new virtual global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesInfo Info
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesInfo)base.Info; }
    }


    public global::Sungero.Docflow.ISmartProcessingSetting SmartProcessingSetting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SmartProcessingSetting; }
      set { this.SmartProcessingSetting = (global::Sungero.Docflow.ISmartProcessingSetting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SmartProcessingSettingProcessingRulesSharedHandlers(this);
    }

    private global::System.String _ClassName;
    public virtual global::System.String ClassName
    {
      get
      {
        return this._ClassName;
      }

      set
      {
        this.SetPropertyValue("ClassName", this._ClassName, value, (propertyValue) => { this._ClassName = propertyValue; }, this.ClassNameChangedHandler);
      }
    }
    private global::System.String _GrammarName;
    public virtual global::System.String GrammarName
    {
      get
      {
        return this._GrammarName;
      }

      set
      {
        this.SetPropertyValue("GrammarName", this._GrammarName, value, (propertyValue) => { this._GrammarName = propertyValue; }, this.GrammarNameChangedHandler);
      }
    }
    private global::System.String _FunctionName;
    public virtual global::System.String FunctionName
    {
      get
      {
        return this._FunctionName;
      }

      set
      {
        this.SetPropertyValue("FunctionName", this._FunctionName, value, (propertyValue) => { this._FunctionName = propertyValue; }, this.FunctionNameChangedHandler);
      }
    }
    private global::System.String _ModuleName;
    public virtual global::System.String ModuleName
    {
      get
      {
        return this._ModuleName;
      }

      set
      {
        this.SetPropertyValue("ModuleName", this._ModuleName, value, (propertyValue) => { this._ModuleName = propertyValue; }, this.ModuleNameChangedHandler);
      }
    }










    #region Framework events

    protected void ClassNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ClassName, this.ClassName, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesSharedHandlers)this.SharedHandlers).ProcessingRulesClassNameChanged(args);
    }

    protected void GrammarNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.GrammarName, this.GrammarName, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesSharedHandlers)this.SharedHandlers).ProcessingRulesGrammarNameChanged(args);
    }

    protected void FunctionNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FunctionName, this.FunctionName, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesSharedHandlers)this.SharedHandlers).ProcessingRulesFunctionNameChanged(args);
    }

    protected void ModuleNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ModuleName, this.ModuleName, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingProcessingRulesSharedHandlers)this.SharedHandlers).ProcessingRulesModuleNameChanged(args);
    }



    #endregion


    public SmartProcessingSettingProcessingRules()
    {
    }

  }
}

// ==================================================================
// SmartProcessingSettingProcessingRulesHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

}

// ==================================================================
// SmartProcessingSettingProcessingRulesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}
