
// ==================================================================
// RecordManagementSetting.g.cs
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
  public class RecordManagementSetting :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.RecordManagement.IRecordManagementSetting
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a154775d-9029-483a-93c4-b4b9a6e5ec1b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.RecordManagementSetting.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IRecordManagementSetting, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IRecordManagementSettingState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IRecordManagementSettingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.RecordManagementSettingState(this);
    }

    public new global::Sungero.RecordManagement.IRecordManagementSettingInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IRecordManagementSettingInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IRecordManagementSettingAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IRecordManagementSettingAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _AllowActionItemsWithIndefiniteDeadline;

        public virtual global::System.Boolean? AllowActionItemsWithIndefiniteDeadline
        {
          get { return this._AllowActionItemsWithIndefiniteDeadline.Value; }
          set { this._AllowActionItemsWithIndefiniteDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ControlRelativeDeadlineInDays;

        public virtual global::System.Int32? ControlRelativeDeadlineInDays
        {
          get { return this._ControlRelativeDeadlineInDays.Value; }
          set { this._ControlRelativeDeadlineInDays.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ControlRelativeDeadlineInHours;

        public virtual global::System.Int32? ControlRelativeDeadlineInHours
        {
          get { return this._ControlRelativeDeadlineInHours.Value; }
          set { this._ControlRelativeDeadlineInHours.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _AllowAcquaintanceBySubstitute;

        public virtual global::System.Boolean? AllowAcquaintanceBySubstitute
        {
          get { return this._AllowAcquaintanceBySubstitute.Value; }
          set { this._AllowAcquaintanceBySubstitute.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.RecordManagementSettingFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.RecordManagementSettingFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.RecordManagementSettingClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.RecordManagementSettingSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void AllowActionItemsWithIndefiniteDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AllowActionItemsWithIndefiniteDeadline, this.AllowActionItemsWithIndefiniteDeadline, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).AllowActionItemsWithIndefiniteDeadlineChanged(args);
    }

    protected void ControlRelativeDeadlineInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ControlRelativeDeadlineInDays, this.ControlRelativeDeadlineInDays, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).ControlRelativeDeadlineInDaysChanged(args);
    }

    protected void ControlRelativeDeadlineInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ControlRelativeDeadlineInHours, this.ControlRelativeDeadlineInHours, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).ControlRelativeDeadlineInHoursChanged(args);
    }

    protected void AllowAcquaintanceBySubstituteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AllowAcquaintanceBySubstitute, this.AllowAcquaintanceBySubstitute, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).AllowAcquaintanceBySubstituteChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.RecordManagement.RecordManagementSettingClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? AllowActionItemsWithIndefiniteDeadlineValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.AllowActionItemsWithIndefiniteDeadline, value, this, this.Info.Properties.AllowActionItemsWithIndefiniteDeadline);
    ((global::Sungero.RecordManagement.RecordManagementSettingClientHandlers)this.Handlers).AllowActionItemsWithIndefiniteDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? ControlRelativeDeadlineInDaysValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ControlRelativeDeadlineInDays, value, this, this.Info.Properties.ControlRelativeDeadlineInDays);
    ((global::Sungero.RecordManagement.RecordManagementSettingClientHandlers)this.Handlers).ControlRelativeDeadlineInDaysValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? ControlRelativeDeadlineInHoursValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ControlRelativeDeadlineInHours, value, this, this.Info.Properties.ControlRelativeDeadlineInHours);
    ((global::Sungero.RecordManagement.RecordManagementSettingClientHandlers)this.Handlers).ControlRelativeDeadlineInHoursValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? AllowAcquaintanceBySubstituteValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.AllowAcquaintanceBySubstitute, value, this, this.Info.Properties.AllowAcquaintanceBySubstitute);
    ((global::Sungero.RecordManagement.RecordManagementSettingClientHandlers)this.Handlers).AllowAcquaintanceBySubstituteValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public RecordManagementSetting()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._AllowActionItemsWithIndefiniteDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("AllowActionItemsWithIndefiniteDeadline", this);
            this._AllowActionItemsWithIndefiniteDeadline.ValueChanged += (sender, e) => { this.AllowActionItemsWithIndefiniteDeadlineChangedHandler(); };
            this.AddProperty(this._AllowActionItemsWithIndefiniteDeadline);

            this._ControlRelativeDeadlineInDays = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ControlRelativeDeadlineInDays", this);
            this._ControlRelativeDeadlineInDays.ValueChanged += (sender, e) => { this.ControlRelativeDeadlineInDaysChangedHandler(); };
            this.AddProperty(this._ControlRelativeDeadlineInDays);

            this._ControlRelativeDeadlineInHours = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ControlRelativeDeadlineInHours", this);
            this._ControlRelativeDeadlineInHours.ValueChanged += (sender, e) => { this.ControlRelativeDeadlineInHoursChangedHandler(); };
            this.AddProperty(this._ControlRelativeDeadlineInHours);

            this._AllowAcquaintanceBySubstitute = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("AllowAcquaintanceBySubstitute", this);
            this._AllowAcquaintanceBySubstitute.ValueChanged += (sender, e) => { this.AllowAcquaintanceBySubstituteChangedHandler(); };
            this.AddProperty(this._AllowAcquaintanceBySubstitute);








    }

    #endregion

  }
}

// ==================================================================
// RecordManagementSettingPresenter.g.cs
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
  public class RecordManagementSettingPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.RecordManagement.IRecordManagementSetting
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

    public RecordManagementSettingPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// RecordManagementSettingCollectionPresenter.g.cs
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
  public class RecordManagementSettingCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IRecordManagementSetting
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public RecordManagementSettingCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public RecordManagementSettingCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public RecordManagementSettingCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public RecordManagementSettingCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// RecordManagementSettingRepositoryImplementer.g.cs
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
  public class RecordManagementSettingRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.RecordManagement.IRecordManagementSettingRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IRecordManagementSetting
    {
       public new global::Sungero.RecordManagement.IRecordManagementSettingAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IRecordManagementSettingAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IRecordManagementSettingInfo Info
       {
          get { return (global::Sungero.RecordManagement.IRecordManagementSettingInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.RecordManagementSettingTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// RecordManagementSettingAccessRights.g.cs
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
  public class RecordManagementSettingAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.RecordManagement.IRecordManagementSettingAccessRights
  {

    public RecordManagementSettingAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class RecordManagementSettingTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IRecordManagementSettingAccessRights
  {

    public RecordManagementSettingTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
