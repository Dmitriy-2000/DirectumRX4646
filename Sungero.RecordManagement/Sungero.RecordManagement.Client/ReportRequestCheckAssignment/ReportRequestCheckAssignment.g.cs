
// ==================================================================
// ReportRequestCheckAssignment.g.cs
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
  public class ReportRequestCheckAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IReportRequestCheckAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5f794b11-e700-4fba-9021-39006a567729");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ReportRequestCheckAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReportRequestCheckAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IReportRequestCheckAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IReportRequestCheckAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReportRequestCheckAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IReportRequestCheckAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IReportRequestCheckAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.ReportRequestCheckAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.ReportRequestCheckAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.ReportRequestCheckAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.ReportRequestCheckAssignment.ResultItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReportRequestCheckAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReportRequestCheckAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReportRequestCheckAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors








    public ReportRequestCheckAssignment()
    {








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReportRequestCheckAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReportRequestCheckAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReportRequestCheckAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReportRequestCheckAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReportRequestCheckAssignmentDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReportRequestCheckAssignmentDocumentsGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IReportRequestCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ReportRequestCheckAssignmentPresenter.g.cs
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
  public class ReportRequestCheckAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IReportRequestCheckAssignment
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
                return ((Sungero.RecordManagement.Client.ReportRequestCheckAssignmentActions)(entity as Sungero.RecordManagement.Client.ReportRequestCheckAssignment).ActionsHandlers).CanAccept(args);
              }

              private void Accept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Accept);
                ((Sungero.RecordManagement.Client.ReportRequestCheckAssignmentActions)(entity as Sungero.RecordManagement.Client.ReportRequestCheckAssignment).ActionsHandlers).Accept(args);
              }
              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReportRequestCheckAssignmentActions)(entity as Sungero.RecordManagement.Client.ReportRequestCheckAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.RecordManagement.Client.ReportRequestCheckAssignmentActions)(entity as Sungero.RecordManagement.Client.ReportRequestCheckAssignment).ActionsHandlers).ForRework(args);
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

    public ReportRequestCheckAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ReportRequestCheckAssignmentCollectionPresenter.g.cs
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
  public class ReportRequestCheckAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IReportRequestCheckAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ReportRequestCheckAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ReportRequestCheckAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ReportRequestCheckAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ReportRequestCheckAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ReportRequestCheckAssignmentRepositoryImplementer.g.cs
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
  public class ReportRequestCheckAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReportRequestCheckAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReportRequestCheckAssignment
    {
       public new global::Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReportRequestCheckAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReportRequestCheckAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ReportRequestCheckAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReportRequestCheckAssignmentAccessRights.g.cs
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
  public class ReportRequestCheckAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights
  {

    public ReportRequestCheckAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReportRequestCheckAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IReportRequestCheckAssignmentAccessRights
  {

    public ReportRequestCheckAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReportRequestCheckAssignmentBlocksInfo.g.cs
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
