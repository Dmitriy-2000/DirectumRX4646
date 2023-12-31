
// ==================================================================
// ApprovalTaskAddApprovers.g.cs
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
  public class ApprovalTaskAddApprovers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalTaskAddApprovers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1b265c59-bc04-4bc0-b3d1-fd7ee58db393");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalTaskAddApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskAddApprovers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalTaskAddApproversState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalTaskAddApproversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddApproversState(this);
    }

    public new global::Sungero.Docflow.IApprovalTaskAddApproversInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalTaskAddApproversInfo)base.Info;
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




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Approver;

              public virtual global::Sungero.CoreEntities.IRecipient Approver
              {
              get
              {
                return this._Approver.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Approver as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskAddApproversClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskAddApproversSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalTaskAddApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IApprovalTaskAddApproversSharedHandlers)this.SharedHandlers).AddApproversApproverChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient ApproverValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalTaskAddApproversApproverValueInputEventArgs(this.Approver, value, this, this.Info.Properties.Approver);
    ((global::Sungero.Docflow.ApprovalTaskAddApproversClientHandlers)this.Handlers).AddApproversApproverValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitApproverNavigationProperty()
              {
                this._Approver = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Approver", this);
                this._Approver.ValueChanged += (sender, e) => { this.ApproverChangedHandler(); };
                this.AddProperty(this._Approver as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalTaskAddApprovers()
    {
      this._ApprovalTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalTask>("ApprovalTask", this, true);


            this.InitApproverNavigationProperty();








    }

    #endregion

  }
}
