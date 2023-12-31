
// ==================================================================
// FreeApprovalTask.g.cs
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
  public class FreeApprovalTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.Docflow.IFreeApprovalTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("77f43035-9f23-4a19-9882-5a6a2cd5c9c7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.FreeApprovalTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalTask, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IFreeApprovalTaskState State
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalTaskState(this);
    }

    public new global::Sungero.Docflow.IFreeApprovalTaskInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalTaskInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IFreeApprovalTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _ReceiveNotice;

        public virtual global::System.Boolean? ReceiveNotice
        {
          get { return this._ReceiveNotice.Value; }
          set { this._ReceiveNotice.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _ReceiveOnCompletion;

        public virtual global::Sungero.Core.Enumeration? ReceiveOnCompletion
        {
          get { return this._ReceiveOnCompletion.Value; }
          set { this._ReceiveOnCompletion.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ReceiveOnCompletionItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.FreeApprovalTask.ReceiveOnCompletion),
          typeof(global::Sungero.Docflow.Client.FreeApprovalTask),
          "ReceiveOnCompletion");

        public static global::Sungero.Domain.Shared.EnumerationItems ReceiveOnCompletionItems
        {
          get { return global::Sungero.Docflow.Client.FreeApprovalTask._ReceiveOnCompletionItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ReceiveOnCompletionAllowedItems
        {
          get { return global::Sungero.Docflow.Client.FreeApprovalTask.ReceiveOnCompletionItems; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Docflow.IFreeApprovalTaskApprovers> _Approvers;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFreeApprovalTaskApprovers> Approvers
          {
            get { return this._Approvers.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda> _AddedAddenda;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda> AddedAddenda
          {
            get { return this._AddedAddenda.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda> _RemovedAddenda;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda> RemovedAddenda
          {
            get { return this._RemovedAddenda.Value; }
          }






    private object _ApproversActionsHandlers;

    public object ApproversActionsHandlers
    {
      get
      {
        if (this._ApproversActionsHandlers == null)
          this._ApproversActionsHandlers = this.CreateApproversActionsHandlers();
        return this._ApproversActionsHandlers;
      }
    }

    private object _ApproversCollectionActionsHandlers;

    public object ApproversCollectionActionsHandlers
    {
      get
      {
        if (this._ApproversCollectionActionsHandlers == null)
          this._ApproversCollectionActionsHandlers = this.CreateApproversCollectionActionsHandlers();
        return this._ApproversCollectionActionsHandlers;
      }
    }
    private object _AddedAddendaActionsHandlers;

    public object AddedAddendaActionsHandlers
    {
      get
      {
        if (this._AddedAddendaActionsHandlers == null)
          this._AddedAddendaActionsHandlers = this.CreateAddedAddendaActionsHandlers();
        return this._AddedAddendaActionsHandlers;
      }
    }

    private object _AddedAddendaCollectionActionsHandlers;

    public object AddedAddendaCollectionActionsHandlers
    {
      get
      {
        if (this._AddedAddendaCollectionActionsHandlers == null)
          this._AddedAddendaCollectionActionsHandlers = this.CreateAddedAddendaCollectionActionsHandlers();
        return this._AddedAddendaCollectionActionsHandlers;
      }
    }
    private object _RemovedAddendaActionsHandlers;

    public object RemovedAddendaActionsHandlers
    {
      get
      {
        if (this._RemovedAddendaActionsHandlers == null)
          this._RemovedAddendaActionsHandlers = this.CreateRemovedAddendaActionsHandlers();
        return this._RemovedAddendaActionsHandlers;
      }
    }

    private object _RemovedAddendaCollectionActionsHandlers;

    public object RemovedAddendaCollectionActionsHandlers
    {
      get
      {
        if (this._RemovedAddendaCollectionActionsHandlers == null)
          this._RemovedAddendaCollectionActionsHandlers = this.CreateRemovedAddendaCollectionActionsHandlers();
        return this._RemovedAddendaCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskAnyChildEntityCollectionActions();
    }

    protected virtual object CreateApproversActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateApproversCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateAddedAddendaActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateAddedAddendaCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateRemovedAddendaActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateRemovedAddendaCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.FreeApprovalTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ReceiveNoticeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.ReceiveNotice, this.ReceiveNotice, this);
     ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ReceiveNoticeChanged(args);
    }

    protected void ReceiveOnCompletionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ReceiveOnCompletion, this.ReceiveOnCompletion, this);
     ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ReceiveOnCompletionChanged(args);
    }

    protected void ApproversChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ApproversChanged(args);
    }

    protected void AddedAddendaChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).AddedAddendaChanged(args);
    }

    protected void RemovedAddendaChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).RemovedAddendaChanged(args);
    }




    protected virtual global::Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers CreateApproversAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers CreateApproversDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ApproversAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ApproversAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateApproversAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ApproversAdded(args);
        }
      }
    }

    protected virtual void ApproversDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskApproversSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ApproversDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateApproversDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ApproversDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers CreateAddedAddendaAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers CreateAddedAddendaDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void AddedAddendaAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("AddedAddendaAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAddedAddendaAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.AddedAddendaAdded(args);
        }
      }
    }

    protected virtual void AddedAddendaDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskAddedAddendaSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("AddedAddendaDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAddedAddendaDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.AddedAddendaDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers CreateRemovedAddendaAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers CreateRemovedAddendaDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void RemovedAddendaAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("RemovedAddendaAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateRemovedAddendaAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.RemovedAddendaAdded(args);
        }
      }
    }

    protected virtual void RemovedAddendaDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskRemovedAddendaSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("RemovedAddendaDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateRemovedAddendaDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.RemovedAddendaDeleted(args);
        }
      }
    }


  protected global::System.Boolean? ReceiveNoticeValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.ReceiveNotice, value, this, this.Info.Properties.ReceiveNotice);
    ((global::Sungero.Docflow.FreeApprovalTaskClientHandlers)this.Handlers).ReceiveNoticeValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ReceiveOnCompletionValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.ReceiveOnCompletion, value, this, this.Info.Properties.ReceiveOnCompletion);
    ((global::Sungero.Docflow.FreeApprovalTaskClientHandlers)this.Handlers).ReceiveOnCompletionValueInput(args);
    return args.NewValue;
  }





  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReceiveOnCompletionFilteringHandler()
  {
    return ((global::Sungero.Docflow.FreeApprovalTaskClientHandlers)this.Handlers).ReceiveOnCompletionFiltering(this.ReceiveOnCompletionAllowedItems);
  }





    #endregion

    #region Constructors








            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IFreeApprovalTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }

            protected virtual void InitApproversCollectionProperty()
            {
              this._Approvers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IFreeApprovalTaskApprovers>("Approvers", this);
              this._Approvers.ValueChanged += (sender, e) => { this.ApproversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Approvers);
              this.SetApproversEventHandlers();
            }

            protected void SetApproversEventHandlers()
            {
              this._Approvers.ChildEntityAdded += this.ApproversAddedHandler;
              this._Approvers.ChildEntityDeleted += this.ApproversDeletedHandler;
            }

            protected virtual void InitAddedAddendaCollectionProperty()
            {
              this._AddedAddenda = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda>("AddedAddenda", this);
              this._AddedAddenda.ValueChanged += (sender, e) => { this.AddedAddendaChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._AddedAddenda);
              this.SetAddedAddendaEventHandlers();
            }

            protected void SetAddedAddendaEventHandlers()
            {
              this._AddedAddenda.ChildEntityAdded += this.AddedAddendaAddedHandler;
              this._AddedAddenda.ChildEntityDeleted += this.AddedAddendaDeletedHandler;
            }

            protected virtual void InitRemovedAddendaCollectionProperty()
            {
              this._RemovedAddenda = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda>("RemovedAddenda", this);
              this._RemovedAddenda.ValueChanged += (sender, e) => { this.RemovedAddendaChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._RemovedAddenda);
              this.SetRemovedAddendaEventHandlers();
            }

            protected void SetRemovedAddendaEventHandlers()
            {
              this._RemovedAddenda.ChildEntityAdded += this.RemovedAddendaAddedHandler;
              this._RemovedAddenda.ChildEntityDeleted += this.RemovedAddendaDeletedHandler;
            }


    public FreeApprovalTask()
    {
            this._ReceiveNotice = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("ReceiveNotice", this);
            this._ReceiveNotice.ValueChanged += (sender, e) => { this.ReceiveNoticeChangedHandler(); };
            this.AddProperty(this._ReceiveNotice);

            this._ReceiveOnCompletion = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("ReceiveOnCompletion", this);
            this._ReceiveOnCompletion.ValueChanged += (sender, e) => { this.ReceiveOnCompletionChangedHandler(); };
            this.AddProperty(this._ReceiveOnCompletion);


            this.InitApproversCollectionProperty();

            this.InitAddedAddendaCollectionProperty();

            this.InitRemovedAddendaCollectionProperty();







      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IFreeApprovalTaskForApprovalGroupAttachments ForApprovalGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalTaskForApprovalGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalTaskAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalTaskAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalTaskOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalTaskOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ForApprovalGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ForApprovalGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).ForApprovalGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalTaskSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion

    #region Workflow blocks

    public new virtual global::Sungero.Docflow.IFreeApprovalTaskBlocksInfo Blocks
    {
      get
      {
        return new global::Sungero.Docflow.Client.FreeApprovalTaskBlocksInfo(this);
      }
    }

    #endregion

  }
}

