
// ==================================================================
// ActionItemSupervisorAssignment.g.cs
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
  public class ActionItemSupervisorAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IActionItemSupervisorAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f44faafc-cd55-4c5b-b16d-93b6fc966ffb");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemSupervisorAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IActionItemSupervisorAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemSupervisorAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IActionItemSupervisorAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemSupervisorAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _ActionItem;

        public virtual global::System.String ActionItem
        {
          get { return this._ActionItem.Value; }
          set { this._ActionItem.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ScheduledDate;

        public virtual global::System.DateTime? ScheduledDate
        {
          get { return this._ScheduledDate.Value; }
          set { this._ScheduledDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.ActionItemSupervisorAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignment.ResultItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _AssignedBy;

              public virtual global::Sungero.Company.IEmployee AssignedBy
              {
              get
              {
                return this._AssignedBy.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._AssignedBy as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ActionItemSupervisorAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemSupervisorAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ActionItemChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ActionItem, this.ActionItem, this);
     ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).ActionItemChanged(args);
    }

    protected void ScheduledDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ScheduledDate, this.ScheduledDate, this);
     ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).ScheduledDateChanged(args);
    }

    protected void AssignedByChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentAssignedByChangedEventArgs(this.State.Properties.AssignedBy, this.AssignedBy, this);
     ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).AssignedByChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }



  protected global::System.String ActionItemValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.ActionItem, value, this, this.Info.Properties.ActionItem);
    ((global::Sungero.RecordManagement.ActionItemSupervisorAssignmentClientHandlers)this.Handlers).ActionItemValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? ScheduledDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ScheduledDate, value, this, this.Info.Properties.ScheduledDate);
    ((global::Sungero.RecordManagement.ActionItemSupervisorAssignmentClientHandlers)this.Handlers).ScheduledDateValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AssignedByValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentAssignedByValueInputEventArgs(this.AssignedBy, value, this, this.Info.Properties.AssignedBy);
    ((global::Sungero.RecordManagement.ActionItemSupervisorAssignmentClientHandlers)this.Handlers).AssignedByValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.RecordManagement.ActionItemSupervisorAssignmentClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








              protected virtual void InitAssignedByNavigationProperty()
              {
                this._AssignedBy = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("AssignedBy", this);
                this._AssignedBy.ValueChanged += (sender, e) => { this.AssignedByChangedHandler(); };
                this.AddProperty(this._AssignedBy as global::Sungero.Domain.Client.IProperty);
              }




    public ActionItemSupervisorAssignment()
    {
            this._ActionItem = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("ActionItem", this);
            this._ActionItem.ValueChanged += (sender, e) => { this.ActionItemChangedHandler(); };
            this.AddProperty(this._ActionItem);

            this._ScheduledDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ScheduledDate", this);
            this._ScheduledDate.ValueChanged += (sender, e) => { this.ScheduledDateChangedHandler(); };
            this.AddProperty(this._ScheduledDate);

            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this.InitAssignedByNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IActionItemSupervisorAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IActionItemSupervisorAssignmentDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentDocumentsGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IActionItemSupervisorAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IActionItemSupervisorAssignmentResultGroupAttachments ResultGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorAssignmentResultGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResultGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).ResultGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResultGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).ResultGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResultGroup")
      {
        ((global::Sungero.RecordManagement.IActionItemSupervisorAssignmentSharedHandlers)this.SharedHandlers).ResultGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ActionItemSupervisorAssignmentPresenter.g.cs
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
  public class ActionItemSupervisorAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IActionItemSupervisorAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AgreeCommand;

          public global::System.Windows.Input.ICommand AgreeCommand
          {
            get
            {
              if (this._AgreeCommand == null)
                  this._AgreeCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Agree", this, this.Agree, this.CanAgree) { IsEmptyParameterAllowed = true };
              return this._AgreeCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForReworkCommand;

          public global::System.Windows.Input.ICommand ForReworkCommand
          {
            get
            {
              if (this._ForReworkCommand == null)
                  this._ForReworkCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("ForRework", this, this.ForRework, this.CanForRework) { IsEmptyParameterAllowed = true };
              return this._ForReworkCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForwardedCommand;

          public global::System.Windows.Input.ICommand ForwardedCommand
          {
            get
            {
              if (this._ForwardedCommand == null)
                  this._ForwardedCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Forwarded", this, this.Forwarded, this.CanForwarded) { IsEmptyParameterAllowed = true };
              return this._ForwardedCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanAgree(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).CanAgree(args);
              }

              private void Agree(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Agree);
                ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).Agree(args);
              }
              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).ForRework(args);
              }
              private bool CanForwarded(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).CanForwarded(args);
              }

              private void Forwarded(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forwarded);
                ((Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentActions)(entity as Sungero.RecordManagement.Client.ActionItemSupervisorAssignment).ActionsHandlers).Forwarded(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AssignedByCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AssignedByCollectionPresenter
              {
          get { return this._AssignedByCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._PerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Performer");

              this._TaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "Task");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

              this._CompletedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "CompletedBy");

                  this._AssignedByCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("64f522c0-b9e2-4ddd-bc32-6d493847ee9a"));
              this._AssignedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "AssignedBy");


    }

    public ActionItemSupervisorAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ActionItemSupervisorAssignmentCollectionPresenter.g.cs
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
  public class ActionItemSupervisorAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IActionItemSupervisorAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ActionItemSupervisorAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ActionItemSupervisorAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ActionItemSupervisorAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ActionItemSupervisorAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ActionItemSupervisorAssignmentRepositoryImplementer.g.cs
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
  public class ActionItemSupervisorAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IActionItemSupervisorAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IActionItemSupervisorAssignment
    {
       public new global::Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IActionItemSupervisorAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IActionItemSupervisorAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ActionItemSupervisorAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ActionItemSupervisorAssignmentAccessRights.g.cs
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
  public class ActionItemSupervisorAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights
  {

    public ActionItemSupervisorAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ActionItemSupervisorAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IActionItemSupervisorAssignmentAccessRights
  {

    public ActionItemSupervisorAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ActionItemSupervisorAssignmentBlocksInfo.g.cs
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
}
