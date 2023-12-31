
// ==================================================================
// AcquaintanceTaskParticipantEmployees.g.cs
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
  public class AcquaintanceTaskParticipantEmployees :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("955eb1eb-e18a-48d9-b56d-164a7366bf4c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantEmployees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployeesState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployeesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantEmployeesState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployeesInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployeesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant> _AcquaintanceTaskParticipant;

    public global::Sungero.RecordManagement.IAcquaintanceTaskParticipant AcquaintanceTaskParticipant
    {
      get { return this._AcquaintanceTaskParticipant.Value; }
      set { this._AcquaintanceTaskParticipant.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceTaskParticipant; }
      set { this.AcquaintanceTaskParticipant = (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Employee;

              public virtual global::Sungero.Company.IEmployee Employee
              {
              get
              {
                return this._Employee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Employee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void EmployeeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantEmployeesEmployeeChangedEventArgs(this.State.Properties.Employee, this.Employee, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployeesSharedHandlers)this.SharedHandlers).EmployeesEmployeeChanged(args);
    }



  protected global::Sungero.Company.IEmployee EmployeeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantEmployeesEmployeeValueInputEventArgs(this.Employee, value, this, this.Info.Properties.Employee);
    ((global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesClientHandlers)this.Handlers).EmployeesEmployeeValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitEmployeeNavigationProperty()
              {
                this._Employee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Employee", this);
                this._Employee.ValueChanged += (sender, e) => { this.EmployeeChangedHandler(); };
                this.AddProperty(this._Employee as global::Sungero.Domain.Client.IProperty);
              }




    public AcquaintanceTaskParticipantEmployees()
    {
      this._AcquaintanceTaskParticipant = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant>("AcquaintanceTaskParticipant", this, true);


            this.InitEmployeeNavigationProperty();








    }

    #endregion

  }
}
