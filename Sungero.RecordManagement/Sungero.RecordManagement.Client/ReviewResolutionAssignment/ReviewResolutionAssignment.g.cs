
// ==================================================================
// ReviewResolutionAssignment.g.cs
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
  public class ReviewResolutionAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IReviewResolutionAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("018e582e-5b0e-4e4f-af57-be1e0a468efa");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ReviewResolutionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewResolutionAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewResolutionAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.ReviewResolutionAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.ReviewResolutionAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewResolutionAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewResolutionAssignment.ResultItems; }
        }








      protected global::Sungero.Domain.Client.TextProperty _ResolutionText;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ResolutionText
      {
        get { return this._ResolutionText.Value; }
        set { this._ResolutionText.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewResolutionAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewResolutionAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ResolutionTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ResolutionText, this.ResolutionText, this);
     ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionTextChanged(args);
    }



  protected global::System.String ResolutionTextValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ResolutionText, value, this, this.Info.Properties.ResolutionText);
    ((global::Sungero.RecordManagement.ReviewResolutionAssignmentClientHandlers)this.Handlers).ResolutionTextValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








    public ReviewResolutionAssignment()
    {



            this._ResolutionText = new global::Sungero.Domain.Client.TextProperty("ResolutionText", this);
            this._ResolutionText.ValueChanged += (sender, e) => { this.ResolutionTextChangedHandler(); };
            this.AddProperty(this._ResolutionText);






      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentDocumentForReviewGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ReviewResolutionAssignmentPresenter.g.cs
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
  public class ReviewResolutionAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IReviewResolutionAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AddAssignmentCommand;

          public global::System.Windows.Input.ICommand AddAssignmentCommand
          {
            get
            {
              if (this._AddAssignmentCommand == null)
                  this._AddAssignmentCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("AddAssignment", this, this.AddAssignment, this.CanAddAssignment) { IsEmptyParameterAllowed = true };
              return this._AddAssignmentCommand;
            }
          }
          private global::System.Windows.Input.ICommand _CreateActionItemCommand;

          public global::System.Windows.Input.ICommand CreateActionItemCommand
          {
            get
            {
              if (this._CreateActionItemCommand == null)
                  this._CreateActionItemCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateActionItem", this, this.CreateActionItem, this.CanCreateActionItem) { IsEmptyParameterAllowed = true };
              return this._CreateActionItemCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanAddAssignment(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewResolutionAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewResolutionAssignment).ActionsHandlers).CanAddAssignment(args);
              }

              private void AddAssignment(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.AddAssignment);
                ((Sungero.RecordManagement.Client.ReviewResolutionAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewResolutionAssignment).ActionsHandlers).AddAssignment(args);
              }
              private bool CanCreateActionItem(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.ReviewResolutionAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewResolutionAssignment).ActionsHandlers).CanCreateActionItem(args);
              }

              private void CreateActionItem(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateActionItem);
                ((Sungero.RecordManagement.Client.ReviewResolutionAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewResolutionAssignment).ActionsHandlers).CreateActionItem(args);
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

    public ReviewResolutionAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ReviewResolutionAssignmentCollectionPresenter.g.cs
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
  public class ReviewResolutionAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IReviewResolutionAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ReviewResolutionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ReviewResolutionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ReviewResolutionAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ReviewResolutionAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentRepositoryImplementer.g.cs
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
  public class ReviewResolutionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewResolutionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewResolutionAssignment
    {
       public new global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ReviewResolutionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewResolutionAssignmentAccessRights.g.cs
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
  public class ReviewResolutionAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights
  {

    public ReviewResolutionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewResolutionAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights
  {

    public ReviewResolutionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReviewResolutionAssignmentBlocksInfo.g.cs
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
