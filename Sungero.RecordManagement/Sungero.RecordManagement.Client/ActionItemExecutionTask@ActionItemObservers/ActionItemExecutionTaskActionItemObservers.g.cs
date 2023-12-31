
// ==================================================================
// ActionItemExecutionTaskActionItemObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ActionItemExecutionTaskActionItemObservers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5bb73a81-d4cb-4a63-a00d-fffb8cf91956");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ActionItemExecutionTaskActionItemObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemObserversState(this);
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask> _ActionItemExecutionTask;

    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask
    {
      get { return this._ActionItemExecutionTask.Value; }
      set { this._ActionItemExecutionTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Observer;

              public virtual global::Sungero.CoreEntities.IRecipient Observer
              {
              get
              {
                return this._Observer.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Observer as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ObserverChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemObserversObserverChangedEventArgs(this.State.Properties.Observer, this.Observer, this);
     ((global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversSharedHandlers)this.SharedHandlers).ActionItemObserversObserverChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient ObserverValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.RecordManagement.Client.ActionItemExecutionTaskActionItemObserversObserverValueInputEventArgs(this.Observer, value, this, this.Info.Properties.Observer);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversClientHandlers)this.Handlers).ActionItemObserversObserverValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitObserverNavigationProperty()
              {
                this._Observer = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Observer", this);
                this._Observer.ValueChanged += (sender, e) => { this.ObserverChangedHandler(); };
                this.AddProperty(this._Observer as global::Sungero.Domain.Client.IProperty);
              }




    public ActionItemExecutionTaskActionItemObservers()
    {
      this._ActionItemExecutionTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemExecutionTask", this, true);


            this.InitObserverNavigationProperty();








    }

    #endregion

  }
}
