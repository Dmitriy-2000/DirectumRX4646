
// ==================================================================
// ApprovalRuleBaseDepartments.g.cs
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
  public class ApprovalRuleBaseDepartments :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalRuleBaseDepartments
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8fcbbaeb-8261-489e-9c66-69ca4ccdc101");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRuleBaseDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleBaseDepartments, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalRuleBaseDepartmentsState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseDepartmentsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseDepartmentsState(this);
    }

    public new global::Sungero.Docflow.IApprovalRuleBaseDepartmentsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleBaseDepartmentsInfo)base.Info;
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




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IDepartment> _Department;

              public virtual global::Sungero.Company.IDepartment Department
              {
              get
              {
                return this._Department.Value as global::Sungero.Company.IDepartment;
              }

              set
              {
                (this._Department as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseDepartmentsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseDepartmentsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalRuleBaseDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalRuleBaseDepartmentsDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.ApprovalRuleBaseDepartmentsClientHandlers)this.Handlers).DepartmentsDepartmentValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitDepartmentNavigationProperty()
              {
                this._Department = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IDepartment>("Department", this);
                this._Department.ValueChanged += (sender, e) => { this.DepartmentChangedHandler(); };
                this.AddProperty(this._Department as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalRuleBaseDepartments()
    {
      this._ApprovalRuleBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRuleBase>("ApprovalRuleBase", this, true);


            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}
