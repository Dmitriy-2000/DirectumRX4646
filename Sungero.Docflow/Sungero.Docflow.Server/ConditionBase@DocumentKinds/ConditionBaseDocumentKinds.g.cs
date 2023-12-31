
// ==================================================================
// ConditionBaseDocumentKinds.g.cs
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
  public class ConditionBaseDocumentKindsFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Docflow.IConditionBaseDocumentKinds
    where TRootEntity : class, global::Sungero.Docflow.IConditionBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ConditionBaseDocumentKindsDocumentKindPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ConditionBaseDocumentKindsDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DocumentKindsDocumentKindFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ConditionBaseDocumentKindsFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ConditionBaseDocumentKindsSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ConditionBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ConditionBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentKindsDocumentKindSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ConditionBaseDocumentKindsSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ConditionBaseDocumentKindsFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Docflow.IConditionBaseDocumentKinds, global::Sungero.Docflow.IConditionBase>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ConditionBaseDocumentKindsSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]


  public class ConditionBaseDocumentKinds :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IConditionBaseDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5cfe7890-17a1-40b1-bb97-8c5d9a0c4717");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ConditionBaseDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IConditionBaseDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IConditionBaseDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.IConditionBaseDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKindsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IConditionBase ConditionBase { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ConditionBase; }
      set { this.ConditionBase = (global::Sungero.Docflow.IConditionBase)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ConditionBaseDocumentKindsSharedHandlers(this);
    }







    private global::Sungero.Docflow.IDocumentKind _DocumentKind;
    public virtual global::Sungero.Docflow.IDocumentKind DocumentKind
    {
      get
      {
        return this._DocumentKind;
      }

      set
      {
        this.SetPropertyValue("DocumentKind", this._DocumentKind, value, (propertyValue) => { this._DocumentKind = propertyValue; }, this.DocumentKindChangedHandler);
      }
    }




    #region Framework events

    protected void DocumentKindChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ConditionBaseDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.IConditionBaseDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



    #endregion


    public ConditionBaseDocumentKinds()
    {
    }

  }
}

// ==================================================================
// ConditionBaseDocumentKindsHandlers.g.cs
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
  public partial class ConditionBaseDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Docflow.IConditionBaseDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IConditionBaseDocumentKinds)this.Entity; }
    }

    private global::Sungero.Docflow.IConditionBase _root
    {
      get { return (global::Sungero.Docflow.IConditionBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ConditionBaseDocumentKindsDocumentKindPropertyFilteringServerHandler(global::Sungero.Docflow.IConditionBaseDocumentKinds entity, global::Sungero.Docflow.IConditionBase root)
      : base(entity, root)
    {
    }
  }

  public partial class ConditionBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ConditionBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ConditionBaseDocumentKindsEventArgs.g.cs
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
