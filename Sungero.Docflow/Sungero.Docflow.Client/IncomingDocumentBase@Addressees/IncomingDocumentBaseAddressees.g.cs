
// ==================================================================
// IncomingDocumentBaseAddressees.g.cs
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
  public class IncomingDocumentBaseAddressees :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IIncomingDocumentBaseAddressees
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("62712927-121b-4b7d-8b5f-7abaaa7c9c7d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.IncomingDocumentBaseAddressees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IIncomingDocumentBaseAddressees, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IIncomingDocumentBaseAddresseesState State
    {
      get
      {
        return (global::Sungero.Docflow.IIncomingDocumentBaseAddresseesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.IncomingDocumentBaseAddresseesState(this);
    }

    public new global::Sungero.Docflow.IIncomingDocumentBaseAddresseesInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IIncomingDocumentBaseAddresseesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IIncomingDocumentBase> _IncomingDocumentBase;

    public global::Sungero.Docflow.IIncomingDocumentBase IncomingDocumentBase
    {
      get { return this._IncomingDocumentBase.Value; }
      set { this._IncomingDocumentBase.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.IncomingDocumentBase; }
      set { this.IncomingDocumentBase = (global::Sungero.Docflow.IIncomingDocumentBase)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Number;

        public virtual global::System.Int32? Number
        {
          get { return this._Number.Value; }
          set { this._Number.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Note;

        public virtual global::System.String Note
        {
          get { return this._Note.Value; }
          set { this._Note.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Addressee;

              public virtual global::Sungero.Company.IEmployee Addressee
              {
              get
              {
                return this._Addressee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Addressee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
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
      return new global::Sungero.Docflow.IncomingDocumentBaseAddresseesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.IncomingDocumentBaseAddresseesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.Docflow.IIncomingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesNumberChanged(args);
    }

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.IncomingDocumentBaseAddresseesAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.IIncomingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesAddresseeChanged(args);
    }

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.IncomingDocumentBaseAddresseesDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.IIncomingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesDepartmentChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.IIncomingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesNoteChanged(args);
    }



  protected global::System.Int32? NumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Number, value, this, this.Info.Properties.Number);
    ((global::Sungero.Docflow.IncomingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesNumberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.IncomingDocumentBaseAddresseesAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.Docflow.IncomingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesAddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.IncomingDocumentBaseAddresseesDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.IncomingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesDepartmentValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Docflow.IncomingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesNoteValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitAddresseeNavigationProperty()
              {
                this._Addressee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Addressee", this);
                this._Addressee.ValueChanged += (sender, e) => { this.AddresseeChangedHandler(); };
                this.AddProperty(this._Addressee as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitDepartmentNavigationProperty()
              {
                this._Department = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IDepartment>("Department", this);
                this._Department.ValueChanged += (sender, e) => { this.DepartmentChangedHandler(); };
                this.AddProperty(this._Department as global::Sungero.Domain.Client.IProperty);
              }




    public IncomingDocumentBaseAddressees()
    {
      this._IncomingDocumentBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IIncomingDocumentBase>("IncomingDocumentBase", this, true);

            this._Number = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Number", this);
            this._Number.ValueChanged += (sender, e) => { this.NumberChangedHandler(); };
            this.AddProperty(this._Number);

            this._Note = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);

            this.InitAddresseeNavigationProperty();

            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}
