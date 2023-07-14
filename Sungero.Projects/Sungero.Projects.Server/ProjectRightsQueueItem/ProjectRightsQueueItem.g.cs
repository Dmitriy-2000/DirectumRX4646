
// ==================================================================
// ProjectRightsQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectRightsQueueItemFilter<T> :
      global::Sungero.Projects.Server.ProjectQueueItemBaseFilter<T>
      where T : class, global::Sungero.Projects.IProjectRightsQueueItem
    {
      private global::Sungero.Projects.IProjectRightsQueueItemFilterState filter
      {
        get
        {
          return (Sungero.Projects.IProjectRightsQueueItemFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ProjectRightsQueueItemFilter(global::Sungero.Projects.IProjectRightsQueueItemFilterState filter)
      : base(filter)
      {
      }

      protected ProjectRightsQueueItemFilter()
      {
      }
    }
      public class ProjectRightsQueueItemUiFilter<T> :
        global::Sungero.Projects.Server.ProjectQueueItemBaseUiFilter<T>
        where T : class, global::Sungero.Projects.IProjectRightsQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ProjectRightsQueueItemSearchDialogModel : global::Sungero.Projects.Server.ProjectQueueItemBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ExternalId { get; protected set; }
                  public override global::System.Int32? Retries { get; protected set; }
                  public override global::System.String Note { get; protected set; }
                  public override global::System.Int32? ProjectId { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBoxBase> Box { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastUpdate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> RootBox { get; protected set; }


                  public virtual global::System.Int32? FolderId { get; protected set; }



        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Projects.Server.ProjectRightsQueueItemFilter<global::Sungero.Projects.IProjectRightsQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Projects.Server.ProjectRightsQueueItemUiFilter<global::Sungero.Projects.IProjectRightsQueueItem>))]

  public class ProjectRightsQueueItem :
    global::Sungero.Projects.Server.ProjectQueueItemBase, global::Sungero.Projects.IProjectRightsQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5ec13d1f-de94-43a3-a51a-1bef325d9dad");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Server.ProjectRightsQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectRightsQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Projects.IProjectRightsQueueItemState State
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectRightsQueueItemState(this);
    }

    public new virtual global::Sungero.Projects.IProjectRightsQueueItemInfo Info
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.Projects.IProjectRightsQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Projects.Server.ProjectRightsQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Projects.Server.ProjectRightsQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Projects.Shared.ProjectRightsQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectRightsQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectRightsQueueItemSharedHandlers(this);
    }

    private global::System.Int32? _FolderId;
    public virtual global::System.Int32? FolderId
    {
      get
      {
        return this._FolderId;
      }

      set
      {
        this.SetPropertyValue("FolderId", this._FolderId, value, (propertyValue) => { this._FolderId = propertyValue; }, this.FolderIdChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Projects.ProjectRightsQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.Projects.IProjectRightsQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Projects.ProjectRightsQueueItemCreatingFromServerHandler((global::Sungero.Projects.IProjectRightsQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void FolderIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.FolderId, this.FolderId, this);
     ((global::Sungero.Projects.IProjectRightsQueueItemSharedHandlers)this.SharedHandlers).FolderIdChanged(args);
    }



    #endregion


    public ProjectRightsQueueItem()
    {
    }

  }
}

// ==================================================================
// ProjectRightsQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects
{

  public partial class ProjectRightsQueueItemFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectQueueItemBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Projects.IProjectRightsQueueItem
  {
    private global::Sungero.Projects.IProjectRightsQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectRightsQueueItemFilterState)this.Filter;
      }
    }

    public ProjectRightsQueueItemFilteringServerHandler(global::Sungero.Projects.IProjectRightsQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected ProjectRightsQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ProjectRightsQueueItemUiFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectQueueItemBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Projects.IProjectRightsQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ProjectRightsQueueItemSearchDialogServerHandler : global::Sungero.Projects.ProjectQueueItemBaseSearchDialogServerHandler
   {
     private global::Sungero.Projects.Server.ProjectRightsQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Projects.Server.ProjectRightsQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public ProjectRightsQueueItemSearchDialogServerHandler(global::Sungero.Projects.Server.ProjectRightsQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ProjectRightsQueueItemServerHandlers : global::Sungero.Projects.ProjectQueueItemBaseServerHandlers
  {
    private global::Sungero.Projects.IProjectRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItem)this.Entity; }
    }

    public ProjectRightsQueueItemServerHandlers(global::Sungero.Projects.IProjectRightsQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class ProjectRightsQueueItemCreatingFromServerHandler : global::Sungero.Projects.ProjectQueueItemBaseCreatingFromServerHandler
  {
    private global::Sungero.Projects.IProjectRightsQueueItem _source
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItem)this.Source; }
    }

    private global::Sungero.Projects.IProjectRightsQueueItemInfo _info
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItemInfo)this._Info; }
    }

    public ProjectRightsQueueItemCreatingFromServerHandler(global::Sungero.Projects.IProjectRightsQueueItem source, global::Sungero.Projects.IProjectRightsQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ProjectRightsQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}

// ==================================================================
// ProjectRightsQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectRightsQueueItemAccessRights : 
    Sungero.Projects.Server.ProjectQueueItemBaseAccessRights, Sungero.Projects.IProjectRightsQueueItemAccessRights
  {

    public ProjectRightsQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ProjectRightsQueueItemTypeAccessRights : 
    Sungero.Projects.Server.ProjectQueueItemBaseTypeAccessRights, Sungero.Projects.IProjectRightsQueueItemAccessRights
  {

    public ProjectRightsQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ProjectRightsQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectRightsQueueItemRepositoryImplementer<T> : 
      global::Sungero.Projects.Server.ProjectQueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Projects.IProjectRightsQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Projects.IProjectRightsQueueItem 
    {
       public new global::Sungero.Projects.IProjectRightsQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Projects.IProjectRightsQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Projects.IProjectRightsQueueItemInfo Info
       {
          get { return (global::Sungero.Projects.IProjectRightsQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Projects.Server.ProjectRightsQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ProjectRightsQueueItemPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}

// ==================================================================
// ProjectRightsQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Server
{
  public partial class ProjectRightsQueueItemFunctions : global::Sungero.Projects.Server.ProjectQueueItemBaseFunctions
  {
    private global::Sungero.Projects.IProjectRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectRightsQueueItem)this.Entity; }
    }

    public ProjectRightsQueueItemFunctions(global::Sungero.Projects.IProjectRightsQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectRightsQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Functions
{
  internal static class ProjectRightsQueueItem
  {
  }
}

// ==================================================================
// ProjectRightsQueueItemServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectRightsQueueItemServerPublicFunctions : global::Sungero.Projects.Server.IProjectRightsQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// ProjectRightsQueueItemQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Queries
{
  public class ProjectRightsQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Projects.Server.ProjectRightsQueueItem.ProjectRightsQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}