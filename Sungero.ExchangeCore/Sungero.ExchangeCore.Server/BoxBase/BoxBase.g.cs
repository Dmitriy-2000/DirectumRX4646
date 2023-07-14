
// ==================================================================
// BoxBase.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
    public class BoxBaseFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.ExchangeCore.IBoxBase
    {
      protected new global::Sungero.ExchangeCore.IBoxBaseFilterState Filter { get; private set; }

      private global::Sungero.ExchangeCore.IBoxBaseFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        var args = new global::Sungero.Domain.FilteringEventArgs();
        global::System.Linq.IQueryable<T> result;
        var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.BoxBaseFilteringServerHandler`1");
        if (filterType != null)
        {
          var genericType = filterType.MakeGenericType(typeof(T));
          var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { this.filter });
          var methodInfo = genericType.GetMethod("Filtering");
          result = (global::System.Linq.IQueryable<T>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
        }
        else
        {
          result = new global::Sungero.ExchangeCore.BoxBaseFilteringServerHandler<T>(this.filter).Filtering(query, args);
        }
        if (args.DisableCheckRights)
        global::Sungero.Domain.Security.FilteringAccessRightsOptions.DisableCheckRights<T>();
        return result;
      }

      public BoxBaseFilter(global::Sungero.ExchangeCore.IBoxBaseFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected BoxBaseFilter()
      {
      }
    }
      public class BoxBaseUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.ExchangeCore.IBoxBase
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class BoxBaseSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Note { get; protected set; }
                  public virtual global::System.Int32? DeadlineInDays { get; protected set; }
                  public virtual global::System.Int32? DeadlineInHours { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Responsible { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ConnectionStatus { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Routing { get; protected set; }


        }




  public class BoxBaseFilterForResponsible<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.ExchangeCore.IBoxBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.BoxBaseResponsiblePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("ResponsibleFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.BoxBaseResponsiblePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).ResponsibleFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public BoxBaseFilterForResponsible(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class BoxBaseSearchFilterForResponsible<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.BoxBaseResponsibleSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ResponsibleSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.BoxBaseResponsibleSearchPropertyFilteringServerHandler<TQueryEntity>().ResponsibleSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public BoxBaseSearchFilterForResponsible(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.ExchangeCore.Server.BoxBaseFilter<global::Sungero.ExchangeCore.IBoxBase>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.ExchangeCore.Server.BoxBaseUiFilter<global::Sungero.ExchangeCore.IBoxBase>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.ExchangeCore.Server.BoxBaseFilterForResponsible<global::Sungero.Company.IEmployee, global::Sungero.ExchangeCore.IBoxBase>), "Responsible")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.ExchangeCore.Server.BoxBaseSearchFilterForResponsible<global::Sungero.CoreEntities.IRecipient>), "Responsible")]


  public class BoxBase :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.ExchangeCore.IBoxBase, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f91dcce6-a914-4c04-aba1-0f940475696b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Server.BoxBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IBoxBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.ExchangeCore.IBoxBaseState State
    {
      get { return (global::Sungero.ExchangeCore.IBoxBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.BoxBaseState(this);
    }

    public new virtual global::Sungero.ExchangeCore.IBoxBaseInfo Info
    {
      get { return (global::Sungero.ExchangeCore.IBoxBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.ExchangeCore.IBoxBaseAccessRights AccessRights
    {
      get { return (global::Sungero.ExchangeCore.IBoxBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Server.BoxBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.ExchangeCore.Server.BoxBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.BoxBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.BoxBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.BoxBaseSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInDays;
    public virtual global::System.Int32? DeadlineInDays
    {
      get
      {
        return this._DeadlineInDays;
      }

      set
      {
        this.SetPropertyValue("DeadlineInDays", this._DeadlineInDays, value, (propertyValue) => { this._DeadlineInDays = propertyValue; }, this.DeadlineInDaysChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInHours;
    public virtual global::System.Int32? DeadlineInHours
    {
      get
      {
        return this._DeadlineInHours;
      }

      set
      {
        this.SetPropertyValue("DeadlineInHours", this._DeadlineInHours, value, (propertyValue) => { this._DeadlineInHours = propertyValue; }, this.DeadlineInHoursChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ConnectionStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.ExchangeCore.BoxBase.ConnectionStatus),
      typeof(global::Sungero.ExchangeCore.Server.BoxBase),
      "ConnectionStatus");

    public static global::Sungero.Domain.Shared.EnumerationItems ConnectionStatusItems
    {
      get { return global::Sungero.ExchangeCore.Server.BoxBase._ConnectionStatusItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ConnectionStatusAllowedItems
    {
      get { return global::Sungero.ExchangeCore.Server.BoxBase.ConnectionStatusItems; }
    }

    private global::Sungero.Core.Enumeration? _ConnectionStatus;

    public virtual global::Sungero.Core.Enumeration? ConnectionStatus
    {
      get { return this._ConnectionStatus; }
      set { this.SetEnumPropertyValue("ConnectionStatus", this._ConnectionStatus, value, (propertyValue) => { this._ConnectionStatus = propertyValue; }, this.ConnectionStatusChangedHandler, this.ConnectionStatusAllowedItems); }
    }
    private static global::Sungero.Domain.Shared.EnumerationItems _RoutingItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.ExchangeCore.BoxBase.Routing),
      typeof(global::Sungero.ExchangeCore.Server.BoxBase),
      "Routing");

    public static global::Sungero.Domain.Shared.EnumerationItems RoutingItems
    {
      get { return global::Sungero.ExchangeCore.Server.BoxBase._RoutingItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems RoutingAllowedItems
    {
      get { return global::Sungero.ExchangeCore.Server.BoxBase.RoutingItems; }
    }

    private global::Sungero.Core.Enumeration? _Routing;

    public virtual global::Sungero.Core.Enumeration? Routing
    {
      get { return this._Routing; }
      set { this.SetEnumPropertyValue("Routing", this._Routing, value, (propertyValue) => { this._Routing = propertyValue; }, this.RoutingChangedHandler, this.RoutingAllowedItems); }
    }


    private global::Sungero.Company.IEmployee _Responsible;
    public virtual global::Sungero.Company.IEmployee Responsible
    {
      get
      {
        return this._Responsible;
      }

      set
      {
        this.SetPropertyValue("Responsible", this._Responsible, value, (propertyValue) => { this._Responsible = propertyValue; }, this.ResponsibleChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.ExchangeCore.BoxBaseCreatingFromServerHandler", new object[] { (global::Sungero.ExchangeCore.IBoxBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.ExchangeCore.BoxBaseCreatingFromServerHandler((global::Sungero.ExchangeCore.IBoxBase)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void ResponsibleChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.BoxBaseResponsibleChangedEventArgs(this.State.Properties.Responsible, this.Responsible, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).ResponsibleChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void ConnectionStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ConnectionStatus, this.ConnectionStatus, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).ConnectionStatusChanged(args);
    }

    protected void RoutingChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Routing, this.Routing, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).RoutingChanged(args);
    }

    protected void DeadlineInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInDays, this.DeadlineInDays, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).DeadlineInDaysChanged(args);
    }

    protected void DeadlineInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInHours, this.DeadlineInHours, this);
     ((global::Sungero.ExchangeCore.IBoxBaseSharedHandlers)this.SharedHandlers).DeadlineInHoursChanged(args);
    }



    #endregion


    public BoxBase()
    {
    }

  }
}

// ==================================================================
// BoxBaseHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{
  public partial class BoxBaseResponsiblePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.ExchangeCore.IBoxBase _obj
    {
      get { return (global::Sungero.ExchangeCore.IBoxBase)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> ResponsibleFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public BoxBaseResponsiblePropertyFilteringServerHandler(global::Sungero.ExchangeCore.IBoxBase entity)
      : base(entity)
    {
    }
  }

  public partial class BoxBaseResponsibleSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ResponsibleSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public BoxBaseResponsibleSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class BoxBaseFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.ExchangeCore.IBoxBase
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.ExchangeCore.IBoxBaseFilterState Filter { get; private set; }

    private global::Sungero.ExchangeCore.IBoxBaseFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public BoxBaseFilteringServerHandler(global::Sungero.ExchangeCore.IBoxBaseFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected BoxBaseFilteringServerHandler()
    {
    }

      public virtual global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> BusinessUnitFiltering(global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        return query;
      }

      public virtual global::System.Linq.IQueryable<Sungero.ExchangeCore.IExchangeService> ExchangeServiceFiltering(global::System.Linq.IQueryable<Sungero.ExchangeCore.IExchangeService> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        return query;
      }


  }

  public partial class BoxBaseUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.ExchangeCore.IBoxBase
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class BoxBaseSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.ExchangeCore.Server.BoxBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.ExchangeCore.Server.BoxBaseSearchDialogModel)this.Dialog;
       }
     }

     public BoxBaseSearchDialogServerHandler(global::Sungero.ExchangeCore.Server.BoxBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class BoxBaseServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.ExchangeCore.IBoxBase _obj
    {
      get { return (global::Sungero.ExchangeCore.IBoxBase)this.Entity; }
    }

    public BoxBaseServerHandlers(global::Sungero.ExchangeCore.IBoxBase entity)
      : base(entity)
    {
    }
  }

  public partial class BoxBaseCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.ExchangeCore.IBoxBase _source
    {
      get { return (global::Sungero.ExchangeCore.IBoxBase)this.Source; }
    }

    private global::Sungero.ExchangeCore.IBoxBaseInfo _info
    {
      get { return (global::Sungero.ExchangeCore.IBoxBaseInfo)this._Info; }
    }

    public BoxBaseCreatingFromServerHandler(global::Sungero.ExchangeCore.IBoxBase source, global::Sungero.ExchangeCore.IBoxBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// BoxBaseEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
}

// ==================================================================
// BoxBaseAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
  public class BoxBaseAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.ExchangeCore.IBoxBaseAccessRights
  {

    public BoxBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class BoxBaseTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.ExchangeCore.IBoxBaseAccessRights
  {

    public BoxBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// BoxBaseRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
    public class BoxBaseRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.ExchangeCore.IBoxBaseRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.IBoxBase 
    {
       public new global::Sungero.ExchangeCore.IBoxBaseAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.IBoxBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.IBoxBaseInfo Info
       {
          get { return (global::Sungero.ExchangeCore.IBoxBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Server.BoxBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// BoxBasePanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
    public class BoxBaseBusinessUnitPanelNavigationFilter : global::Sungero.Domain.PanelNavigationFilterBase
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.ExchangeCore.IBoxBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.ExchangeCore.IBoxBaseFilterState)this.State;
        var handlers = new global::Sungero.ExchangeCore.BoxBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.ExchangeCore.IBoxBase>(query);
      }
    }

    public class BoxBaseExchangeServicePanelNavigationFilter : global::Sungero.Domain.PanelNavigationFilterBase
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.ExchangeCore.IBoxBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.ExchangeCore.IExchangeService>)query;
        var typedState = (global::Sungero.ExchangeCore.IBoxBaseFilterState)this.State;
        var handlers = new global::Sungero.ExchangeCore.BoxBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.ExchangeServiceFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.ExchangeCore.IExchangeService>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.ExchangeCore.IBoxBase>(query);
      }
    }

}

// ==================================================================
// BoxBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Server
{
  public partial class BoxBaseFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.ExchangeCore.IBoxBase _obj
    {
      get { return (global::Sungero.ExchangeCore.IBoxBase)this.Entity; }
    }

    public BoxBaseFunctions(global::Sungero.ExchangeCore.IBoxBase entity) : base(entity) { }
  }
}

// ==================================================================
// BoxBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class BoxBase
  {
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::Sungero.Company.IEmployee GetResponsible(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetResponsible", new System.Type[] {  });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::Sungero.ExchangeCore.IExchangeService GetExchangeService(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetExchangeService", new System.Type[] {  });
      return (global::Sungero.ExchangeCore.IExchangeService)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::Sungero.Company.IBusinessUnit GetBusinessUnit(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetBusinessUnit", new System.Type[] {  });
      return (global::Sungero.Company.IBusinessUnit)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::System.Boolean NeedReceiveTask(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedReceiveTask", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::Sungero.Company.IDepartment GetDepartment(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDepartment", new System.Type[] {  });
      return (global::Sungero.Company.IDepartment)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox> GetActiveChildBoxes(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetActiveChildBoxes", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox> GetClosedChildBoxes(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetClosedChildBoxes", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox> GetChildBoxes(global::Sungero.ExchangeCore.IBoxBase boxBase, global::Sungero.Core.Enumeration status)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetChildBoxes", new System.Type[] { typeof(global::Sungero.Core.Enumeration) });
      return (global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IDepartmentBox>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { status });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::Sungero.Company.IEmployee GetExchangeDocumentResponsible(global::Sungero.ExchangeCore.IBoxBase boxBase, global::Sungero.Parties.ICounterparty counterparty, global::System.Collections.Generic.List<global::Sungero.Exchange.IExchangeDocumentInfo> infos)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetExchangeDocumentResponsible", new System.Type[] { typeof(global::Sungero.Parties.ICounterparty), typeof(global::System.Collections.Generic.List<global::Sungero.Exchange.IExchangeDocumentInfo>) });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { counterparty, infos });
    }
    /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.BoxBaseFunctions" />
    internal static  global::System.DateTime GetProcessingTaskDeadline(global::Sungero.ExchangeCore.IBoxBase boxBase, global::Sungero.Company.IEmployee assignee)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetProcessingTaskDeadline", new System.Type[] { typeof(global::Sungero.Company.IEmployee) });
      return (global::System.DateTime)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { assignee });
    }

    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.BoxBaseFunctions" />
    internal static  global::Sungero.ExchangeCore.IBusinessUnitBox GetRootBox(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)boxBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRootBox", new System.Type[] {  });
      return (global::Sungero.ExchangeCore.IBusinessUnitBox)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// BoxBaseServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
  public class BoxBaseServerPublicFunctions : global::Sungero.ExchangeCore.Server.IBoxBaseServerPublicFunctions
  {
    public global::Sungero.Company.IBusinessUnit GetBusinessUnit(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.GetBusinessUnit(boxBase);
    }
    public global::Sungero.Company.IDepartment GetDepartment(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.GetDepartment(boxBase);
    }
    public global::Sungero.ExchangeCore.IExchangeService GetExchangeService(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.GetExchangeService(boxBase);
    }
    public global::System.DateTime GetProcessingTaskDeadline(global::Sungero.ExchangeCore.IBoxBase boxBase, global::Sungero.Company.IEmployee assignee)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.GetProcessingTaskDeadline(boxBase, assignee);
    }
    public global::Sungero.Company.IEmployee GetResponsible(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.GetResponsible(boxBase);
    }
    public global::System.Boolean NeedReceiveTask(global::Sungero.ExchangeCore.IBoxBase boxBase)
    {
      return global::Sungero.ExchangeCore.Functions.BoxBase.NeedReceiveTask(boxBase);
    }
  }
}

// ==================================================================
// BoxBaseQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Queries
{
  public class BoxBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.ExchangeCore.Server.BoxBase.BoxBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}