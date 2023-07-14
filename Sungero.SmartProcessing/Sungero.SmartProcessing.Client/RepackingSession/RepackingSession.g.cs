
// ==================================================================
// RepackingSession.g.cs
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
  public class RepackingSession :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.SmartProcessing.IRepackingSession
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3724e760-a28a-42ec-a91a-217df42c3665");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Client.RepackingSession.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IRepackingSession, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.SmartProcessing.IRepackingSessionState State
    {
      get
      {
        return (global::Sungero.SmartProcessing.IRepackingSessionState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionState(this);
    }

    public new global::Sungero.SmartProcessing.IRepackingSessionInfo Info
    {
      get
      {
        return (global::Sungero.SmartProcessing.IRepackingSessionInfo)base.Info;
      }
    }

    public new global::Sungero.SmartProcessing.IRepackingSessionAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.SmartProcessing.IRepackingSessionAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _SessionId;

        public virtual global::System.String SessionId
        {
          get { return this._SessionId.Value; }
          set { this._SessionId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _AssignmentId;

        public virtual global::System.Int32? AssignmentId
        {
          get { return this._AssignmentId.Value; }
          set { this._AssignmentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _CloseDate;

        public virtual global::System.DateTime? CloseDate
        {
          get { return this._CloseDate.Value; }
          set { this._CloseDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _ResultsApplied;

        public virtual global::System.Boolean? ResultsApplied
        {
          get { return this._ResultsApplied.Value; }
          set { this._ResultsApplied.Value = value; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments> _OriginalDocuments;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments> OriginalDocuments
          {
            get { return this._OriginalDocuments.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments> _NewDocuments;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments> NewDocuments
          {
            get { return this._NewDocuments.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.SmartProcessing.IRepackingSessionErrors> _Errors;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.SmartProcessing.IRepackingSessionErrors> Errors
          {
            get { return this._Errors.Value; }
          }






    private object _OriginalDocumentsActionsHandlers;

    public object OriginalDocumentsActionsHandlers
    {
      get
      {
        if (this._OriginalDocumentsActionsHandlers == null)
          this._OriginalDocumentsActionsHandlers = this.CreateOriginalDocumentsActionsHandlers();
        return this._OriginalDocumentsActionsHandlers;
      }
    }

    private object _OriginalDocumentsCollectionActionsHandlers;

    public object OriginalDocumentsCollectionActionsHandlers
    {
      get
      {
        if (this._OriginalDocumentsCollectionActionsHandlers == null)
          this._OriginalDocumentsCollectionActionsHandlers = this.CreateOriginalDocumentsCollectionActionsHandlers();
        return this._OriginalDocumentsCollectionActionsHandlers;
      }
    }
    private object _NewDocumentsActionsHandlers;

    public object NewDocumentsActionsHandlers
    {
      get
      {
        if (this._NewDocumentsActionsHandlers == null)
          this._NewDocumentsActionsHandlers = this.CreateNewDocumentsActionsHandlers();
        return this._NewDocumentsActionsHandlers;
      }
    }

    private object _NewDocumentsCollectionActionsHandlers;

    public object NewDocumentsCollectionActionsHandlers
    {
      get
      {
        if (this._NewDocumentsCollectionActionsHandlers == null)
          this._NewDocumentsCollectionActionsHandlers = this.CreateNewDocumentsCollectionActionsHandlers();
        return this._NewDocumentsCollectionActionsHandlers;
      }
    }
    private object _ErrorsActionsHandlers;

    public object ErrorsActionsHandlers
    {
      get
      {
        if (this._ErrorsActionsHandlers == null)
          this._ErrorsActionsHandlers = this.CreateErrorsActionsHandlers();
        return this._ErrorsActionsHandlers;
      }
    }

    private object _ErrorsCollectionActionsHandlers;

    public object ErrorsCollectionActionsHandlers
    {
      get
      {
        if (this._ErrorsCollectionActionsHandlers == null)
          this._ErrorsCollectionActionsHandlers = this.CreateErrorsCollectionActionsHandlers();
        return this._ErrorsCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionAnyChildEntityCollectionActions();
    }

    protected virtual object CreateOriginalDocumentsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateOriginalDocumentsCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateNewDocumentsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateNewDocumentsCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateErrorsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateErrorsCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.SmartProcessing.Client.RepackingSessionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.RepackingSessionClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.RepackingSessionSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void SessionIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SessionId, this.SessionId, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).SessionIdChanged(args);
    }

    protected void AssignmentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.AssignmentId, this.AssignmentId, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).AssignmentIdChanged(args);
    }

    protected void OriginalDocumentsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).OriginalDocumentsChanged(args);
    }

    protected void NewDocumentsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).NewDocumentsChanged(args);
    }

    protected void ErrorsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).ErrorsChanged(args);
    }

    protected void CloseDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.CloseDate, this.CloseDate, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).CloseDateChanged(args);
    }

    protected void ResultsAppliedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.ResultsApplied, this.ResultsApplied, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionSharedHandlers)this.SharedHandlers).ResultsAppliedChanged(args);
    }



    protected virtual global::Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers CreateOriginalDocumentsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers CreateOriginalDocumentsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void OriginalDocumentsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("OriginalDocumentsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateOriginalDocumentsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.OriginalDocumentsAdded(args);
        }
      }
    }

    protected virtual void OriginalDocumentsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionOriginalDocumentsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("OriginalDocumentsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateOriginalDocumentsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.OriginalDocumentsDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers CreateNewDocumentsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers CreateNewDocumentsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void NewDocumentsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("NewDocumentsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateNewDocumentsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.NewDocumentsAdded(args);
        }
      }
    }

    protected virtual void NewDocumentsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("NewDocumentsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateNewDocumentsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.NewDocumentsDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers CreateErrorsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers CreateErrorsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ErrorsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ErrorsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateErrorsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ErrorsAdded(args);
        }
      }
    }

    protected virtual void ErrorsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.RepackingSessionErrorsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ErrorsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateErrorsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ErrorsDeleted(args);
        }
      }
    }


  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.SmartProcessing.RepackingSessionClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String SessionIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.SessionId, value, this, this.Info.Properties.SessionId);
    ((global::Sungero.SmartProcessing.RepackingSessionClientHandlers)this.Handlers).SessionIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? AssignmentIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.AssignmentId, value, this, this.Info.Properties.AssignmentId);
    ((global::Sungero.SmartProcessing.RepackingSessionClientHandlers)this.Handlers).AssignmentIdValueInput(args);
    return args.NewValue;
  }




  protected global::System.DateTime? CloseDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.CloseDate, value, this, this.Info.Properties.CloseDate);
    ((global::Sungero.SmartProcessing.RepackingSessionClientHandlers)this.Handlers).CloseDateValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? ResultsAppliedValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.ResultsApplied, value, this, this.Info.Properties.ResultsApplied);
    ((global::Sungero.SmartProcessing.RepackingSessionClientHandlers)this.Handlers).ResultsAppliedValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors


            protected virtual void InitOriginalDocumentsCollectionProperty()
            {
              this._OriginalDocuments = new global::Sungero.Domain.Client.ListProperty<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments>("OriginalDocuments", this);
              this._OriginalDocuments.ValueChanged += (sender, e) => { this.OriginalDocumentsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._OriginalDocuments);
              this.SetOriginalDocumentsEventHandlers();
            }

            protected void SetOriginalDocumentsEventHandlers()
            {
              this._OriginalDocuments.ChildEntityAdded += this.OriginalDocumentsAddedHandler;
              this._OriginalDocuments.ChildEntityDeleted += this.OriginalDocumentsDeletedHandler;
            }

            protected virtual void InitNewDocumentsCollectionProperty()
            {
              this._NewDocuments = new global::Sungero.Domain.Client.ListProperty<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments>("NewDocuments", this);
              this._NewDocuments.ValueChanged += (sender, e) => { this.NewDocumentsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._NewDocuments);
              this.SetNewDocumentsEventHandlers();
            }

            protected void SetNewDocumentsEventHandlers()
            {
              this._NewDocuments.ChildEntityAdded += this.NewDocumentsAddedHandler;
              this._NewDocuments.ChildEntityDeleted += this.NewDocumentsDeletedHandler;
            }

            protected virtual void InitErrorsCollectionProperty()
            {
              this._Errors = new global::Sungero.Domain.Client.ListProperty<global::Sungero.SmartProcessing.IRepackingSessionErrors>("Errors", this);
              this._Errors.ValueChanged += (sender, e) => { this.ErrorsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Errors);
              this.SetErrorsEventHandlers();
            }

            protected void SetErrorsEventHandlers()
            {
              this._Errors.ChildEntityAdded += this.ErrorsAddedHandler;
              this._Errors.ChildEntityDeleted += this.ErrorsDeletedHandler;
            }


    public RepackingSession()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._SessionId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("SessionId", this);
            this._SessionId.ValueChanged += (sender, e) => { this.SessionIdChangedHandler(); };
            this.AddProperty(this._SessionId);

            this._AssignmentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("AssignmentId", this);
            this._AssignmentId.ValueChanged += (sender, e) => { this.AssignmentIdChangedHandler(); };
            this.AddProperty(this._AssignmentId);

            this._CloseDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("CloseDate", this);
            this._CloseDate.ValueChanged += (sender, e) => { this.CloseDateChangedHandler(); };
            this.AddProperty(this._CloseDate);

            this._ResultsApplied = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("ResultsApplied", this);
            this._ResultsApplied.ValueChanged += (sender, e) => { this.ResultsAppliedChangedHandler(); };
            this.AddProperty(this._ResultsApplied);


            this.InitOriginalDocumentsCollectionProperty();

            this.InitNewDocumentsCollectionProperty();

            this.InitErrorsCollectionProperty();







    }

    #endregion

  }
}

