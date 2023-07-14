
// ==================================================================
// AccessRightsBulkQueueItem.g.cs
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
    public class AccessRightsBulkQueueItemFilter<T> :
      global::Sungero.ExchangeCore.Server.QueueItemBaseFilter<T>
      where T : class, global::Sungero.Docflow.IAccessRightsBulkQueueItem
    {
      private global::Sungero.Docflow.IAccessRightsBulkQueueItemFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IAccessRightsBulkQueueItemFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public AccessRightsBulkQueueItemFilter(global::Sungero.Docflow.IAccessRightsBulkQueueItemFilterState filter)
      : base(filter)
      {
      }

      protected AccessRightsBulkQueueItemFilter()
      {
      }
    }
      public class AccessRightsBulkQueueItemUiFilter<T> :
        global::Sungero.ExchangeCore.Server.QueueItemBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IAccessRightsBulkQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class AccessRightsBulkQueueItemSearchDialogModel : global::Sungero.ExchangeCore.Server.QueueItemBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ExternalId { get; protected set; }
                  public override global::System.Int32? Retries { get; protected set; }
                  public override global::System.String Note { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBoxBase> Box { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastUpdate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> RootBox { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }


                  public virtual global::System.Int32? RuleId { get; protected set; }
                  public virtual global::System.String DocumentsIds { get; protected set; }



        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.AccessRightsBulkQueueItemFilter<global::Sungero.Docflow.IAccessRightsBulkQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.AccessRightsBulkQueueItemUiFilter<global::Sungero.Docflow.IAccessRightsBulkQueueItem>))]

  public class AccessRightsBulkQueueItem :
    global::Sungero.ExchangeCore.Server.QueueItemBase, global::Sungero.Docflow.IAccessRightsBulkQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("11c9727d-9fa1-4a08-8737-e3d174de5223");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.AccessRightsBulkQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccessRightsBulkQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IAccessRightsBulkQueueItemState State
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsBulkQueueItemState(this);
    }

    public new virtual global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo Info
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.AccessRightsBulkQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsBulkQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.AccessRightsBulkQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AccessRightsBulkQueueItemSharedHandlers(this);
    }

    private global::System.Int32? _RuleId;
    public virtual global::System.Int32? RuleId
    {
      get
      {
        return this._RuleId;
      }

      set
      {
        this.SetPropertyValue("RuleId", this._RuleId, value, (propertyValue) => { this._RuleId = propertyValue; }, this.RuleIdChangedHandler);
      }
    }
    private global::System.String _LaunchId;
    public virtual global::System.String LaunchId
    {
      get
      {
        return this._LaunchId;
      }

      set
      {
        this.SetPropertyValue("LaunchId", this._LaunchId, value, (propertyValue) => { this._LaunchId = propertyValue; }, this.LaunchIdChangedHandler);
      }
    }
    private global::System.Int32? _Priority;
    public virtual global::System.Int32? Priority
    {
      get
      {
        return this._Priority;
      }

      set
      {
        this.SetPropertyValue("Priority", this._Priority, value, (propertyValue) => { this._Priority = propertyValue; }, this.PriorityChangedHandler);
      }
    }



    private global::System.String _DocumentsIds;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.String DocumentsIds
    {
      get
      {
        return this._DocumentsIds;
      }

      set
      {
        this.SetPropertyValue("DocumentsIds", this._DocumentsIds, value, (propertyValue) => { this._DocumentsIds = propertyValue; }, this.DocumentsIdsChangedHandler);
      }
    }




    private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.ExchangeCore.Server.QueueItemBase.ProcessingStatusItems,
      typeof(global::Sungero.Docflow.AccessRightsBulkQueueItem.ProcessingStatus),
      typeof(global::Sungero.Docflow.Server.AccessRightsBulkQueueItem),
      "ProcessingStatus");

    public static new global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
    {
      get { return global::Sungero.Docflow.Server.AccessRightsBulkQueueItem._ProcessingStatusItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
    {
      get { return global::Sungero.Docflow.Server.AccessRightsBulkQueueItem.ProcessingStatusItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.AccessRightsBulkQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IAccessRightsBulkQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.AccessRightsBulkQueueItemCreatingFromServerHandler((global::Sungero.Docflow.IAccessRightsBulkQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void RuleIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.RuleId, this.RuleId, this);
     ((global::Sungero.Docflow.IAccessRightsBulkQueueItemSharedHandlers)this.SharedHandlers).RuleIdChanged(args);
    }

    protected void DocumentsIdsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.DocumentsIds, this.DocumentsIds, this);
     ((global::Sungero.Docflow.IAccessRightsBulkQueueItemSharedHandlers)this.SharedHandlers).DocumentsIdsChanged(args);
    }

    protected void LaunchIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.LaunchId, this.LaunchId, this);
     ((global::Sungero.Docflow.IAccessRightsBulkQueueItemSharedHandlers)this.SharedHandlers).LaunchIdChanged(args);
    }

    protected void PriorityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Priority, this.Priority, this);
     ((global::Sungero.Docflow.IAccessRightsBulkQueueItemSharedHandlers)this.SharedHandlers).PriorityChanged(args);
    }



    #endregion


    public AccessRightsBulkQueueItem()
    {
    }

  }
}

