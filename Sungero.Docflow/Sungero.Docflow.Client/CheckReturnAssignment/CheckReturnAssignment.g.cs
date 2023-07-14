
// ==================================================================
// CheckReturnAssignment.g.cs
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
  public class CheckReturnAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.Docflow.ICheckReturnAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c9cff422-0936-4dd4-906d-a2fd487e5c2f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.CheckReturnAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICheckReturnAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.ICheckReturnAssignmentState State
    {
      get
      {
        return (global::Sungero.Docflow.ICheckReturnAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentState(this);
    }

    public new global::Sungero.Docflow.ICheckReturnAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.ICheckReturnAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.ICheckReturnAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.ICheckReturnAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.Docflow.CheckReturnAssignment.Result),
          typeof(global::Sungero.Docflow.Client.CheckReturnAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.Docflow.Client.CheckReturnAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.CheckReturnAssignment.ResultItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.CheckReturnAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.CheckReturnAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.CheckReturnAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors








    public CheckReturnAssignment()
    {








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.Docflow.ICheckReturnAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.CheckReturnAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// CheckReturnAssignmentPresenter.g.cs
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
  public class CheckReturnAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.Docflow.ICheckReturnAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _CompleteCommand;

          public global::System.Windows.Input.ICommand CompleteCommand
          {
            get
            {
              if (this._CompleteCommand == null)
                  this._CompleteCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Complete", this, this.Complete, this.CanComplete) { IsEmptyParameterAllowed = true };
              return this._CompleteCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ExtendDeadlineCommand;

          public global::System.Windows.Input.ICommand ExtendDeadlineCommand
          {
            get
            {
              if (this._ExtendDeadlineCommand == null)
                  this._ExtendDeadlineCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ExtendDeadline", this, this.ExtendDeadline, this.CanExtendDeadline) { IsEmptyParameterAllowed = true };
              return this._ExtendDeadlineCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanComplete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.CheckReturnAssignmentActions)(entity as Sungero.Docflow.Client.CheckReturnAssignment).ActionsHandlers).CanComplete(args);
              }

              private void Complete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Complete);
                ((Sungero.Docflow.Client.CheckReturnAssignmentActions)(entity as Sungero.Docflow.Client.CheckReturnAssignment).ActionsHandlers).Complete(args);
              }
              private bool CanExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.CheckReturnAssignmentActions)(entity as Sungero.Docflow.Client.CheckReturnAssignment).ActionsHandlers).CanExtendDeadline(args);
              }

              private void ExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ExtendDeadline);
                ((Sungero.Docflow.Client.CheckReturnAssignmentActions)(entity as Sungero.Docflow.Client.CheckReturnAssignment).ActionsHandlers).ExtendDeadline(args);
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

    public CheckReturnAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// CheckReturnAssignmentCollectionPresenter.g.cs
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
  public class CheckReturnAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.ICheckReturnAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public CheckReturnAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public CheckReturnAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public CheckReturnAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public CheckReturnAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// CheckReturnAssignmentRepositoryImplementer.g.cs
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
  public class CheckReturnAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.ICheckReturnAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ICheckReturnAssignment
    {
       public new global::Sungero.Docflow.ICheckReturnAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.ICheckReturnAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.ICheckReturnAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.ICheckReturnAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.CheckReturnAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CheckReturnAssignmentAccessRights.g.cs
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
  public class CheckReturnAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.Docflow.ICheckReturnAssignmentAccessRights
  {

    public CheckReturnAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CheckReturnAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.Docflow.ICheckReturnAssignmentAccessRights
  {

    public CheckReturnAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CheckReturnAssignmentBlocksInfo.g.cs
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
