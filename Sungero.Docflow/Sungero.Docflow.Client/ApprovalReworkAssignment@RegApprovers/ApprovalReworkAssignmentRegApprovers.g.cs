
// ==================================================================
// ApprovalReworkAssignmentRegApprovers.g.cs
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
  public class ApprovalReworkAssignmentRegApprovers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("d534f771-4e5b-4846-81cf-9b8fd4ad754d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentRegApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReworkAssignmentRegApprovers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentRegApproversState(this);
    }

    public new global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalReworkAssignment> _ApprovalReworkAssignment;

    public global::Sungero.Docflow.IApprovalReworkAssignment ApprovalReworkAssignment
    {
      get { return this._ApprovalReworkAssignment.Value; }
      set { this._ApprovalReworkAssignment.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalReworkAssignment; }
      set { this.ApprovalReworkAssignment = (global::Sungero.Docflow.IApprovalReworkAssignment)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Approver;

              public virtual global::Sungero.Company.IEmployee Approver
              {
              get
              {
                return this._Approver.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Approver as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentRegApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversSharedHandlers)this.SharedHandlers).RegApproversApproverChanged(args);
    }



  protected global::Sungero.Company.IEmployee ApproverValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalReworkAssignmentRegApproversApproverValueInputEventArgs(this.Approver, value, this, this.Info.Properties.Approver);
    ((global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversClientHandlers)this.Handlers).RegApproversApproverValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitApproverNavigationProperty()
              {
                this._Approver = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Approver", this);
                this._Approver.ValueChanged += (sender, e) => { this.ApproverChangedHandler(); };
                this.AddProperty(this._Approver as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalReworkAssignmentRegApprovers()
    {
      this._ApprovalReworkAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalReworkAssignment>("ApprovalReworkAssignment", this, true);


            this.InitApproverNavigationProperty();








    }

    #endregion

  }
}