// ==================================================================
// AccessRightsBulkQueueItemHandlers.g.cs
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

  public partial class AccessRightsBulkQueueItemFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IAccessRightsBulkQueueItem
  {
    private global::Sungero.Docflow.IAccessRightsBulkQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IAccessRightsBulkQueueItemFilterState)this.Filter;
      }
    }

    public AccessRightsBulkQueueItemFilteringServerHandler(global::Sungero.Docflow.IAccessRightsBulkQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected AccessRightsBulkQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class AccessRightsBulkQueueItemUiFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IAccessRightsBulkQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class AccessRightsBulkQueueItemSearchDialogServerHandler : global::Sungero.ExchangeCore.QueueItemBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.AccessRightsBulkQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.AccessRightsBulkQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public AccessRightsBulkQueueItemSearchDialogServerHandler(global::Sungero.Docflow.Server.AccessRightsBulkQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class AccessRightsBulkQueueItemServerHandlers : global::Sungero.ExchangeCore.QueueItemBaseServerHandlers
  {
    private global::Sungero.Docflow.IAccessRightsBulkQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItem)this.Entity; }
    }

    public AccessRightsBulkQueueItemServerHandlers(global::Sungero.Docflow.IAccessRightsBulkQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class AccessRightsBulkQueueItemCreatingFromServerHandler : global::Sungero.ExchangeCore.QueueItemBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IAccessRightsBulkQueueItem _source
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItem)this.Source; }
    }

    private global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo _info
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo)this._Info; }
    }

    public AccessRightsBulkQueueItemCreatingFromServerHandler(global::Sungero.Docflow.IAccessRightsBulkQueueItem source, global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// AccessRightsBulkQueueItemEventArgs.g.cs
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
// AccessRightsBulkQueueItemAccessRights.g.cs
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
  public class AccessRightsBulkQueueItemAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseAccessRights, Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights
  {

    public AccessRightsBulkQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AccessRightsBulkQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseTypeAccessRights, Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights
  {

    public AccessRightsBulkQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// AccessRightsBulkQueueItemRepositoryImplementer.g.cs
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
    public class AccessRightsBulkQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Server.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IAccessRightsBulkQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IAccessRightsBulkQueueItem 
    {
       public new global::Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.AccessRightsBulkQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AccessRightsBulkQueueItemPanelNavigationFilters.g.cs
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
// AccessRightsBulkQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class AccessRightsBulkQueueItemFunctions : global::Sungero.ExchangeCore.Server.QueueItemBaseFunctions
  {
    private global::Sungero.Docflow.IAccessRightsBulkQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IAccessRightsBulkQueueItem)this.Entity; }
    }

    public AccessRightsBulkQueueItemFunctions(global::Sungero.Docflow.IAccessRightsBulkQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// AccessRightsBulkQueueItemFunctions.g.cs
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
  internal static class AccessRightsBulkQueueItem
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions" />
    internal static  global::System.Boolean SetProcessingStatusProcessed(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetProcessingStatusProcessed", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions" />
    internal static  global::System.Boolean SetProcessingStatusInProcess(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetProcessingStatusInProcess", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions" />
    internal static  global::System.Boolean SetProcessingStatusSuspended(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetProcessingStatusSuspended", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions" />
    internal static  global::System.Boolean ChangeItemStatus(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem, global::Sungero.Core.Enumeration status)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeItemStatus", new System.Type[] { typeof(global::Sungero.Core.Enumeration) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { status });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions" />
    internal static  void DeleteAccessRightsBulkQueueItem(global::Sungero.Docflow.IAccessRightsBulkQueueItem queueItem)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("DeleteAccessRightsBulkQueueItem",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IAccessRightsBulkQueueItem) }, null);
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { queueItem });
      }
      else
      {
    global::Sungero.Docflow.Server.AccessRightsBulkQueueItemFunctions.DeleteAccessRightsBulkQueueItem(queueItem);
      }
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccessRightsBulkQueueItemFunctions" />
    internal static  void SetDefaultPriority(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetDefaultPriority", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccessRightsBulkQueueItemFunctions" />
    internal static  void SetLowPriority(global::Sungero.Docflow.IAccessRightsBulkQueueItem accessRightsBulkQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accessRightsBulkQueueItem).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLowPriority", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// AccessRightsBulkQueueItemServerPublicFunctions.g.cs
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
  public class AccessRightsBulkQueueItemServerPublicFunctions : global::Sungero.Docflow.Server.IAccessRightsBulkQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// AccessRightsBulkQueueItemQueries.g.cs
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
  public class AccessRightsBulkQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.AccessRightsBulkQueueItem.AccessRightsBulkQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}