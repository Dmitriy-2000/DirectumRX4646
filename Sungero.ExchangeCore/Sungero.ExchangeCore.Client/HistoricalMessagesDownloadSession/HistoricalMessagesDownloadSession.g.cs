
// ==================================================================
// HistoricalMessagesDownloadSession.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class HistoricalMessagesDownloadSession :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("66bde409-ecf7-4982-9278-c4da37e57fec");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSession.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IHistoricalMessagesDownloadSession, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionState State
    {
      get
      {
        return (global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSessionState(this);
    }

    public new global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionInfo Info
    {
      get
      {
        return (global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionInfo)base.Info;
      }
    }

    public new global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _PeriodBegin;

        public virtual global::System.DateTime? PeriodBegin
        {
          get { return this._PeriodBegin.Value; }
          set { this._PeriodBegin.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _PeriodEnd;

        public virtual global::System.DateTime? PeriodEnd
        {
          get { return this._PeriodEnd.Value; }
          set { this._PeriodEnd.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _LastMessageDate;

        public virtual global::System.DateTime? LastMessageDate
        {
          get { return this._LastMessageDate.Value; }
          set { this._LastMessageDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _DownloadingState;

        public virtual global::Sungero.Core.Enumeration? DownloadingState
        {
          get { return this._DownloadingState.Value; }
          set { this._DownloadingState.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _LastIncomingMessageId;

        public virtual global::System.String LastIncomingMessageId
        {
          get { return this._LastIncomingMessageId.Value; }
          set { this._LastIncomingMessageId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _LastOutgoingMessageId;

        public virtual global::System.String LastOutgoingMessageId
        {
          get { return this._LastOutgoingMessageId.Value; }
          set { this._LastOutgoingMessageId.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _DownloadingStateItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.ExchangeCore.HistoricalMessagesDownloadSession.DownloadingState),
          typeof(global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSession),
          "DownloadingState");

        public static global::Sungero.Domain.Shared.EnumerationItems DownloadingStateItems
        {
          get { return global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSession._DownloadingStateItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems DownloadingStateAllowedItems
        {
          get { return global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSession.DownloadingStateItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox> _BusinessUnitBox;

              public virtual global::Sungero.ExchangeCore.IBusinessUnitBox BusinessUnitBox
              {
              get
              {
                return this._BusinessUnitBox.Value as global::Sungero.ExchangeCore.IBusinessUnitBox;
              }

              set
              {
                (this._BusinessUnitBox as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSessionFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void PeriodBeginChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.PeriodBegin, this.PeriodBegin, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).PeriodBeginChanged(args);
    }

    protected void PeriodEndChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.PeriodEnd, this.PeriodEnd, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).PeriodEndChanged(args);
    }

    protected void BusinessUnitBoxChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSessionBusinessUnitBoxChangedEventArgs(this.State.Properties.BusinessUnitBox, this.BusinessUnitBox, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).BusinessUnitBoxChanged(args);
    }

    protected void LastMessageDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.LastMessageDate, this.LastMessageDate, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).LastMessageDateChanged(args);
    }

    protected void DownloadingStateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.DownloadingState, this.DownloadingState, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).DownloadingStateChanged(args);
    }

    protected void LastIncomingMessageIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.LastIncomingMessageId, this.LastIncomingMessageId, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).LastIncomingMessageIdChanged(args);
    }

    protected void LastOutgoingMessageIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.LastOutgoingMessageId, this.LastOutgoingMessageId, this);
     ((global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionSharedHandlers)this.SharedHandlers).LastOutgoingMessageIdChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? PeriodBeginValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.PeriodBegin, value, this, this.Info.Properties.PeriodBegin);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).PeriodBeginValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? PeriodEndValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.PeriodEnd, value, this, this.Info.Properties.PeriodEnd);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).PeriodEndValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.ExchangeCore.IBusinessUnitBox BusinessUnitBoxValueInputHandler(global::Sungero.ExchangeCore.IBusinessUnitBox value)
  {
    var args = new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionBusinessUnitBoxValueInputEventArgs(this.BusinessUnitBox, value, this, this.Info.Properties.BusinessUnitBox);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).BusinessUnitBoxValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? LastMessageDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.LastMessageDate, value, this, this.Info.Properties.LastMessageDate);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).LastMessageDateValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? DownloadingStateValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.DownloadingState, value, this, this.Info.Properties.DownloadingState);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).DownloadingStateValueInput(args);
    return args.NewValue;
  }

  protected global::System.String LastIncomingMessageIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.LastIncomingMessageId, value, this, this.Info.Properties.LastIncomingMessageId);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).LastIncomingMessageIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String LastOutgoingMessageIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.LastOutgoingMessageId, value, this, this.Info.Properties.LastOutgoingMessageId);
    ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).LastOutgoingMessageIdValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DownloadingStateFilteringHandler()
  {
    return ((global::Sungero.ExchangeCore.HistoricalMessagesDownloadSessionClientHandlers)this.Handlers).DownloadingStateFiltering(this.DownloadingStateAllowedItems);
  }




    #endregion

    #region Constructors



              protected virtual void InitBusinessUnitBoxNavigationProperty()
              {
                this._BusinessUnitBox = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>("BusinessUnitBox", this);
                this._BusinessUnitBox.ValueChanged += (sender, e) => { this.BusinessUnitBoxChangedHandler(); };
                this.AddProperty(this._BusinessUnitBox as global::Sungero.Domain.Client.IProperty);
              }




    public HistoricalMessagesDownloadSession()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._PeriodBegin = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("PeriodBegin", this);
            this._PeriodBegin.ValueChanged += (sender, e) => { this.PeriodBeginChangedHandler(); };
            this.AddProperty(this._PeriodBegin);

            this._PeriodEnd = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("PeriodEnd", this);
            this._PeriodEnd.ValueChanged += (sender, e) => { this.PeriodEndChangedHandler(); };
            this.AddProperty(this._PeriodEnd);

            this._LastMessageDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("LastMessageDate", this);
            this._LastMessageDate.ValueChanged += (sender, e) => { this.LastMessageDateChangedHandler(); };
            this.AddProperty(this._LastMessageDate);

            this._DownloadingState = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("DownloadingState", this);
            this._DownloadingState.ValueChanged += (sender, e) => { this.DownloadingStateChangedHandler(); };
            this.AddProperty(this._DownloadingState);

            this._LastIncomingMessageId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("LastIncomingMessageId", this);
            this._LastIncomingMessageId.ValueChanged += (sender, e) => { this.LastIncomingMessageIdChangedHandler(); };
            this.AddProperty(this._LastIncomingMessageId);

            this._LastOutgoingMessageId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("LastOutgoingMessageId", this);
            this._LastOutgoingMessageId.ValueChanged += (sender, e) => { this.LastOutgoingMessageIdChangedHandler(); };
            this.AddProperty(this._LastOutgoingMessageId);

            this.InitBusinessUnitBoxNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// HistoricalMessagesDownloadSessionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class HistoricalMessagesDownloadSessionPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession
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

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _BusinessUnitBoxCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter BusinessUnitBoxCollectionPresenter
              {
          get { return this._BusinessUnitBoxCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
                  this._BusinessUnitBoxCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>(global::System.Guid.Parse("796c622f-4bb7-4505-8fcc-83d73f065bcf"));
              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");


    }

    public HistoricalMessagesDownloadSessionPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// HistoricalMessagesDownloadSessionCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class HistoricalMessagesDownloadSessionCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public HistoricalMessagesDownloadSessionCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public HistoricalMessagesDownloadSessionCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public HistoricalMessagesDownloadSessionCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public HistoricalMessagesDownloadSessionCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// HistoricalMessagesDownloadSessionRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class HistoricalMessagesDownloadSessionRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession
    {
       public new global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionInfo Info
       {
          get { return (global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// HistoricalMessagesDownloadSessionAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class HistoricalMessagesDownloadSessionAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights
  {

    public HistoricalMessagesDownloadSessionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class HistoricalMessagesDownloadSessionTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionAccessRights
  {

    public HistoricalMessagesDownloadSessionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
