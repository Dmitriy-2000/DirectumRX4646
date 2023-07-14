
// ==================================================================
// ActionItemExecutionTaskAddedAddenda.g.cs
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
  public class ActionItemExecutionTaskAddedAddenda :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddenda
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1ff589b3-bdb9-4900-a1db-0790693052ba");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ActionItemExecutionTaskAddedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskAddedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskAddedAddendaState(this);
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaInfo)base.Info;
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

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _AddendumId;

        public virtual global::System.Int32? AddendumId
        {
          get { return this._AddendumId.Value; }
          set { this._AddendumId.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskAddedAddendaClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskAddedAddendaSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaSharedHandlers)this.SharedHandlers).AddedAddendaAddendumIdChanged(args);
    }



  protected global::System.Int32? AddendumIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.AddendumId, value, this, this.Info.Properties.AddendumId);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskAddedAddendaClientHandlers)this.Handlers).AddedAddendaAddendumIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public ActionItemExecutionTaskAddedAddenda()
    {
      this._ActionItemExecutionTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemExecutionTask", this, true);

            this._AddendumId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("AddendumId", this);
            this._AddendumId.ValueChanged += (sender, e) => { this.AddendumIdChangedHandler(); };
            this.AddProperty(this._AddendumId);








    }

    #endregion

  }
}