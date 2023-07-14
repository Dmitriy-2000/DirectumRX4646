
// ==================================================================
// ApprovalTaskAddedAddenda.g.cs
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
  public class ApprovalTaskAddedAddenda :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalTaskAddedAddenda
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("93e77aaa-e991-47a9-a81f-2e749875b1f7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalTaskAddedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskAddedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalTaskAddedAddendaState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalTaskAddedAddendaState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddedAddendaState(this);
    }

    public new global::Sungero.Docflow.IApprovalTaskAddedAddendaInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalTaskAddedAddendaInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalTask> _ApprovalTask;

    public global::Sungero.Docflow.IApprovalTask ApprovalTask
    {
      get { return this._ApprovalTask.Value; }
      set { this._ApprovalTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalTask; }
      set { this.ApprovalTask = (global::Sungero.Docflow.IApprovalTask)value; }
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
      return new global::Sungero.Docflow.ApprovalTaskAddedAddendaClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskAddedAddendaSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.Docflow.IApprovalTaskAddedAddendaSharedHandlers)this.SharedHandlers).AddedAddendaAddendumIdChanged(args);
    }



  protected global::System.Int32? AddendumIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.AddendumId, value, this, this.Info.Properties.AddendumId);
    ((global::Sungero.Docflow.ApprovalTaskAddedAddendaClientHandlers)this.Handlers).AddedAddendaAddendumIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public ApprovalTaskAddedAddenda()
    {
      this._ApprovalTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalTask>("ApprovalTask", this, true);

            this._AddendumId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("AddendumId", this);
            this._AddendumId.ValueChanged += (sender, e) => { this.AddendumIdChangedHandler(); };
            this.AddProperty(this._AddendumId);








    }

    #endregion

  }
}