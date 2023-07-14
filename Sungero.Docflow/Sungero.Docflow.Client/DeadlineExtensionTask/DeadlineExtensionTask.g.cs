
// ==================================================================
// DeadlineExtensionTask.g.cs
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
  public class DeadlineExtensionTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.Docflow.IDeadlineExtensionTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ef92411f-9fd6-4009-8e8f-92c8a2419a0c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DeadlineExtensionTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDeadlineExtensionTask, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IDeadlineExtensionTaskState State
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionTaskState(this);
    }

    public new global::Sungero.Docflow.IDeadlineExtensionTaskInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionTaskInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _CurrentDeadline;

        public virtual global::System.DateTime? CurrentDeadline
        {
          get { return this._CurrentDeadline.Value; }
          set { this._CurrentDeadline.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IUser> _Assignee;

              public virtual global::Sungero.CoreEntities.IUser Assignee
              {
              get
              {
                return this._Assignee.Value as global::Sungero.CoreEntities.IUser;
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
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DeadlineExtensionTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void CurrentDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.CurrentDeadline, this.CurrentDeadline, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).CurrentDeadlineChanged(args);
    }




  protected global::Sungero.CoreEntities.IUser AssigneeValueInputHandler(global::Sungero.CoreEntities.IUser value)
  {
    var args = new global::Sungero.Docflow.Client.DeadlineExtensionTaskAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.Docflow.DeadlineExtensionTaskClientHandlers)this.Handlers).AssigneeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.Docflow.DeadlineExtensionTaskClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? CurrentDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.CurrentDeadline, value, this, this.Info.Properties.CurrentDeadline);
    ((global::Sungero.Docflow.DeadlineExtensionTaskClientHandlers)this.Handlers).CurrentDeadlineValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors









              protected virtual void InitAssigneeNavigationProperty()
              {
                this._Assignee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IUser>("Assignee", this);
                this._Assignee.ValueChanged += (sender, e) => { this.AssigneeChangedHandler(); };
                this.AddProperty(this._Assignee as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IDeadlineExtensionTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }


    public DeadlineExtensionTask()
    {
            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this._CurrentDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("CurrentDeadline", this);
            this._CurrentDeadline.ValueChanged += (sender, e) => { this.CurrentDeadlineChangedHandler(); };
            this.AddProperty(this._CurrentDeadline);

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
// DeadlineExtensionTaskPresenter.g.cs
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
  public class DeadlineExtensionTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.Docflow.IDeadlineExtensionTask
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

                  this._AssigneeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IUser>(global::System.Guid.Parse("bedf4b91-f78e-4f7e-8ab8-4032339f2d2e"));
              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.CoreEntities.IUser>(() => this.Entity, typeof(T), "Assignee");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Docflow.IDeadlineExtensionTaskObservers), "Observer");



    }

    public DeadlineExtensionTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DeadlineExtensionTaskCollectionPresenter.g.cs
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
  public class DeadlineExtensionTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IDeadlineExtensionTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DeadlineExtensionTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DeadlineExtensionTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DeadlineExtensionTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DeadlineExtensionTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskRepositoryImplementer.g.cs
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
  public class DeadlineExtensionTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.Docflow.IDeadlineExtensionTaskRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDeadlineExtensionTask
    {
       public new global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDeadlineExtensionTaskInfo Info
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.DeadlineExtensionTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineExtensionTaskAccessRights.g.cs
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
  public class DeadlineExtensionTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.Docflow.IDeadlineExtensionTaskAccessRights
  {

    public DeadlineExtensionTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.Docflow.IDeadlineExtensionTaskAccessRights
  {

    public DeadlineExtensionTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DeadlineExtensionTaskBlocksInfo.g.cs
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
}
