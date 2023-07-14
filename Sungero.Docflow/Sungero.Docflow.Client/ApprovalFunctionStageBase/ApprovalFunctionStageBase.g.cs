
// ==================================================================
// ApprovalFunctionStageBase.g.cs
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
  public class ApprovalFunctionStageBase :
    global::Sungero.Docflow.Client.ApprovalStageBase, global::Sungero.Docflow.IApprovalFunctionStageBase
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6831f842-3ea6-412e-9637-c6315a4e6686");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalFunctionStageBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalFunctionStageBase, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalFunctionStageBaseState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionStageBaseState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionStageBaseState(this);
    }

    public new global::Sungero.Docflow.IApprovalFunctionStageBaseInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionStageBaseInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionStageBaseAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _TimeoutInDays;

        public virtual global::System.Int32? TimeoutInDays
        {
          get { return this._TimeoutInDays.Value; }
          set { this._TimeoutInDays.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _TimeoutInHours;

        public virtual global::System.Int32? TimeoutInHours
        {
          get { return this._TimeoutInHours.Value; }
          set { this._TimeoutInHours.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _TimeoutAction;

        public virtual global::Sungero.Core.Enumeration? TimeoutAction
        {
          get { return this._TimeoutAction.Value; }
          set { this._TimeoutAction.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _TimeoutActionItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalFunctionStageBase.TimeoutAction),
          typeof(global::Sungero.Docflow.Client.ApprovalFunctionStageBase),
          "TimeoutAction");

        public static global::Sungero.Domain.Shared.EnumerationItems TimeoutActionItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalFunctionStageBase._TimeoutActionItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems TimeoutActionAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalFunctionStageBase.TimeoutActionItems; }
        }










    #endregion

    #region Methods


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionStageBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionStageBaseFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionStageBaseClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionStageBaseSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void TimeoutInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.TimeoutInDays, this.TimeoutInDays, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutInDaysChanged(args);
    }

    protected void TimeoutInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.TimeoutInHours, this.TimeoutInHours, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutInHoursChanged(args);
    }

    protected void TimeoutActionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.TimeoutAction, this.TimeoutAction, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutActionChanged(args);
    }



  protected global::System.Int32? TimeoutInDaysValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.TimeoutInDays, value, this, this.Info.Properties.TimeoutInDays);
    ((global::Sungero.Docflow.ApprovalFunctionStageBaseClientHandlers)this.Handlers).TimeoutInDaysValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? TimeoutInHoursValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.TimeoutInHours, value, this, this.Info.Properties.TimeoutInHours);
    ((global::Sungero.Docflow.ApprovalFunctionStageBaseClientHandlers)this.Handlers).TimeoutInHoursValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? TimeoutActionValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.TimeoutAction, value, this, this.Info.Properties.TimeoutAction);
    ((global::Sungero.Docflow.ApprovalFunctionStageBaseClientHandlers)this.Handlers).TimeoutActionValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> TimeoutActionFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalFunctionStageBaseClientHandlers)this.Handlers).TimeoutActionFiltering(this.TimeoutActionAllowedItems);
  }


    #endregion

    #region Constructors



    public ApprovalFunctionStageBase()
    {
            this._TimeoutInDays = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("TimeoutInDays", this);
            this._TimeoutInDays.ValueChanged += (sender, e) => { this.TimeoutInDaysChangedHandler(); };
            this.AddProperty(this._TimeoutInDays);

            this._TimeoutInHours = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("TimeoutInHours", this);
            this._TimeoutInHours.ValueChanged += (sender, e) => { this.TimeoutInHoursChangedHandler(); };
            this.AddProperty(this._TimeoutInHours);

            this._TimeoutAction = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("TimeoutAction", this);
            this._TimeoutAction.ValueChanged += (sender, e) => { this.TimeoutActionChangedHandler(); };
            this.AddProperty(this._TimeoutAction);








    }

    #endregion

  }
}

// ==================================================================
// ApprovalFunctionStageBasePresenter.g.cs
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
  public class ApprovalFunctionStageBasePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalStageBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalFunctionStageBase
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

    public ApprovalFunctionStageBasePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalFunctionStageBaseCollectionPresenter.g.cs
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
  public class ApprovalFunctionStageBaseCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalStageBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalFunctionStageBase
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalFunctionStageBaseCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalFunctionStageBaseCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalFunctionStageBaseCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalFunctionStageBaseCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalFunctionStageBaseRepositoryImplementer.g.cs
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
  public class ApprovalFunctionStageBaseRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalStageBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalFunctionStageBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalFunctionStageBase
    {
       public new global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalFunctionStageBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalFunctionStageBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalFunctionStageBaseAccessRights.g.cs
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
  public class ApprovalFunctionStageBaseAccessRights : 
    Sungero.Docflow.Client.ApprovalStageBaseAccessRights, Sungero.Docflow.IApprovalFunctionStageBaseAccessRights
  {

    public ApprovalFunctionStageBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalFunctionStageBaseTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalStageBaseTypeAccessRights, Sungero.Docflow.IApprovalFunctionStageBaseAccessRights
  {

    public ApprovalFunctionStageBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}