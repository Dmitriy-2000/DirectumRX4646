
// ==================================================================
// VisibilityRule.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilityRule :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Company.IVisibilityRule
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("023eab79-c456-46bb-97b5-fbc764be9308");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Client.VisibilityRule.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IVisibilityRule, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Company.IVisibilityRuleState State
    {
      get
      {
        return (global::Sungero.Company.IVisibilityRuleState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleState(this);
    }

    public new global::Sungero.Company.IVisibilityRuleInfo Info
    {
      get
      {
        return (global::Sungero.Company.IVisibilityRuleInfo)base.Info;
      }
    }

    public new global::Sungero.Company.IVisibilityRuleAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Company.IVisibilityRuleAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Company.Client.VisibilityRuleAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Note;

        public virtual global::System.String Note
        {
          get { return this._Note.Value; }
          set { this._Note.Value = value; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Company.IVisibilityRuleRecipients> _Recipients;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Company.IVisibilityRuleRecipients> Recipients
          {
            get { return this._Recipients.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Company.IVisibilityRuleVisibleMembers> _VisibleMembers;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Company.IVisibilityRuleVisibleMembers> VisibleMembers
          {
            get { return this._VisibleMembers.Value; }
          }


          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Company.IVisibilityRuleExcludedMembers> _ExcludedMembers;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Company.IVisibilityRuleExcludedMembers> ExcludedMembers
          {
            get { return this._ExcludedMembers.Value; }
          }






    private object _RecipientsActionsHandlers;

    public object RecipientsActionsHandlers
    {
      get
      {
        if (this._RecipientsActionsHandlers == null)
          this._RecipientsActionsHandlers = this.CreateRecipientsActionsHandlers();
        return this._RecipientsActionsHandlers;
      }
    }

    private object _RecipientsCollectionActionsHandlers;

    public object RecipientsCollectionActionsHandlers
    {
      get
      {
        if (this._RecipientsCollectionActionsHandlers == null)
          this._RecipientsCollectionActionsHandlers = this.CreateRecipientsCollectionActionsHandlers();
        return this._RecipientsCollectionActionsHandlers;
      }
    }
    private object _VisibleMembersActionsHandlers;

    public object VisibleMembersActionsHandlers
    {
      get
      {
        if (this._VisibleMembersActionsHandlers == null)
          this._VisibleMembersActionsHandlers = this.CreateVisibleMembersActionsHandlers();
        return this._VisibleMembersActionsHandlers;
      }
    }

    private object _VisibleMembersCollectionActionsHandlers;

    public object VisibleMembersCollectionActionsHandlers
    {
      get
      {
        if (this._VisibleMembersCollectionActionsHandlers == null)
          this._VisibleMembersCollectionActionsHandlers = this.CreateVisibleMembersCollectionActionsHandlers();
        return this._VisibleMembersCollectionActionsHandlers;
      }
    }
    private object _ExcludedMembersActionsHandlers;

    public object ExcludedMembersActionsHandlers
    {
      get
      {
        if (this._ExcludedMembersActionsHandlers == null)
          this._ExcludedMembersActionsHandlers = this.CreateExcludedMembersActionsHandlers();
        return this._ExcludedMembersActionsHandlers;
      }
    }

    private object _ExcludedMembersCollectionActionsHandlers;

    public object ExcludedMembersCollectionActionsHandlers
    {
      get
      {
        if (this._ExcludedMembersCollectionActionsHandlers == null)
          this._ExcludedMembersCollectionActionsHandlers = this.CreateExcludedMembersCollectionActionsHandlers();
        return this._ExcludedMembersCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Company.Client.VisibilityRuleActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Company.Client.VisibilityRuleCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Company.Client.VisibilityRuleAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Company.Client.VisibilityRuleAnyChildEntityCollectionActions();
    }

    protected virtual object CreateRecipientsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateRecipientsCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateVisibleMembersActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateVisibleMembersCollectionActionsHandlers()
    {
      return null;
    }
    protected virtual object CreateExcludedMembersActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateExcludedMembersCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Company.Client.VisibilityRuleFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Company.VisibilityRuleClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.VisibilityRuleSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Company.IVisibilityRuleSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void RecipientsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Company.IVisibilityRuleSharedHandlers)this.SharedHandlers).RecipientsChanged(args);
    }

    protected void VisibleMembersChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Company.IVisibilityRuleSharedHandlers)this.SharedHandlers).VisibleMembersChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Company.IVisibilityRuleSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void ExcludedMembersChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Company.IVisibilityRuleSharedHandlers)this.SharedHandlers).ExcludedMembersChanged(args);
    }



    protected virtual global::Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers CreateRecipientsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers CreateRecipientsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void RecipientsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("RecipientsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateRecipientsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.RecipientsAdded(args);
        }
      }
    }

    protected virtual void RecipientsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleRecipientsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("RecipientsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateRecipientsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.RecipientsDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers CreateVisibleMembersAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers CreateVisibleMembersDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void VisibleMembersAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("VisibleMembersAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateVisibleMembersAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.VisibleMembersAdded(args);
        }
      }
    }

    protected virtual void VisibleMembersDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleVisibleMembersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("VisibleMembersDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateVisibleMembersDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.VisibleMembersDeleted(args);
        }
      }
    }


    protected virtual global::Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers CreateExcludedMembersAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers CreateExcludedMembersDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ExcludedMembersAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ExcludedMembersAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateExcludedMembersAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ExcludedMembersAdded(args);
        }
      }
    }

    protected virtual void ExcludedMembersDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleExcludedMembersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ExcludedMembersDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateExcludedMembersDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ExcludedMembersDeleted(args);
        }
      }
    }


  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Company.VisibilityRuleClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }



  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Company.VisibilityRuleClientHandlers)this.Handlers).NoteValueInput(args);
    return args.NewValue;
  }




    #endregion

    #region Constructors


            protected virtual void InitRecipientsCollectionProperty()
            {
              this._Recipients = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Company.IVisibilityRuleRecipients>("Recipients", this);
              this._Recipients.ValueChanged += (sender, e) => { this.RecipientsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Recipients);
              this.SetRecipientsEventHandlers();
            }

            protected void SetRecipientsEventHandlers()
            {
              this._Recipients.ChildEntityAdded += this.RecipientsAddedHandler;
              this._Recipients.ChildEntityDeleted += this.RecipientsDeletedHandler;
            }

            protected virtual void InitVisibleMembersCollectionProperty()
            {
              this._VisibleMembers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Company.IVisibilityRuleVisibleMembers>("VisibleMembers", this);
              this._VisibleMembers.ValueChanged += (sender, e) => { this.VisibleMembersChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._VisibleMembers);
              this.SetVisibleMembersEventHandlers();
            }

            protected void SetVisibleMembersEventHandlers()
            {
              this._VisibleMembers.ChildEntityAdded += this.VisibleMembersAddedHandler;
              this._VisibleMembers.ChildEntityDeleted += this.VisibleMembersDeletedHandler;
            }

            protected virtual void InitExcludedMembersCollectionProperty()
            {
              this._ExcludedMembers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Company.IVisibilityRuleExcludedMembers>("ExcludedMembers", this);
              this._ExcludedMembers.ValueChanged += (sender, e) => { this.ExcludedMembersChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ExcludedMembers);
              this.SetExcludedMembersEventHandlers();
            }

            protected void SetExcludedMembersEventHandlers()
            {
              this._ExcludedMembers.ChildEntityAdded += this.ExcludedMembersAddedHandler;
              this._ExcludedMembers.ChildEntityDeleted += this.ExcludedMembersDeletedHandler;
            }


    public VisibilityRule()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._Note = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);


            this.InitRecipientsCollectionProperty();

            this.InitVisibleMembersCollectionProperty();

            this.InitExcludedMembersCollectionProperty();







    }

    #endregion

  }
}

