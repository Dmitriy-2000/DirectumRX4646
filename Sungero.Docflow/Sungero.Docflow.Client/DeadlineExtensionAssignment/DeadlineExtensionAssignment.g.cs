
// ==================================================================
// DeadlineExtensionAssignment.g.cs
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
  public class DeadlineExtensionAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.Docflow.IDeadlineExtensionAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("47f07044-beda-4949-b348-d2afa52ab4ba");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DeadlineExtensionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDeadlineExtensionAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IDeadlineExtensionAssignmentState State
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionAssignmentState(this);
    }

    public new global::Sungero.Docflow.IDeadlineExtensionAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ScheduledDate;

        public virtual global::System.DateTime? ScheduledDate
        {
          get { return this._ScheduledDate.Value; }
          set { this._ScheduledDate.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.Docflow.DeadlineExtensionAssignment.Result),
          typeof(global::Sungero.Docflow.Client.DeadlineExtensionAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.Docflow.Client.DeadlineExtensionAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.DeadlineExtensionAssignment.ResultItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.Docflow.IDeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void ScheduledDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ScheduledDate, this.ScheduledDate, this);
     ((global::Sungero.Docflow.IDeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).ScheduledDateChanged(args);
    }



  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.Docflow.DeadlineExtensionAssignmentClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? ScheduledDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ScheduledDate, value, this, this.Info.Properties.ScheduledDate);
    ((global::Sungero.Docflow.DeadlineExtensionAssignmentClientHandlers)this.Handlers).ScheduledDateValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








    public DeadlineExtensionAssignment()
    {
            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this._ScheduledDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ScheduledDate", this);
            this._ScheduledDate.ValueChanged += (sender, e) => { this.ScheduledDateChangedHandler(); };
            this.AddProperty(this._ScheduledDate);








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
// DeadlineExtensionAssignmentPresenter.g.cs
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
  public class DeadlineExtensionAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.Docflow.IDeadlineExtensionAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AcceptCommand;

          public global::System.Windows.Input.ICommand AcceptCommand
          {
            get
            {
              if (this._AcceptCommand == null)
                  this._AcceptCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Accept", this, this.Accept, this.CanAccept) { IsEmptyParameterAllowed = true };
              return this._AcceptCommand;
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




    #endregion

    #region Methods

              private bool CanAccept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.Docflow.Client.DeadlineExtensionAssignment).ActionsHandlers).CanAccept(args);
              }

              private void Accept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Accept);
                ((Sungero.Docflow.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.Docflow.Client.DeadlineExtensionAssignment).ActionsHandlers).Accept(args);
              }
              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.Docflow.Client.DeadlineExtensionAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.Docflow.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.Docflow.Client.DeadlineExtensionAssignment).ActionsHandlers).ForRework(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



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


    }

    public DeadlineExtensionAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DeadlineExtensionAssignmentCollectionPresenter.g.cs
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
  public class DeadlineExtensionAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IDeadlineExtensionAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DeadlineExtensionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DeadlineExtensionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DeadlineExtensionAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DeadlineExtensionAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentRepositoryImplementer.g.cs
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
  public class DeadlineExtensionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IDeadlineExtensionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDeadlineExtensionAssignment
    {
       public new global::Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDeadlineExtensionAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.DeadlineExtensionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineExtensionAssignmentAccessRights.g.cs
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
  public class DeadlineExtensionAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights
  {

    public DeadlineExtensionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.Docflow.IDeadlineExtensionAssignmentAccessRights
  {

    public DeadlineExtensionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentBlocksInfo.g.cs
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
