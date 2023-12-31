
// ==================================================================
// VerificationAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.SmartProcessing.IVerificationAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e825fc6a-c82b-4b89-a9fc-33fb181cb161");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Client.VerificationAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IVerificationAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.SmartProcessing.IVerificationAssignmentState State
    {
      get
      {
        return (global::Sungero.SmartProcessing.IVerificationAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentState(this);
    }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.SmartProcessing.IVerificationAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.SmartProcessing.VerificationAssignment.Result),
          typeof(global::Sungero.SmartProcessing.Client.VerificationAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.SmartProcessing.Client.VerificationAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.SmartProcessing.Client.VerificationAssignment.ResultItems; }
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
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.SmartProcessing.Client.VerificationAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.VerificationAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.VerificationAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.SmartProcessing.Shared.VerificationAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.SmartProcessing.IVerificationAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.SmartProcessing.IVerificationAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }



  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.SmartProcessing.Client.VerificationAssignmentAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.SmartProcessing.VerificationAssignmentClientHandlers)this.Handlers).AddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.SmartProcessing.VerificationAssignmentClientHandlers)this.Handlers).NewDeadlineValueInput(args);
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




    public VerificationAssignment()
    {
            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this.InitAddresseeNavigationProperty();








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
// VerificationAssignmentPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.SmartProcessing.IVerificationAssignment
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
          private global::System.Windows.Input.ICommand _SendForApprovalCommand;

          public global::System.Windows.Input.ICommand SendForApprovalCommand
          {
            get
            {
              if (this._SendForApprovalCommand == null)
                  this._SendForApprovalCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("SendForApproval", this, this.SendForApproval, this.CanSendForApproval) { IsEmptyParameterAllowed = true };
              return this._SendForApprovalCommand;
            }
          }
          private global::System.Windows.Input.ICommand _SendForFreeApprovalCommand;

          public global::System.Windows.Input.ICommand SendForFreeApprovalCommand
          {
            get
            {
              if (this._SendForFreeApprovalCommand == null)
                  this._SendForFreeApprovalCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("SendForFreeApproval", this, this.SendForFreeApproval, this.CanSendForFreeApproval) { IsEmptyParameterAllowed = true };
              return this._SendForFreeApprovalCommand;
            }
          }
          private global::System.Windows.Input.ICommand _SendForReviewCommand;

          public global::System.Windows.Input.ICommand SendForReviewCommand
          {
            get
            {
              if (this._SendForReviewCommand == null)
                  this._SendForReviewCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("SendForReview", this, this.SendForReview, this.CanSendForReview) { IsEmptyParameterAllowed = true };
              return this._SendForReviewCommand;
            }
          }
          private global::System.Windows.Input.ICommand _SendForExecutionCommand;

          public global::System.Windows.Input.ICommand SendForExecutionCommand
          {
            get
            {
              if (this._SendForExecutionCommand == null)
                  this._SendForExecutionCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("SendForExecution", this, this.SendForExecution, this.CanSendForExecution) { IsEmptyParameterAllowed = true };
              return this._SendForExecutionCommand;
            }
          }
          private global::System.Windows.Input.ICommand _DeleteDocumentsCommand;

          public global::System.Windows.Input.ICommand DeleteDocumentsCommand
          {
            get
            {
              if (this._DeleteDocumentsCommand == null)
                  this._DeleteDocumentsCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("DeleteDocuments", this, this.DeleteDocuments, this.CanDeleteDocuments) { IsEmptyParameterAllowed = true };
              return this._DeleteDocumentsCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ShowInvalidDocumentsCommand;

          public global::System.Windows.Input.ICommand ShowInvalidDocumentsCommand
          {
            get
            {
              if (this._ShowInvalidDocumentsCommand == null)
                  this._ShowInvalidDocumentsCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowInvalidDocuments", this, this.ShowInvalidDocuments, this.CanShowInvalidDocuments) { IsEmptyParameterAllowed = true };
              return this._ShowInvalidDocumentsCommand;
            }
          }
          private global::System.Windows.Input.ICommand _RepackingCommand;

          public global::System.Windows.Input.ICommand RepackingCommand
          {
            get
            {
              if (this._RepackingCommand == null)
                  this._RepackingCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("Repacking", this, this.Repacking, this.CanRepacking) { IsEmptyParameterAllowed = true };
              return this._RepackingCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanComplete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanComplete(args);
              }

              private void Complete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Complete);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).Complete(args);
              }
              private bool CanForward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanForward(args);
              }

              private void Forward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forward);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).Forward(args);
              }
              private bool CanSendForApproval(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanSendForApproval(args);
              }

              private void SendForApproval(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.SendForApproval);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).SendForApproval(args);
              }
              private bool CanSendForFreeApproval(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanSendForFreeApproval(args);
              }

              private void SendForFreeApproval(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.SendForFreeApproval);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).SendForFreeApproval(args);
              }
              private bool CanSendForReview(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanSendForReview(args);
              }

              private void SendForReview(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.SendForReview);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).SendForReview(args);
              }
              private bool CanSendForExecution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanSendForExecution(args);
              }

              private void SendForExecution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.SendForExecution);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).SendForExecution(args);
              }
              private bool CanDeleteDocuments(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanDeleteDocuments(args);
              }

              private void DeleteDocuments(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.DeleteDocuments);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).DeleteDocuments(args);
              }
              private bool CanShowInvalidDocuments(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanShowInvalidDocuments(args);
              }

              private void ShowInvalidDocuments(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowInvalidDocuments);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).ShowInvalidDocuments(args);
              }
              private bool CanRepacking(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).CanRepacking(args);
              }

              private void Repacking(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.Repacking);
                ((Sungero.SmartProcessing.Client.VerificationAssignmentActions)(entity as Sungero.SmartProcessing.Client.VerificationAssignment).ActionsHandlers).Repacking(args);
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

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("16e02f1b-a75f-4189-9ec2-cf2adff2d4c0"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");


    }

    public VerificationAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// VerificationAssignmentCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.SmartProcessing.IVerificationAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public VerificationAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public VerificationAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public VerificationAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public VerificationAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// VerificationAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{ 
  public class VerificationAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.SmartProcessing.IVerificationAssignmentRepositoryImplementer<T>
      where T : global::Sungero.SmartProcessing.IVerificationAssignment
    {
       public new global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.SmartProcessing.IVerificationAssignmentInfo Info
       {
          get { return (global::Sungero.SmartProcessing.IVerificationAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.SmartProcessing.Client.VerificationAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// VerificationAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.SmartProcessing.IVerificationAssignmentAccessRights
  {

    public VerificationAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class VerificationAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.SmartProcessing.IVerificationAssignmentAccessRights
  {

    public VerificationAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// VerificationAssignmentBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
}
