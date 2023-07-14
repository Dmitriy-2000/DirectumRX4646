
// ==================================================================
// Minutes.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
    public class MinutesFilter<T> :
      global::Sungero.Docflow.Server.MinutesBaseFilter<T>
      where T : class, global::Sungero.Meetings.IMinutes
    {
      private global::Sungero.Meetings.IMinutesFilterState filter
      {
        get
        {
          return (Sungero.Meetings.IMinutesFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public MinutesFilter(global::Sungero.Meetings.IMinutesFilterState filter)
      : base(filter)
      {
      }

      protected MinutesFilter()
      {
      }
    }
    public class MinutesSearchDialogModel : global::Sungero.Docflow.Server.MinutesBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Meetings.IMeeting> Meeting { get; protected set; }


                   public new MinutesVersionsModel Versions { get { return (MinutesVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new MinutesTrackingModel Tracking { get { return (MinutesTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class MinutesVersionsModel : global::Sungero.Docflow.Server.MinutesBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class MinutesTrackingModel : global::Sungero.Docflow.Server.MinutesBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }




  public class MinutesFilterForMeeting<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Meetings.IMeeting
    where TSourceEntity : class, global::Sungero.Meetings.IMinutes
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.MinutesMeetingPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("MeetingFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Meetings.MinutesMeetingPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).MeetingFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MinutesFilterForMeeting(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class MinutesSearchFilterForMeeting<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Meetings.IMeeting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.MinutesMeetingSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("MeetingSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Meetings.MinutesMeetingSearchPropertyFilteringServerHandler<TQueryEntity>().MeetingSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MinutesSearchFilterForMeeting(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Meetings.Server.MinutesFilter<global::Sungero.Meetings.IMinutes>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Meetings.Server.MinutesFilterForMeeting<global::Sungero.Meetings.IMeeting, global::Sungero.Meetings.IMinutes>), "Meeting")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Meetings.Server.MinutesSearchFilterForMeeting<global::Sungero.Meetings.IMeeting>), "Meeting")]


  public class Minutes :
    global::Sungero.Docflow.Server.MinutesBase, global::Sungero.Meetings.IMinutes, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("bb4780ff-b2c3-4044-a390-e9e110791bf6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Server.Minutes.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IMinutes, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Meetings.IMinutesState State
    {
      get { return (global::Sungero.Meetings.IMinutesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.MinutesState(this);
    }

    public new virtual global::Sungero.Meetings.IMinutesInfo Info
    {
      get { return (global::Sungero.Meetings.IMinutesInfo)base.Info; }
    }

    public new virtual global::Sungero.Meetings.IMinutesAccessRights AccessRights
    {
      get { return (global::Sungero.Meetings.IMinutesAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Meetings.Server.MinutesAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Meetings.Server.MinutesFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Meetings.Shared.MinutesFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Meetings.MinutesServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Meetings.MinutesSharedHandlers(this);
    }







    private global::Sungero.Meetings.IMeeting _Meeting;
    public virtual global::Sungero.Meetings.IMeeting Meeting
    {
      get
      {
        return this._Meeting;
      }

      set
      {
        this.SetPropertyValue("Meeting", this._Meeting, value, (propertyValue) => { this._Meeting = propertyValue; }, this.MeetingChangedHandler);
      }
    }



    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Meetings.IMinutesVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Meetings.IMinutesTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Meetings.MinutesCreatingFromServerHandler", new object[] { (global::Sungero.Meetings.IMinutes)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Meetings.MinutesCreatingFromServerHandler((global::Sungero.Meetings.IMinutes)entitySource, this.Info);
    }

    #region Framework events

    protected void MeetingChangedHandler()
    {
      var args = new global::Sungero.Meetings.Shared.MinutesMeetingChangedEventArgs(this.State.Properties.Meeting, this.Meeting, this);
     ((global::Sungero.Meetings.IMinutesSharedHandlers)this.SharedHandlers).MeetingChanged(args);
    }





    #endregion


    public Minutes()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Meetings.MinutesConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Meetings.MinutesConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// MinutesHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{
  public partial class MinutesMeetingPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Meetings.IMeeting
  {
    private global::Sungero.Meetings.IMinutes _obj
    {
      get { return (global::Sungero.Meetings.IMinutes)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> MeetingFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public MinutesMeetingPropertyFilteringServerHandler(global::Sungero.Meetings.IMinutes entity)
      : base(entity)
    {
    }
  }

  public partial class MinutesMeetingSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Meetings.IMeeting
  {

    public virtual global::System.Linq.IQueryable<T> MeetingSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public MinutesMeetingSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class MinutesFilteringServerHandler<T>
    : global::Sungero.Docflow.MinutesBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Meetings.IMinutes
  {
    private global::Sungero.Meetings.IMinutesFilterState _filter
    {
      get
      {
        return (Sungero.Meetings.IMinutesFilterState)this.Filter;
      }
    }

    public MinutesFilteringServerHandler(global::Sungero.Meetings.IMinutesFilterState filter)
    : base(filter)
    {
    }

    protected MinutesFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
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


  }

  public partial class MinutesSearchDialogServerHandler : global::Sungero.Docflow.MinutesBaseSearchDialogServerHandler
   {
     private global::Sungero.Meetings.Server.MinutesSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Meetings.Server.MinutesSearchDialogModel)this.Dialog;
       }
     }

     public MinutesSearchDialogServerHandler(global::Sungero.Meetings.Server.MinutesSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class MinutesServerHandlers : global::Sungero.Docflow.MinutesBaseServerHandlers
  {
    private global::Sungero.Meetings.IMinutes _obj
    {
      get { return (global::Sungero.Meetings.IMinutes)this.Entity; }
    }

    public MinutesServerHandlers(global::Sungero.Meetings.IMinutes entity)
      : base(entity)
    {
    }
  }

  public partial class MinutesCreatingFromServerHandler : global::Sungero.Docflow.MinutesBaseCreatingFromServerHandler
  {
    private global::Sungero.Meetings.IMinutes _source
    {
      get { return (global::Sungero.Meetings.IMinutes)this.Source; }
    }

    private global::Sungero.Meetings.IMinutesInfo _info
    {
      get { return (global::Sungero.Meetings.IMinutesInfo)this._Info; }
    }

    public MinutesCreatingFromServerHandler(global::Sungero.Meetings.IMinutes source, global::Sungero.Meetings.IMinutesInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// MinutesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
}

// ==================================================================
// MinutesAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
  public class MinutesAccessRights : 
    Sungero.Docflow.Server.MinutesBaseAccessRights, Sungero.Meetings.IMinutesAccessRights
  {

    public MinutesAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class MinutesTypeAccessRights : 
    Sungero.Docflow.Server.MinutesBaseTypeAccessRights, Sungero.Meetings.IMinutesAccessRights
  {

    public MinutesTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// MinutesRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
    public class MinutesRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.MinutesBaseRepositoryImplementer<T>,
      global::Sungero.Meetings.IMinutesRepositoryImplementer<T>
      where T : global::Sungero.Meetings.IMinutes 
    {
       public new global::Sungero.Meetings.IMinutesAccessRights AccessRights
       {
          get { return (global::Sungero.Meetings.IMinutesAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Meetings.IMinutesInfo Info
       {
          get { return (global::Sungero.Meetings.IMinutesInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Meetings.Server.MinutesTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// MinutesPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
    public class MinutesDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.MinutesBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Meetings.IMinutes
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Meetings.IMinutesFilterState)this.State;
        var handlers = new global::Sungero.Meetings.MinutesFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Meetings.IMinutes>(query);
      }
    }

    public class MinutesDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.MinutesBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Meetings.IMinutes
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Meetings.IMinutesFilterState)this.State;
        var handlers = new global::Sungero.Meetings.MinutesFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Meetings.IMinutes>(query);
      }
    }

    public class MinutesBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.MinutesBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Meetings.IMinutes
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Meetings.IMinutesFilterState)this.State;
        var handlers = new global::Sungero.Meetings.MinutesFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Meetings.IMinutes>(query);
      }
    }

    public class MinutesDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.MinutesBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Meetings.IMinutes
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Meetings.IMinutesFilterState)this.State;
        var handlers = new global::Sungero.Meetings.MinutesFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Meetings.IMinutes>(query);
      }
    }

}

// ==================================================================
// MinutesServerFunctions.g.cs
// ==================================================================

namespace Sungero.Meetings.Server
{
  public partial class MinutesFunctions : global::Sungero.Docflow.Server.MinutesBaseFunctions
  {
    private global::Sungero.Meetings.IMinutes _obj
    {
      get { return (global::Sungero.Meetings.IMinutes)this.Entity; }
    }

    public MinutesFunctions(global::Sungero.Meetings.IMinutes entity) : base(entity) { }
  }
}

// ==================================================================
// MinutesFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Functions
{
  internal static class Minutes
  {
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  void FillActionItemExecutionTaskOnCreatedFromDocument(global::Sungero.Meetings.IMinutes minutes, global::Sungero.RecordManagement.IActionItemExecutionTask actionItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)minutes).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillActionItemExecutionTaskOnCreatedFromDocument", new System.Type[] { typeof(global::Sungero.RecordManagement.IActionItemExecutionTask) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { actionItem });
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::Sungero.Meetings.IMinutes CreateMinutes()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CreateMinutes",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::Sungero.Meetings.IMinutes)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.CreateMinutes();
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::System.String GetMeetingMembersShortMinutes(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingMembersShortMinutes",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingMembersShortMinutes(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::System.String GetMeetingMembersFullMinutes(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingMembersFullMinutes",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingMembersFullMinutes(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::System.String GetMeetingChairpersonSecretaryMembersWithJobTitle(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingChairpersonSecretaryMembersWithJobTitle",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingChairpersonSecretaryMembersWithJobTitle(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::System.String GetMeetingMembersWithJobTitle(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingMembersWithJobTitle",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingMembersWithJobTitle(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::Sungero.Company.IEmployee GetMeetingPresident(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingPresident",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingPresident(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::Sungero.Company.IEmployee GetMeetingSecretary(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingSecretary",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingSecretary(minutes);
      }
    }
    /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.MinutesFunctions" />
    internal static  global::System.String GetMeetingName(global::Sungero.Meetings.IMinutes minutes)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.Server.MinutesFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetMeetingName",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Meetings.IMinutes) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { minutes });
      }
      else
      {
        return global::Sungero.Meetings.Server.MinutesFunctions.GetMeetingName(minutes);
      }
    }

    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.MinutesFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Meetings.IMinutes minutes)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)minutes).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.MinutesFunctions" />
    internal static  void FillName(global::Sungero.Meetings.IMinutes minutes)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)minutes).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.MinutesFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Meetings.IMinutes minutes, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)minutes).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }

  }
}

// ==================================================================
// MinutesServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
  public class MinutesServerPublicFunctions : global::Sungero.Meetings.Server.IMinutesServerPublicFunctions
  {
  }
}

// ==================================================================
// MinutesQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Queries
{
  public class Minutes
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Meetings.Server.Minutes.MinutesQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// MinutesServerHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{
  public partial class MinutesConvertingFromServerHandler : global::Sungero.Docflow.MinutesBaseConvertingFromServerHandler
  { 
    private global::Sungero.Meetings.IMinutesInfo _info
    {
      get { return (global::Sungero.Meetings.IMinutesInfo)this._Info; }
    }

    public MinutesConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Meetings.IMinutesInfo info)
      : base(source, info)
    {
    }
  }
}