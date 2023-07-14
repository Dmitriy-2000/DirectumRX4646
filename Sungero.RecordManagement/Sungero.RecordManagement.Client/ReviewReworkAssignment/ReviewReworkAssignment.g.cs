
// ==================================================================
// ReviewReworkAssignment.g.cs
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
  public class ReviewReworkAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IReviewReworkAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1d5433e5-b285-4310-9a63-fc4e76f0a9b7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ReviewReworkAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewReworkAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IReviewReworkAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewReworkAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewReworkAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewReworkAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.ReviewReworkAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.ReviewReworkAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewReworkAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewReworkAssignment.ResultItems; }
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










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewReworkAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewReworkAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }



  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.RecordManagement.ReviewReworkAssignmentClientHandlers)this.Handlers).AddresseeValueInput(args);
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




    public ReviewReworkAssignment()
    {

            this.InitAddresseeNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewReworkAssignmentDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentDocumentForReviewGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewReworkAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewReworkAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewReworkAssignmentResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentResolutionGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewReworkAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ReviewReworkAssignmentPresenter.g.cs
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
  public class ReviewReworkAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IReviewReworkAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _SendForReviewCommand;

          public global::System.Windows.Input.ICommand SendForReviewCommand
          {
            get
            {
              if (this._SendForReviewCommand == null)
                  this._SendForReviewCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("SendForReview", this, this.SendForReview, this.CanSendForReview) { IsEmptyParameterAllowed = true };
              return this._SendForReviewCommand;
            }
          }
          private global::System.Windows.Input.ICommand _AbortCommand;

          public global::System.Windows.Input.ICommand AbortCommand
          {
            get
            {
              if (this._AbortCommand == null)
                  this._AbortCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("Abort", this, this.Abort, this.CanAbort) { IsEmptyParameterAllowed = true };
              return this._AbortCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForwardCommand;

          public global::System.Windows.Input.ICommand ForwardCommand
          {
            get
            {
              if (this._ForwardCommand == null)
                  this._ForwardCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Forward", this, this.Forward, this.CanForward) { IsEmptyParameterAllowed = true };
              return this._ForwardCommand;
            }
          }
          private global::System.Windows.Input.ICommand _AddResolutionCommand;

          public global::System.Windows.Input.ICommand AddResolutionCommand
          {
            get
            {
              if (this._AddResolutionCommand == null)
                  this._AddResolutionCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("AddResolution", this, this.AddResolution, this.CanAddResolution) { IsEmptyParameterAllowed = true };
              return this._AddResolutionCommand;
            }
          }
          private global::System.Windows.Input.ICommand _PrintResolutionCommand;

          public global::System.Windows.Input.ICommand PrintResolutionCommand
          {
            get
            {
              if (this._PrintResolutionCommand == null)
                  this._PrintResolutionCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("PrintResolution", this, this.PrintResolution, this.CanPrintResolution) { IsEmptyParameterAllowed = true };
              return this._PrintResolutionCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanSendForReview(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).CanSendForReview(args);
              }

              private void SendForReview(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.SendForReview);
                ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).SendForReview(args);
              }
              private bool CanAbort(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).CanAbort(args);
              }

              private void Abort(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.Abort);
                ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).Abort(args);
              }
              private bool CanForward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).CanForward(args);
              }

              private void Forward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forward);
                ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).Forward(args);
              }
              private bool CanAddResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).CanAddResolution(args);
              }

              private void AddResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.AddResolution);
                ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).AddResolution(args);
              }
              private bool CanPrintResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).CanPrintResolution(args);
              }

              private void PrintResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.PrintResolution);
                ((Sungero.RecordManagement.Client.ReviewReworkAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewReworkAssignment).ActionsHandlers).PrintResolution(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AddresseeCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AddresseeCollectionPresenter
              {
          get { return this._AddresseeCollectionPresenter; }
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

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("bf28a13d-ac71-466d-be4a-979acd1e4c14"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");


    }

    public ReviewReworkAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ReviewReworkAssignmentCollectionPresenter.g.cs
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
  public class ReviewReworkAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IReviewReworkAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ReviewReworkAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ReviewReworkAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ReviewReworkAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ReviewReworkAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ReviewReworkAssignmentRepositoryImplementer.g.cs
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
  public class ReviewReworkAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewReworkAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewReworkAssignment
    {
       public new global::Sungero.RecordManagement.IReviewReworkAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewReworkAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ReviewReworkAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewReworkAssignmentAccessRights.g.cs
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
  public class ReviewReworkAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IReviewReworkAssignmentAccessRights
  {

    public ReviewReworkAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewReworkAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IReviewReworkAssignmentAccessRights
  {

    public ReviewReworkAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReviewReworkAssignmentBlocksInfo.g.cs
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
