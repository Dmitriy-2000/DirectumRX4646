
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

namespace Sungero.RecordManagement.Client
{
  public class DeadlineExtensionTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.RecordManagement.IDeadlineExtensionTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.DeadlineExtensionTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDeadlineExtensionTask, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskState(this);
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskAccessRights(this);
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



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionAssignment> _ActionItemExecutionAssignment;

              public virtual global::Sungero.RecordManagement.IActionItemExecutionAssignment ActionItemExecutionAssignment
              {
              get
              {
                return this._ActionItemExecutionAssignment.Value as global::Sungero.RecordManagement.IActionItemExecutionAssignment;
              }

              set
              {
                (this._ActionItemExecutionAssignment as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }








      protected global::Sungero.Domain.Client.TextProperty _RejectionReason;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String RejectionReason
      {
        get { return this._RejectionReason.Value; }
        set { this._RejectionReason.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _ActionItem;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ActionItem
      {
        get { return this._ActionItem.Value; }
        set { this._ActionItem.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _PrimaryReason;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String PrimaryReason
      {
        get { return this._PrimaryReason.Value; }
        set { this._PrimaryReason.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _Reason;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Reason
      {
        get { return this._Reason.Value; }
        set { this._Reason.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void CurrentDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.CurrentDeadline, this.CurrentDeadline, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).CurrentDeadlineChanged(args);
    }

    protected void RejectionReasonChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.RejectionReason, this.RejectionReason, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).RejectionReasonChanged(args);
    }

    protected void ActionItemChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ActionItem, this.ActionItem, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).ActionItemChanged(args);
    }

    protected void PrimaryReasonChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.PrimaryReason, this.PrimaryReason, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).PrimaryReasonChanged(args);
    }

    protected void ReasonChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Reason, this.Reason, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).ReasonChanged(args);
    }

    protected void ActionItemExecutionAssignmentChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskActionItemExecutionAssignmentChangedEventArgs(this.State.Properties.ActionItemExecutionAssignment, this.ActionItemExecutionAssignment, this);
     ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).ActionItemExecutionAssignmentChanged(args);
    }




  protected global::Sungero.CoreEntities.IUser AssigneeValueInputHandler(global::Sungero.CoreEntities.IUser value)
  {
    var args = new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).AssigneeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? CurrentDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.CurrentDeadline, value, this, this.Info.Properties.CurrentDeadline);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).CurrentDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.String RejectionReasonValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.RejectionReason, value, this, this.Info.Properties.RejectionReason);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).RejectionReasonValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ActionItemValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ActionItem, value, this, this.Info.Properties.ActionItem);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).ActionItemValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PrimaryReasonValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.PrimaryReason, value, this, this.Info.Properties.PrimaryReason);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).PrimaryReasonValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ReasonValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Reason, value, this, this.Info.Properties.Reason);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).ReasonValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.RecordManagement.IActionItemExecutionAssignment ActionItemExecutionAssignmentValueInputHandler(global::Sungero.RecordManagement.IActionItemExecutionAssignment value)
  {
    var args = new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskActionItemExecutionAssignmentValueInputEventArgs(this.ActionItemExecutionAssignment, value, this, this.Info.Properties.ActionItemExecutionAssignment);
    ((global::Sungero.RecordManagement.DeadlineExtensionTaskClientHandlers)this.Handlers).ActionItemExecutionAssignmentValueInput(args);
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




              protected virtual void InitActionItemExecutionAssignmentNavigationProperty()
              {
                this._ActionItemExecutionAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionAssignment>("ActionItemExecutionAssignment", this);
                this._ActionItemExecutionAssignment.ValueChanged += (sender, e) => { this.ActionItemExecutionAssignmentChangedHandler(); };
                this.AddProperty(this._ActionItemExecutionAssignment as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers>("Observers", this);
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

            this.InitActionItemExecutionAssignmentNavigationProperty();



            this._RejectionReason = new global::Sungero.Domain.Client.TextProperty("RejectionReason", this);
            this._RejectionReason.ValueChanged += (sender, e) => { this.RejectionReasonChangedHandler(); };
            this.AddProperty(this._RejectionReason);

            this._ActionItem = new global::Sungero.Domain.Client.TextProperty("ActionItem", this);
            this._ActionItem.ValueChanged += (sender, e) => { this.ActionItemChangedHandler(); };
            this.AddProperty(this._ActionItem);

            this._PrimaryReason = new global::Sungero.Domain.Client.TextProperty("PrimaryReason", this);
            this._PrimaryReason.ValueChanged += (sender, e) => { this.PrimaryReasonChangedHandler(); };
            this.AddProperty(this._PrimaryReason);

            this._Reason = new global::Sungero.Domain.Client.TextProperty("Reason", this);
            this._Reason.ValueChanged += (sender, e) => { this.ReasonChangedHandler(); };
            this.AddProperty(this._Reason);






      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionTaskDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskDocumentsGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionTaskAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionTaskOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

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

namespace Sungero.RecordManagement.Client
{
  public class DeadlineExtensionTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.RecordManagement.IDeadlineExtensionTask
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
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ActionItemExecutionAssignmentCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter ActionItemExecutionAssignmentCollectionPresenter
              {
          get { return this._ActionItemExecutionAssignmentCollectionPresenter; }
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

                  this._AssigneeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IUser>(global::System.Guid.Parse("514381b7-2f4a-4d7f-b9f9-ea1d2ac3ece7"));
              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Assignee");

                  this._ActionItemExecutionAssignmentCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionAssignment>(global::System.Guid.Parse("8972b2a4-55ec-4ee2-8b87-c6a77330e37d"));
              this._ActionItemExecutionAssignmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.RecordManagement.IActionItemExecutionAssignment>(() => this.Entity.Id, typeof(T), "ActionItemExecutionAssignment");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IDeadlineExtensionTaskObservers), "Observer");



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

namespace Sungero.RecordManagement.Client
{
  public class DeadlineExtensionTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IDeadlineExtensionTask
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

namespace Sungero.RecordManagement.Client
{ 
  public class DeadlineExtensionTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDeadlineExtensionTaskRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDeadlineExtensionTask
    {
       public new global::Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo Info
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.DeadlineExtensionTaskTypeAccessRights(typeof(T));
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

namespace Sungero.RecordManagement.Client
{
  public class DeadlineExtensionTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights
  {

    public DeadlineExtensionTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.RecordManagement.IDeadlineExtensionTaskAccessRights
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

namespace Sungero.RecordManagement.Client
{
}
