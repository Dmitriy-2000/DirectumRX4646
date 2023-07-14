
// ==================================================================
// JobTitle.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class JobTitle :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Company.IJobTitle
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4a37aec4-764c-4c14-8887-e1ecafa5b4c5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Client.JobTitle.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IJobTitle, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Company.IJobTitleState State
    {
      get
      {
        return (global::Sungero.Company.IJobTitleState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.JobTitleState(this);
    }

    public new global::Sungero.Company.IJobTitleInfo Info
    {
      get
      {
        return (global::Sungero.Company.IJobTitleInfo)base.Info;
      }
    }

    public new global::Sungero.Company.IJobTitleAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Company.IJobTitleAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Company.Client.JobTitleAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
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

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Company.Client.JobTitleActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Company.Client.JobTitleCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Company.Client.JobTitleAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Company.Client.JobTitleAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Company.Client.JobTitleFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Company.Shared.JobTitleFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Company.JobTitleClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.JobTitleSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Company.IJobTitleSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Company.Shared.JobTitleDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Company.IJobTitleSharedHandlers)this.SharedHandlers).DepartmentChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Company.JobTitleClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Company.Client.JobTitleDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Company.JobTitleClientHandlers)this.Handlers).DepartmentValueInput(args);
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




    public JobTitle()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// JobTitlePresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class JobTitlePresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Company.IJobTitle
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _ShowDuplicatesCommand;

          public global::System.Windows.Input.ICommand ShowDuplicatesCommand
          {
            get
            {
              if (this._ShowDuplicatesCommand == null)
                  this._ShowDuplicatesCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowDuplicates", this, this.ShowDuplicates, this.CanShowDuplicates) { IsEmptyParameterAllowed = true };
              return this._ShowDuplicatesCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ShowEmployeesWithSameJobTitleCommand;

          public global::System.Windows.Input.ICommand ShowEmployeesWithSameJobTitleCommand
          {
            get
            {
              if (this._ShowEmployeesWithSameJobTitleCommand == null)
                  this._ShowEmployeesWithSameJobTitleCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowEmployeesWithSameJobTitle", this, this.ShowEmployeesWithSameJobTitle, this.CanShowEmployeesWithSameJobTitle) { IsEmptyParameterAllowed = true };
              return this._ShowEmployeesWithSameJobTitleCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Company.Client.JobTitleActions)(entity as Sungero.Company.Client.JobTitle).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.Company.Client.JobTitleActions)(entity as Sungero.Company.Client.JobTitle).ActionsHandlers).ShowDuplicates(args);
              }
              private bool CanShowEmployeesWithSameJobTitle(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Company.Client.JobTitleActions)(entity as Sungero.Company.Client.JobTitle).ActionsHandlers).CanShowEmployeesWithSameJobTitle(args);
              }

              private void ShowEmployeesWithSameJobTitle(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowEmployeesWithSameJobTitle);
                ((Sungero.Company.Client.JobTitleActions)(entity as Sungero.Company.Client.JobTitle).ActionsHandlers).ShowEmployeesWithSameJobTitle(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _DepartmentCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter DepartmentCollectionPresenter
              {
          get { return this._DepartmentCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
                  this._DepartmentCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IDepartment>(global::System.Guid.Parse("eb9e1c0d-5925-4e40-8c21-f2095307ad68"));
              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");


    }

    public JobTitlePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// JobTitleCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class JobTitleCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Company.IJobTitle
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public JobTitleCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public JobTitleCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public JobTitleCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public JobTitleCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// JobTitleRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{ 
  public class JobTitleRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.Company.IJobTitleRepositoryImplementer<T>
      where T : global::Sungero.Company.IJobTitle
    {
       public new global::Sungero.Company.IJobTitleAccessRights AccessRights
       {
          get { return (global::Sungero.Company.IJobTitleAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Company.IJobTitleInfo Info
       {
          get { return (global::Sungero.Company.IJobTitleInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Company.Client.JobTitleTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// JobTitleAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class JobTitleAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Company.IJobTitleAccessRights
  {

    public JobTitleAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class JobTitleTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Company.IJobTitleAccessRights
  {

    public JobTitleTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
