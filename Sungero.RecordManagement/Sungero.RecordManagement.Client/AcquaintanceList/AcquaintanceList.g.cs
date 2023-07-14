
// ==================================================================
// AcquaintanceList.g.cs
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
  public class AcquaintanceList :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.RecordManagement.IAcquaintanceList
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("763e5d49-c131-4acc-9faf-b11371fe910b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceList.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceList, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IAcquaintanceListState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceListState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceListState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceListInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceListInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceListAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceListAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.RecordManagement.IAcquaintanceListParticipants> _Participants;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceListParticipants> Participants
          {
            get { return this._Participants.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants> _ExcludedParticipants;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants> ExcludedParticipants
          {
            get { return this._ExcludedParticipants.Value; }
          }




      protected global::Sungero.Domain.Client.TextProperty _Note;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Note
      {
        get { return this._Note.Value; }
        set { this._Note.Value = value; }
      }



    private object _ParticipantsActionsHandlers;

    public object ParticipantsActionsHandlers
    {
      get
      {
        if (this._ParticipantsActionsHandlers == null)
          this._ParticipantsActionsHandlers = this.CreateParticipantsActionsHandlers();
        return this._ParticipantsActionsHandlers;
      }
    }

    private object _ParticipantsCollectionActionsHandlers;

    public object ParticipantsCollectionActionsHandlers
    {
      get
      {
        if (this._ParticipantsCollectionActionsHandlers == null)
          this._ParticipantsCollectionActionsHandlers = this.CreateParticipantsCollectionActionsHandlers();
        return this._ParticipantsCollectionActionsHandlers;
      }
    }
    private object _ExcludedParticipantsActionsHandlers;

    public object ExcludedParticipantsActionsHandlers
    {
      get
      {
        if (this._ExcludedParticipantsActionsHandlers == null)
          this._ExcludedParticipantsActionsHandlers = this.CreateExcludedParticipantsActionsHandlers();
        return this._ExcludedParticipantsActionsHandlers;
      }
    }

    private object _ExcludedParticipantsCollectionActionsHandlers;

    public object ExcludedParticipantsCollectionActionsHandlers
    {
      get
      {
        if (this._ExcludedParticipantsCollectionActionsHandlers == null)
          this._ExcludedParticipantsCollectionActionsHandlers = this.CreateExcludedParticipantsCollectionActionsHandlers();
        return this._ExcludedParticipantsCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListAnyChildEntityCollectionActions();
    }

    protected virtual object CreateParticipantsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateParticipantsCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateExcludedParticipantsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateExcludedParticipantsCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceListFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceListFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceListClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceListSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.RecordManagement.IAcquaintanceListSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.RecordManagement.IAcquaintanceListSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void ParticipantsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.RecordManagement.IAcquaintanceListSharedHandlers)this.SharedHandlers).ParticipantsChanged(args);
    }

    protected void ExcludedParticipantsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.RecordManagement.IAcquaintanceListSharedHandlers)this.SharedHandlers).ExcludedParticipantsChanged(args);
    }



    protected virtual global::Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers CreateParticipantsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers CreateParticipantsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ParticipantsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ParticipantsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateParticipantsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ParticipantsAdded(args);
        }
      }
    }

    protected virtual void ParticipantsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceListParticipantsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ParticipantsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateParticipantsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ParticipantsDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers CreateExcludedParticipantsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers CreateExcludedParticipantsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ExcludedParticipantsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ExcludedParticipantsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateExcludedParticipantsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ExcludedParticipantsAdded(args);
        }
      }
    }

    protected virtual void ExcludedParticipantsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ExcludedParticipantsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateExcludedParticipantsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ExcludedParticipantsDeleted(args);
        }
      }
    }


  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.RecordManagement.AcquaintanceListClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.RecordManagement.AcquaintanceListClientHandlers)this.Handlers).NoteValueInput(args);
    return args.NewValue;
  }





    #endregion

    #region Constructors


            protected virtual void InitParticipantsCollectionProperty()
            {
              this._Participants = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IAcquaintanceListParticipants>("Participants", this);
              this._Participants.ValueChanged += (sender, e) => { this.ParticipantsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Participants);
              this.SetParticipantsEventHandlers();
            }

            protected void SetParticipantsEventHandlers()
            {
              this._Participants.ChildEntityAdded += this.ParticipantsAddedHandler;
              this._Participants.ChildEntityDeleted += this.ParticipantsDeletedHandler;
            }

            protected virtual void InitExcludedParticipantsCollectionProperty()
            {
              this._ExcludedParticipants = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants>("ExcludedParticipants", this);
              this._ExcludedParticipants.ValueChanged += (sender, e) => { this.ExcludedParticipantsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ExcludedParticipants);
              this.SetExcludedParticipantsEventHandlers();
            }

            protected void SetExcludedParticipantsEventHandlers()
            {
              this._ExcludedParticipants.ChildEntityAdded += this.ExcludedParticipantsAddedHandler;
              this._ExcludedParticipants.ChildEntityDeleted += this.ExcludedParticipantsDeletedHandler;
            }


    public AcquaintanceList()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);


            this.InitParticipantsCollectionProperty();

            this.InitExcludedParticipantsCollectionProperty();


            this._Note = new global::Sungero.Domain.Client.TextProperty("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);






    }

    #endregion

  }
}

// ==================================================================
// AcquaintanceListPresenter.g.cs
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
  public class AcquaintanceListPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.RecordManagement.IAcquaintanceList
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


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ParticipantsParticipantCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter ParticipantsParticipantCollectionPresenter
                          {
                  get { return this._ParticipantsParticipantCollectionPresenter; }
                }

                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ExcludedParticipantsExcludedParticipantCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter ExcludedParticipantsExcludedParticipantCollectionPresenter
                          {
                  get { return this._ExcludedParticipantsExcludedParticipantCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {

                          this._ParticipantsParticipantCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("bdb3dab8-a476-4f8e-b938-e72849edc04b"));
                        this._ParticipantsParticipantCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IAcquaintanceListParticipants), "Participant");

                          this._ExcludedParticipantsExcludedParticipantCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("45836617-3d7c-4b48-954e-8b8860e250b6"));
                        this._ExcludedParticipantsExcludedParticipantCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IAcquaintanceListExcludedParticipants), "ExcludedParticipant");


    }

    public AcquaintanceListPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// AcquaintanceListCollectionPresenter.g.cs
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
  public class AcquaintanceListCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IAcquaintanceList
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public AcquaintanceListCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public AcquaintanceListCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public AcquaintanceListCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public AcquaintanceListCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// AcquaintanceListRepositoryImplementer.g.cs
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
  public class AcquaintanceListRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.RecordManagement.IAcquaintanceListRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IAcquaintanceList
    {
       public new global::Sungero.RecordManagement.IAcquaintanceListAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceListAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IAcquaintanceListInfo Info
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceListInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.AcquaintanceListTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AcquaintanceListAccessRights.g.cs
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
  public class AcquaintanceListAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.RecordManagement.IAcquaintanceListAccessRights
  {

    public AcquaintanceListAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AcquaintanceListTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IAcquaintanceListAccessRights
  {

    public AcquaintanceListTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
