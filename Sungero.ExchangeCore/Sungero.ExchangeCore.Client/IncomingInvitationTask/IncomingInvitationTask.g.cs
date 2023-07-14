
// ==================================================================
// IncomingInvitationTask.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class IncomingInvitationTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.ExchangeCore.IIncomingInvitationTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1e5b11de-bd28-4dc2-a03c-74b8db9ac1c4");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Client.IncomingInvitationTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IIncomingInvitationTask, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Subject; }
        set { this.Subject = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Subject"; }
      }


    public new global::Sungero.ExchangeCore.IIncomingInvitationTaskState State
    {
      get
      {
        return (global::Sungero.ExchangeCore.IIncomingInvitationTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskState(this);
    }

    public new global::Sungero.ExchangeCore.IIncomingInvitationTaskInfo Info
    {
      get
      {
        return (global::Sungero.ExchangeCore.IIncomingInvitationTaskInfo)base.Info;
      }
    }

    public new global::Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _OrganizationId;

        public virtual global::System.String OrganizationId
        {
          get { return this._OrganizationId.Value; }
          set { this._OrganizationId.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox> _Box;

              public virtual global::Sungero.ExchangeCore.IBusinessUnitBox Box
              {
              get
              {
                return this._Box.Value as global::Sungero.ExchangeCore.IBusinessUnitBox;
              }

              set
              {
                (this._Box as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.ICounterparty> _Counterparty;

              public virtual global::Sungero.Parties.ICounterparty Counterparty
              {
              get
              {
                return this._Counterparty.Value as global::Sungero.Parties.ICounterparty;
              }

              set
              {
                (this._Counterparty as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Assignee;

              public virtual global::Sungero.Company.IEmployee Assignee
              {
              get
              {
                return this._Assignee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Assignee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.IncomingInvitationTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.IncomingInvitationTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BoxChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskBoxChangedEventArgs(this.State.Properties.Box, this.Box, this);
     ((global::Sungero.ExchangeCore.IIncomingInvitationTaskSharedHandlers)this.SharedHandlers).BoxChanged(args);
    }

    protected void CounterpartyChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskCounterpartyChangedEventArgs(this.State.Properties.Counterparty, this.Counterparty, this);
     ((global::Sungero.ExchangeCore.IIncomingInvitationTaskSharedHandlers)this.SharedHandlers).CounterpartyChanged(args);
    }

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.ExchangeCore.IIncomingInvitationTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }


    protected void OrganizationIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OrganizationId, this.OrganizationId, this);
     ((global::Sungero.ExchangeCore.IIncomingInvitationTaskSharedHandlers)this.SharedHandlers).OrganizationIdChanged(args);
    }




  protected global::Sungero.ExchangeCore.IBusinessUnitBox BoxValueInputHandler(global::Sungero.ExchangeCore.IBusinessUnitBox value)
  {
    var args = new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskBoxValueInputEventArgs(this.Box, value, this, this.Info.Properties.Box);
    ((global::Sungero.ExchangeCore.IncomingInvitationTaskClientHandlers)this.Handlers).BoxValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.ICounterparty CounterpartyValueInputHandler(global::Sungero.Parties.ICounterparty value)
  {
    var args = new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskCounterpartyValueInputEventArgs(this.Counterparty, value, this, this.Info.Properties.Counterparty);
    ((global::Sungero.ExchangeCore.IncomingInvitationTaskClientHandlers)this.Handlers).CounterpartyValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AssigneeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.ExchangeCore.IncomingInvitationTaskClientHandlers)this.Handlers).AssigneeValueInput(args);
    return args.NewValue;
  }


  protected global::System.String OrganizationIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.OrganizationId, value, this, this.Info.Properties.OrganizationId);
    ((global::Sungero.ExchangeCore.IncomingInvitationTaskClientHandlers)this.Handlers).OrganizationIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors









              protected virtual void InitBoxNavigationProperty()
              {
                this._Box = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>("Box", this);
                this._Box.ValueChanged += (sender, e) => { this.BoxChangedHandler(); };
                this.AddProperty(this._Box as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitCounterpartyNavigationProperty()
              {
                this._Counterparty = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICounterparty>("Counterparty", this);
                this._Counterparty.ValueChanged += (sender, e) => { this.CounterpartyChangedHandler(); };
                this.AddProperty(this._Counterparty as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitAssigneeNavigationProperty()
              {
                this._Assignee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Assignee", this);
                this._Assignee.ValueChanged += (sender, e) => { this.AssigneeChangedHandler(); };
                this.AddProperty(this._Assignee as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.ExchangeCore.IIncomingInvitationTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }


    public IncomingInvitationTask()
    {
            this._OrganizationId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("OrganizationId", this);
            this._OrganizationId.ValueChanged += (sender, e) => { this.OrganizationIdChangedHandler(); };
            this.AddProperty(this._OrganizationId);

            this.InitBoxNavigationProperty();

            this.InitCounterpartyNavigationProperty();

            this.InitAssigneeNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments

    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
    }
    #endregion


  }
}

// ==================================================================
// IncomingInvitationTaskPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class IncomingInvitationTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.ExchangeCore.IIncomingInvitationTask
  {
    #region Fields and properties




    #endregion

    #region Methods


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _BoxCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter BoxCollectionPresenter
              {
          get { return this._BoxCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _CounterpartyCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter CounterpartyCollectionPresenter
              {
          get { return this._CounterpartyCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AssigneeCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AssigneeCollectionPresenter
              {
          get { return this._AssigneeCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._ProcessKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IProcessKind>(() => this.Entity.Id, typeof(T), "ProcessKind");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.CoreEntities.IUser>(() => this.Entity, typeof(T), "Author");

              this._StartedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "StartedBy");

              this._ParentTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "ParentTask");

              this._ParentAssignmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IAssignmentBase>(() => this.Entity.Id, typeof(T), "ParentAssignment");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

                  this._BoxCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>(global::System.Guid.Parse("ef9bb6b5-0c12-49d4-a3c0-8417d1371f1d"));
              this._BoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "Box");

                  this._CounterpartyCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.ICounterparty>(global::System.Guid.Parse("8edf8543-c604-4a50-bcf1-3c8772705504"));
              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

                  this._AssigneeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("798cba45-057e-447c-aa2d-37d6463353a7"));
              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.ExchangeCore.IIncomingInvitationTaskObservers), "Observer");



    }

    public IncomingInvitationTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// IncomingInvitationTaskCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class IncomingInvitationTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.ExchangeCore.IIncomingInvitationTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public IncomingInvitationTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public IncomingInvitationTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public IncomingInvitationTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public IncomingInvitationTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// IncomingInvitationTaskRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class IncomingInvitationTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.ExchangeCore.IIncomingInvitationTaskRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.IIncomingInvitationTask
    {
       public new global::Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.IIncomingInvitationTaskInfo Info
       {
          get { return (global::Sungero.ExchangeCore.IIncomingInvitationTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Client.IncomingInvitationTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// IncomingInvitationTaskAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class IncomingInvitationTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights
  {

    public IncomingInvitationTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class IncomingInvitationTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.ExchangeCore.IIncomingInvitationTaskAccessRights
  {

    public IncomingInvitationTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// IncomingInvitationTaskBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
}
