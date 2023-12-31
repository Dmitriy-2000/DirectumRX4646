
// ==================================================================
// ApprovalReworkAssignmentApprovers.g.cs
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
  public class ApprovalReworkAssignmentApprovers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalReworkAssignmentApprovers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ad3d2bfd-0bcd-4d74-8a13-1368666d7963");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReworkAssignmentApprovers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalReworkAssignmentApproversState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReworkAssignmentApproversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentApproversState(this);
    }

    public new global::Sungero.Docflow.IApprovalReworkAssignmentApproversInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReworkAssignmentApproversInfo)base.Info;
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

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Approved;

        public virtual global::Sungero.Core.Enumeration? Approved
        {
          get { return this._Approved.Value; }
          set { this._Approved.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Action;

        public virtual global::Sungero.Core.Enumeration? Action
        {
          get { return this._Action.Value; }
          set { this._Action.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsRequiredApprover;

        public virtual global::System.Boolean? IsRequiredApprover
        {
          get { return this._IsRequiredApprover.Value; }
          set { this._IsRequiredApprover.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ApprovedItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalReworkAssignmentApprovers.Approved),
          typeof(global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers),
          "Approved");

        public static global::Sungero.Domain.Shared.EnumerationItems ApprovedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers._ApprovedItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ApprovedAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers.ApprovedItems; }
        }

        private static global::Sungero.Domain.Shared.EnumerationItems _ActionItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalReworkAssignmentApprovers.Action),
          typeof(global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers),
          "Action");

        public static global::Sungero.Domain.Shared.EnumerationItems ActionItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers._ActionItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ActionAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalReworkAssignmentApprovers.ActionItems; }
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
      return new global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversApproverChanged(args);
    }

    protected void ApprovedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Approved, this.Approved, this);
     ((global::Sungero.Docflow.IApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversApprovedChanged(args);
    }

    protected void ActionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Action, this.Action, this);
     ((global::Sungero.Docflow.IApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversActionChanged(args);
    }

    protected void IsRequiredApproverChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsRequiredApprover, this.IsRequiredApprover, this);
     ((global::Sungero.Docflow.IApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversIsRequiredApproverChanged(args);
    }



  protected global::Sungero.Company.IEmployee ApproverValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalReworkAssignmentApproversApproverValueInputEventArgs(this.Approver, value, this, this.Info.Properties.Approver);
    ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversApproverValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ApprovedValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Approved, value, this, this.Info.Properties.Approved);
    ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversApprovedValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ActionValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Action, value, this, this.Info.Properties.Action);
    ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversActionValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsRequiredApproverValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsRequiredApprover, value, this, this.Info.Properties.IsRequiredApprover);
    ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversIsRequiredApproverValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ApprovedFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversApprovedFiltering(this.ApprovedAllowedItems);
  }

  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ActionFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversClientHandlers)this.Handlers).ApproversActionFiltering(this.ActionAllowedItems);
  }



    #endregion

    #region Constructors



              protected virtual void InitApproverNavigationProperty()
              {
                this._Approver = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Approver", this);
                this._Approver.ValueChanged += (sender, e) => { this.ApproverChangedHandler(); };
                this.AddProperty(this._Approver as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalReworkAssignmentApprovers()
    {
      this._ApprovalReworkAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalReworkAssignment>("ApprovalReworkAssignment", this, true);

            this._Approved = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Approved", this);
            this._Approved.ValueChanged += (sender, e) => { this.ApprovedChangedHandler(); };
            this.AddProperty(this._Approved);

            this._Action = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Action", this);
            this._Action.ValueChanged += (sender, e) => { this.ActionChangedHandler(); };
            this.AddProperty(this._Action);

            this._IsRequiredApprover = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsRequiredApprover", this);
            this._IsRequiredApprover.ValueChanged += (sender, e) => { this.IsRequiredApproverChangedHandler(); };
            this.AddProperty(this._IsRequiredApprover);

            this.InitApproverNavigationProperty();








    }

    #endregion

  }
}