// ==================================================================
// FreeApprovalTaskPresenter.g.cs
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
  public class FreeApprovalTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.Docflow.IFreeApprovalTask
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


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ApproversApproverCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter ApproversApproverCollectionPresenter
                          {
                  get { return this._ApproversApproverCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {
              this._ProcessKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IProcessKind>(() => this.Entity.Id, typeof(T), "ProcessKind");

              this._StartedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "StartedBy");

              this._ParentTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "ParentTask");

              this._ParentAssignmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IAssignmentBase>(() => this.Entity.Id, typeof(T), "ParentAssignment");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.CoreEntities.IUser>(() => this.Entity, typeof(T), "Author");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Docflow.IFreeApprovalTaskObservers), "Observer");

                          this._ApproversApproverCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("2509da81-8041-483e-ad8c-e4a10660533a"));
                        this._ApproversApproverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Docflow.IFreeApprovalTaskApprovers), "Approver");


    }

    public FreeApprovalTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// FreeApprovalTaskCollectionPresenter.g.cs
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
  public class FreeApprovalTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IFreeApprovalTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public FreeApprovalTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public FreeApprovalTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public FreeApprovalTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public FreeApprovalTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// FreeApprovalTaskRepositoryImplementer.g.cs
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
  public class FreeApprovalTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.Docflow.IFreeApprovalTaskRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IFreeApprovalTask
    {
       public new global::Sungero.Docflow.IFreeApprovalTaskAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IFreeApprovalTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IFreeApprovalTaskInfo Info
       {
          get { return (global::Sungero.Docflow.IFreeApprovalTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.FreeApprovalTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// FreeApprovalTaskAccessRights.g.cs
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
  public class FreeApprovalTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.Docflow.IFreeApprovalTaskAccessRights
  {

    public FreeApprovalTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class FreeApprovalTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.Docflow.IFreeApprovalTaskAccessRights
  {

    public FreeApprovalTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// FreeApprovalTaskBlocksInfo.g.cs
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
  public class FreeApprovalTaskBlocksInfo : global::Sungero.Docflow.IFreeApprovalTaskBlocksInfo
  {
    private readonly Sungero.Workflow.ITask task;

      public global::Sungero.Workflow.ITaskMonitoringBlockInfo Block10
      {
        get
        {
          return new global::Sungero.Workflow.Client.TaskMonitoringBlockInfo(this.task, "10");
        }
      }


    public void ExecuteAllMonitoringBlocks()
    {
      new global::Sungero.Workflow.Client.TaskBlocksInfo(this.task).ExecuteAllMonitoringBlocks();
    }

    public FreeApprovalTaskBlocksInfo(Sungero.Workflow.ITask task)
    {
      this.task = task;
    }
  }

}
