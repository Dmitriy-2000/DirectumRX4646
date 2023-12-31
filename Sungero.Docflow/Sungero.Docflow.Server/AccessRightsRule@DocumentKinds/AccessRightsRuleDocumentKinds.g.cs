
// ==================================================================
// AccessRightsRuleDocumentKinds.g.cs
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
  public class AccessRightsRuleDocumentKindsFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Docflow.IAccessRightsRuleDocumentKinds
    where TRootEntity : class, global::Sungero.Docflow.IAccessRightsRule
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.AccessRightsRuleDocumentKindsDocumentKindPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.AccessRightsRuleDocumentKindsDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DocumentKindsDocumentKindFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AccessRightsRuleDocumentKindsFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class AccessRightsRuleDocumentKindsSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.AccessRightsRuleDocumentKindsDocumentKindSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.AccessRightsRuleDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentKindsDocumentKindSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AccessRightsRuleDocumentKindsSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.AccessRightsRuleDocumentKindsFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Docflow.IAccessRightsRuleDocumentKinds, global::Sungero.Docflow.IAccessRightsRule>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.AccessRightsRuleDocumentKindsSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]


  public class AccessRightsRuleDocumentKinds :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IAccessRightsRuleDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("81f24b4f-47ee-455e-bd98-80aa839c3f12");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.AccessRightsRuleDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccessRightsRuleDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IAccessRightsRuleDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.IAccessRightsRuleDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsRuleDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.IAccessRightsRuleDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.IAccessRightsRuleDocumentKindsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IAccessRightsRule AccessRightsRule { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AccessRightsRule; }
      set { this.AccessRightsRule = (global::Sungero.Docflow.IAccessRightsRule)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AccessRightsRuleDocumentKindsSharedHandlers(this);
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
      var args = new global::Sungero.Docflow.Shared.AccessRightsRuleDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.IAccessRightsRuleDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



    #endregion


    public AccessRightsRuleDocumentKinds()
    {
    }

  }
}

// ==================================================================
// AccessRightsRuleDocumentKindsHandlers.g.cs
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
  public partial class AccessRightsRuleDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Docflow.IAccessRightsRuleDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IAccessRightsRuleDocumentKinds)this.Entity; }
    }

    private global::Sungero.Docflow.IAccessRightsRule _root
    {
      get { return (global::Sungero.Docflow.IAccessRightsRule)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public AccessRightsRuleDocumentKindsDocumentKindPropertyFilteringServerHandler(global::Sungero.Docflow.IAccessRightsRuleDocumentKinds entity, global::Sungero.Docflow.IAccessRightsRule root)
      : base(entity, root)
    {
    }
  }

  public partial class AccessRightsRuleDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public AccessRightsRuleDocumentKindsDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// AccessRightsRuleDocumentKindsEventArgs.g.cs
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
