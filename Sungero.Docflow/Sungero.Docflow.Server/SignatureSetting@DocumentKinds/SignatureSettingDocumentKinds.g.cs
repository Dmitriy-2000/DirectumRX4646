
// ==================================================================
// SignatureSettingDocumentKinds.g.cs
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
  public class SignatureSettingDocumentKindsFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Docflow.ISignatureSettingDocumentKinds
    where TRootEntity : class, global::Sungero.Docflow.ISignatureSetting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.SignatureSettingDocumentKindsDocumentKindPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.SignatureSettingDocumentKindsDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DocumentKindsDocumentKindFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SignatureSettingDocumentKindsFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class SignatureSettingDocumentKindsSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.SignatureSettingDocumentKindsDocumentKindSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("DocumentKindsDocumentKindSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.SignatureSettingDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentKindsDocumentKindSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SignatureSettingDocumentKindsSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.SignatureSettingDocumentKindsFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Docflow.ISignatureSettingDocumentKinds, global::Sungero.Docflow.ISignatureSetting>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.SignatureSettingDocumentKindsSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]


  public class SignatureSettingDocumentKinds :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.ISignatureSettingDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("7eeef0f4-ad1e-4dc8-84f7-470a29f7fd91");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.SignatureSettingDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISignatureSettingDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ISignatureSettingDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.ISignatureSettingDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKindsInfo)base.Info; }
    }


    public global::Sungero.Docflow.ISignatureSetting SignatureSetting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SignatureSetting; }
      set { this.SignatureSetting = (global::Sungero.Docflow.ISignatureSetting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SignatureSettingDocumentKindsSharedHandlers(this);
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
      var args = new global::Sungero.Docflow.Shared.SignatureSettingDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.ISignatureSettingDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



    #endregion


    public SignatureSettingDocumentKinds()
    {
    }

  }
}

// ==================================================================
// SignatureSettingDocumentKindsHandlers.g.cs
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
  public partial class SignatureSettingDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Docflow.ISignatureSettingDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKinds)this.Entity; }
    }

    private global::Sungero.Docflow.ISignatureSetting _root
    {
      get { return (global::Sungero.Docflow.ISignatureSetting)this.Root; }
    }

    public SignatureSettingDocumentKindsDocumentKindPropertyFilteringServerHandler(global::Sungero.Docflow.ISignatureSettingDocumentKinds entity, global::Sungero.Docflow.ISignatureSetting root)
      : base(entity, root)
    {
    }
  }

  public partial class SignatureSettingDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public SignatureSettingDocumentKindsDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// SignatureSettingDocumentKindsEventArgs.g.cs
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