// ==================================================================
// RepackingSessionPresenter.g.cs
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
  public class RepackingSessionPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.SmartProcessing.IRepackingSession
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



    #region Constructors

    private void Init()
    {

    }

    public RepackingSessionPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// RepackingSessionCollectionPresenter.g.cs
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
  public class RepackingSessionCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.SmartProcessing.IRepackingSession
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public RepackingSessionCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public RepackingSessionCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public RepackingSessionCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public RepackingSessionCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// RepackingSessionRepositoryImplementer.g.cs
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
  public class RepackingSessionRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.SmartProcessing.IRepackingSessionRepositoryImplementer<T>
      where T : global::Sungero.SmartProcessing.IRepackingSession
    {
       public new global::Sungero.SmartProcessing.IRepackingSessionAccessRights AccessRights
       {
          get { return (global::Sungero.SmartProcessing.IRepackingSessionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.SmartProcessing.IRepackingSessionInfo Info
       {
          get { return (global::Sungero.SmartProcessing.IRepackingSessionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.SmartProcessing.Client.RepackingSessionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// RepackingSessionAccessRights.g.cs
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
  public class RepackingSessionAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.SmartProcessing.IRepackingSessionAccessRights
  {

    public RepackingSessionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class RepackingSessionTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.SmartProcessing.IRepackingSessionAccessRights
  {

    public RepackingSessionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
