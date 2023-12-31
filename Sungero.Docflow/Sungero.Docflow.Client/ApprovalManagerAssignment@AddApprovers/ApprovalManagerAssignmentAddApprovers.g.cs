
// ==================================================================
// ApprovalManagerAssignmentAddApprovers.g.cs
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
  public class ApprovalManagerAssignmentAddApprovers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("20373d1e-fda4-4bec-869d-b9838b055f54");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalManagerAssignmentAddApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalManagerAssignmentAddApprovers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddApproversState(this);
    }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalManagerAssignment> _ApprovalManagerAssignment;

    public global::Sungero.Docflow.IApprovalManagerAssignment ApprovalManagerAssignment
    {
      get { return this._ApprovalManagerAssignment.Value; }
      set { this._ApprovalManagerAssignment.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalManagerAssignment; }
      set { this.ApprovalManagerAssignment = (global::Sungero.Docflow.IApprovalManagerAssignment)value; }
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
      return new global::Sungero.Docflow.ApprovalManagerAssignmentAddApproversClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalManagerAssignmentAddApproversSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversSharedHandlers)this.SharedHandlers).AddApproversApproverChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient ApproverValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalManagerAssignmentAddApproversApproverValueInputEventArgs(this.Approver, value, this, this.Info.Properties.Approver);
    ((global::Sungero.Docflow.ApprovalManagerAssignmentAddApproversClientHandlers)this.Handlers).AddApproversApproverValueInput(args);
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




    public ApprovalManagerAssignmentAddApprovers()
    {
      this._ApprovalManagerAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalManagerAssignment>("ApprovalManagerAssignment", this, true);


            this.InitApproverNavigationProperty();








    }

    #endregion

  }
}
