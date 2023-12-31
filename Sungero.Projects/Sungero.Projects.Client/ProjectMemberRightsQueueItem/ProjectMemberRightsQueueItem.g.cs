
// ==================================================================
// ProjectMemberRightsQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectMemberRightsQueueItem :
    global::Sungero.Projects.Client.ProjectQueueItemBase, global::Sungero.Projects.IProjectMemberRightsQueueItem
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b7edf323-816d-4213-abca-6ee7da1c03bd");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Client.ProjectMemberRightsQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectMemberRightsQueueItem, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Projects.IProjectMemberRightsQueueItemState State
    {
      get
      {
        return (global::Sungero.Projects.IProjectMemberRightsQueueItemState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectMemberRightsQueueItemState(this);
    }

    public new global::Sungero.Projects.IProjectMemberRightsQueueItemInfo Info
    {
      get
      {
        return (global::Sungero.Projects.IProjectMemberRightsQueueItemInfo)base.Info;
      }
    }

    public new global::Sungero.Projects.IProjectMemberRightsQueueItemAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Projects.IProjectMemberRightsQueueItemAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Projects.Shared.ProjectMemberRightsQueueItemFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectMemberRightsQueueItemClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectMemberRightsQueueItemSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public ProjectMemberRightsQueueItem()
    {








    }

    #endregion

  }
}

// ==================================================================
// ProjectMemberRightsQueueItemPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectMemberRightsQueueItemPresenter<T> :
    global::Sungero.Projects.Client.ProjectQueueItemBasePresenter<T>
    where T : class, global::Sungero.Projects.IProjectMemberRightsQueueItem
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
              this._BoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBoxBase>(() => this.Entity.Id, typeof(T), "Box");

              this._RootBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "RootBox");


    }

    public ProjectMemberRightsQueueItemPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ProjectMemberRightsQueueItemCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectMemberRightsQueueItemCollectionPresenter<T> : 
    global::Sungero.Projects.Client.ProjectQueueItemBaseCollectionPresenter<T>
    where T: class, global::Sungero.Projects.IProjectMemberRightsQueueItem
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ProjectMemberRightsQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ProjectMemberRightsQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ProjectMemberRightsQueueItemCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ProjectMemberRightsQueueItemCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ProjectMemberRightsQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{ 
  public class ProjectMemberRightsQueueItemRepositoryImplementer<T> : 
      global::Sungero.Projects.Client.ProjectQueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Projects.IProjectMemberRightsQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Projects.IProjectMemberRightsQueueItem
    {
       public new global::Sungero.Projects.IProjectMemberRightsQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Projects.IProjectMemberRightsQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Projects.IProjectMemberRightsQueueItemInfo Info
       {
          get { return (global::Sungero.Projects.IProjectMemberRightsQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Projects.Client.ProjectMemberRightsQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ProjectMemberRightsQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectMemberRightsQueueItemAccessRights : 
    Sungero.Projects.Client.ProjectQueueItemBaseAccessRights, Sungero.Projects.IProjectMemberRightsQueueItemAccessRights
  {

    public ProjectMemberRightsQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ProjectMemberRightsQueueItemTypeAccessRights : 
    Sungero.Projects.Client.ProjectQueueItemBaseTypeAccessRights, Sungero.Projects.IProjectMemberRightsQueueItemAccessRights
  {

    public ProjectMemberRightsQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