// ==================================================================
// VisibilityRulePresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilityRulePresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Company.IVisibilityRule
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


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _RecipientsRecipientCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter RecipientsRecipientCollectionPresenter
                          {
                  get { return this._RecipientsRecipientCollectionPresenter; }
                }

                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _VisibleMembersRecipientCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter VisibleMembersRecipientCollectionPresenter
                          {
                  get { return this._VisibleMembersRecipientCollectionPresenter; }
                }

                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ExcludedMembersRecipientCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter ExcludedMembersRecipientCollectionPresenter
                          {
                  get { return this._ExcludedMembersRecipientCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {

                          this._RecipientsRecipientCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("54c5efff-45c1-4a8d-b920-d1bc6ba08acc"));
                        this._RecipientsRecipientCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Company.IVisibilityRuleRecipients), "Recipient");

                          this._VisibleMembersRecipientCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("a945684f-6784-415c-94cb-a1d25e1a2aaa"));
                        this._VisibleMembersRecipientCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Company.IVisibilityRuleVisibleMembers), "Recipient");

                          this._ExcludedMembersRecipientCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("6d21953f-1c11-4ce2-9b63-f59286effae0"));
                        this._ExcludedMembersRecipientCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.Company.IVisibilityRuleExcludedMembers), "Recipient");


    }

    public VisibilityRulePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// VisibilityRuleCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilityRuleCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Company.IVisibilityRule
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public VisibilityRuleCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public VisibilityRuleCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public VisibilityRuleCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public VisibilityRuleCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// VisibilityRuleRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{ 
  public class VisibilityRuleRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.Company.IVisibilityRuleRepositoryImplementer<T>
      where T : global::Sungero.Company.IVisibilityRule
    {
       public new global::Sungero.Company.IVisibilityRuleAccessRights AccessRights
       {
          get { return (global::Sungero.Company.IVisibilityRuleAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Company.IVisibilityRuleInfo Info
       {
          get { return (global::Sungero.Company.IVisibilityRuleInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Company.Client.VisibilityRuleTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// VisibilityRuleAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilityRuleAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Company.IVisibilityRuleAccessRights
  {

    public VisibilityRuleAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class VisibilityRuleTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Company.IVisibilityRuleAccessRights
  {

    public VisibilityRuleTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
