
// ==================================================================
// PowerOfAttorneyBase.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class PowerOfAttorneyBaseFilter<T> :
      global::Sungero.Docflow.Server.InternalDocumentBaseFilter<T>
      where T : class, global::Sungero.Docflow.IPowerOfAttorneyBase
    {
      private global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        var args = new global::Sungero.Domain.FilteringEventArgs();
        global::System.Linq.IQueryable<T> result;
        var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler`1");
        if (filterType != null)
        {
          var genericType = filterType.MakeGenericType(typeof(T));
          var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { this.filter });
          var methodInfo = genericType.GetMethod("Filtering");
          result = (global::System.Linq.IQueryable<T>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
        }
        else
        {
          result = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(this.filter).Filtering(query, args);
        }
        if (args.DisableCheckRights)
        global::Sungero.Domain.Security.FilteringAccessRightsOptions.DisableCheckRights<T>();
        return result;
      }

      public PowerOfAttorneyBaseFilter(global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState filter)
      : base(filter)
      {
      }

      protected PowerOfAttorneyBaseFilter()
      {
      }
    }
    public class PowerOfAttorneyBaseSearchDialogModel : global::Sungero.Docflow.Server.InternalDocumentBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> IssuedTo { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> ValidFrom { get; protected set; }


                   public new PowerOfAttorneyBaseVersionsModel Versions { get { return (PowerOfAttorneyBaseVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new PowerOfAttorneyBaseTrackingModel Tracking { get { return (PowerOfAttorneyBaseTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class PowerOfAttorneyBaseVersionsModel : global::Sungero.Docflow.Server.InternalDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class PowerOfAttorneyBaseTrackingModel : global::Sungero.Docflow.Server.InternalDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }




  public class PowerOfAttorneyBaseFilterForIssuedTo<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IPowerOfAttorneyBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.PowerOfAttorneyBaseIssuedToPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("IssuedToFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.PowerOfAttorneyBaseIssuedToPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).IssuedToFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public PowerOfAttorneyBaseFilterForIssuedTo(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class PowerOfAttorneyBaseSearchFilterForIssuedTo<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.PowerOfAttorneyBaseIssuedToSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("IssuedToSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.PowerOfAttorneyBaseIssuedToSearchPropertyFilteringServerHandler<TQueryEntity>().IssuedToSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public PowerOfAttorneyBaseSearchFilterForIssuedTo(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyBaseFilter<global::Sungero.Docflow.IPowerOfAttorneyBase>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyBaseFilterForIssuedTo<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IPowerOfAttorneyBase>), "IssuedTo")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyBaseSearchFilterForIssuedTo<global::Sungero.CoreEntities.IRecipient>), "IssuedTo")]


  public class PowerOfAttorneyBase :
    global::Sungero.Docflow.Server.InternalDocumentBase, global::Sungero.Docflow.IPowerOfAttorneyBase, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a8d955b1-4b35-4013-b643-3ea9d80bd1ea");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyBaseState State
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyBaseSharedHandlers(this);
    }

    private global::System.DateTime? _ValidTill;
    public virtual global::System.DateTime? ValidTill
    {
      get
      {
        return this._ValidTill;
      }

      set
      {
        this.SetPropertyValue("ValidTill", this._ValidTill, value, (propertyValue) => { this._ValidTill = propertyValue; }, this.ValidTillChangedHandler);
      }
    }
    private global::System.Int32? _DaysToFinishWorks;
    public virtual global::System.Int32? DaysToFinishWorks
    {
      get
      {
        return this._DaysToFinishWorks;
      }

      set
      {
        this.SetPropertyValue("DaysToFinishWorks", this._DaysToFinishWorks, value, (propertyValue) => { this._DaysToFinishWorks = propertyValue; }, this.DaysToFinishWorksChangedHandler);
      }
    }
    private global::System.DateTime? _ValidFrom;
    public virtual global::System.DateTime? ValidFrom
    {
      get
      {
        return this._ValidFrom;
      }

      set
      {
        this.SetPropertyValue("ValidFrom", this._ValidFrom, value, (propertyValue) => { this._ValidFrom = propertyValue; }, this.ValidFromChangedHandler);
      }
    }







    private global::Sungero.Company.IEmployee _IssuedTo;
    public virtual global::Sungero.Company.IEmployee IssuedTo
    {
      get
      {
        return this._IssuedTo;
      }

      set
      {
        this.SetPropertyValue("IssuedTo", this._IssuedTo, value, (propertyValue) => { this._IssuedTo = propertyValue; }, this.IssuedToChangedHandler);
      }
    }



    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IPowerOfAttorneyBaseVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IPowerOfAttorneyBaseTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.PowerOfAttorneyBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IPowerOfAttorneyBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.PowerOfAttorneyBaseCreatingFromServerHandler((global::Sungero.Docflow.IPowerOfAttorneyBase)entitySource, this.Info);
    }

    #region Framework events

    protected void IssuedToChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.PowerOfAttorneyBaseIssuedToChangedEventArgs(this.State.Properties.IssuedTo, this.IssuedTo, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyBaseSharedHandlers)this.SharedHandlers).IssuedToChanged(args);
    }

    protected void ValidTillChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ValidTill, this.ValidTill, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyBaseSharedHandlers)this.SharedHandlers).ValidTillChanged(args);
    }

    protected void DaysToFinishWorksChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DaysToFinishWorks, this.DaysToFinishWorks, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyBaseSharedHandlers)this.SharedHandlers).DaysToFinishWorksChanged(args);
    }

    protected void ValidFromChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ValidFrom, this.ValidFrom, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyBaseSharedHandlers)this.SharedHandlers).ValidFromChanged(args);
    }





    #endregion


    public PowerOfAttorneyBase()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.PowerOfAttorneyBaseConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Docflow.PowerOfAttorneyBaseConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// PowerOfAttorneyBaseHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class PowerOfAttorneyBaseIssuedToPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> IssuedToFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public PowerOfAttorneyBaseIssuedToPropertyFilteringServerHandler(global::Sungero.Docflow.IPowerOfAttorneyBase entity)
      : base(entity)
    {
    }
  }

  public partial class PowerOfAttorneyBaseIssuedToSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> IssuedToSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public PowerOfAttorneyBaseIssuedToSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class PowerOfAttorneyBaseFilteringServerHandler<T>
    : global::Sungero.Docflow.InternalDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IPowerOfAttorneyBase
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyBaseFilteringServerHandler(global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyBaseFilteringServerHandler()
    {
    }

      public override global::System.Linq.IQueryable<Sungero.Docflow.IDocumentRegister> DocumentRegisterFiltering(global::System.Linq.IQueryable<Sungero.Docflow.IDocumentRegister> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DocumentRegisterFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Docflow.IDocumentKind> DocumentKindFiltering(global::System.Linq.IQueryable<Sungero.Docflow.IDocumentKind> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DocumentKindFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> BusinessUnitFiltering(global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.BusinessUnitFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IDepartment> DepartmentFiltering(global::System.Linq.IQueryable<Sungero.Company.IDepartment> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DepartmentFiltering(query, e);
              return query;
      }

      public virtual global::System.Linq.IQueryable<Sungero.Company.IEmployee> PerformerFiltering(global::System.Linq.IQueryable<Sungero.Company.IEmployee> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        return query;
      }


  }

  public partial class PowerOfAttorneyBaseSearchDialogServerHandler : global::Sungero.Docflow.InternalDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.PowerOfAttorneyBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.PowerOfAttorneyBaseSearchDialogModel)this.Dialog;
       }
     }

     public PowerOfAttorneyBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.PowerOfAttorneyBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class PowerOfAttorneyBaseServerHandlers : global::Sungero.Docflow.InternalDocumentBaseServerHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; }
    }

    public PowerOfAttorneyBaseServerHandlers(global::Sungero.Docflow.IPowerOfAttorneyBase entity)
      : base(entity)
    {
    }
  }

  public partial class PowerOfAttorneyBaseCreatingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _source
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Source; }
    }

    private global::Sungero.Docflow.IPowerOfAttorneyBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseInfo)this._Info; }
    }

    public PowerOfAttorneyBaseCreatingFromServerHandler(global::Sungero.Docflow.IPowerOfAttorneyBase source, global::Sungero.Docflow.IPowerOfAttorneyBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyBaseEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// PowerOfAttorneyBaseAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class PowerOfAttorneyBaseAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseAccessRights, Sungero.Docflow.IPowerOfAttorneyBaseAccessRights
  {

    public PowerOfAttorneyBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class PowerOfAttorneyBaseTypeAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseTypeAccessRights, Sungero.Docflow.IPowerOfAttorneyBaseAccessRights
  {

    public PowerOfAttorneyBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// PowerOfAttorneyBaseRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class PowerOfAttorneyBaseRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.InternalDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IPowerOfAttorneyBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IPowerOfAttorneyBase 
    {
       public new global::Sungero.Docflow.IPowerOfAttorneyBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IPowerOfAttorneyBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.PowerOfAttorneyBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// PowerOfAttorneyBasePanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class PowerOfAttorneyBaseDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorneyBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorneyBase>(query);
      }
    }

    public class PowerOfAttorneyBaseDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorneyBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorneyBase>(query);
      }
    }

    public class PowerOfAttorneyBaseBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorneyBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorneyBase>(query);
      }
    }

    public class PowerOfAttorneyBaseDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorneyBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorneyBase>(query);
      }
    }

    public class PowerOfAttorneyBasePerformerPanelNavigationFilter : global::Sungero.Domain.PanelNavigationFilterBase
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorneyBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.PerformerFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IEmployee>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorneyBase>(query);
      }
    }

}

// ==================================================================
// PowerOfAttorneyBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class PowerOfAttorneyBaseFunctions : global::Sungero.Docflow.Server.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; }
    }

    public PowerOfAttorneyBaseFunctions(global::Sungero.Docflow.IPowerOfAttorneyBase entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class PowerOfAttorneyBase
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSignatureSettingsByPOA", new System.Type[] {  });
      return (global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetActiveSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetActiveSignatureSettingsByPOA", new System.Type[] {  });
      return (global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }

  }
}

// ==================================================================
// PowerOfAttorneyBaseServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class PowerOfAttorneyBaseServerPublicFunctions : global::Sungero.Docflow.Server.IPowerOfAttorneyBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyBaseQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class PowerOfAttorneyBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.PowerOfAttorneyBase.PowerOfAttorneyBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// PowerOfAttorneyBaseServerHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class PowerOfAttorneyBaseConvertingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.Docflow.IPowerOfAttorneyBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBaseInfo)this._Info; }
    }

    public PowerOfAttorneyBaseConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Docflow.IPowerOfAttorneyBaseInfo info)
      : base(source, info)
    {
    }
  }
}
