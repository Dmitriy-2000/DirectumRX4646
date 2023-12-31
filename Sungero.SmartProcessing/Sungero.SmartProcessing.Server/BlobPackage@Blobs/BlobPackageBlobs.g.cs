
// ==================================================================
// BlobPackageBlobs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class BlobPackageBlobsFilterForBlob<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.SmartProcessing.IBlob
    where TSourceEntity : class, global::Sungero.SmartProcessing.IBlobPackageBlobs
    where TRootEntity : class, global::Sungero.SmartProcessing.IBlobPackage
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.BlobPackageBlobsBlobPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("BlobsBlobFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.SmartProcessing.BlobPackageBlobsBlobPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).BlobsBlobFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public BlobPackageBlobsFilterForBlob(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class BlobPackageBlobsSearchFilterForBlob<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.SmartProcessing.IBlob
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.BlobPackageBlobsBlobSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("BlobsBlobSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.SmartProcessing.BlobPackageBlobsBlobSearchPropertyFilteringServerHandler<TQueryEntity>().BlobsBlobSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public BlobPackageBlobsSearchFilterForBlob(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.SmartProcessing.Server.BlobPackageBlobsFilterForBlob<global::Sungero.SmartProcessing.IBlob, global::Sungero.SmartProcessing.IBlobPackageBlobs, global::Sungero.SmartProcessing.IBlobPackage>), "Blob")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.SmartProcessing.Server.BlobPackageBlobsSearchFilterForBlob<global::Sungero.SmartProcessing.IBlob>), "Blob")]


  public class BlobPackageBlobs :
    global::Sungero.Domain.ChildEntity, global::Sungero.SmartProcessing.IBlobPackageBlobs
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("77013bb4-1692-40fd-a4da-f8b31bd4f7a6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Server.BlobPackageBlobs.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IBlobPackageBlobs, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.SmartProcessing.IBlobPackageBlobsState State
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageBlobsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPackageBlobsState(this);
    }

    public new virtual global::Sungero.SmartProcessing.IBlobPackageBlobsInfo Info
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageBlobsInfo)base.Info; }
    }


    public global::Sungero.SmartProcessing.IBlobPackage BlobPackage { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.BlobPackage; }
      set { this.BlobPackage = (global::Sungero.SmartProcessing.IBlobPackage)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.BlobPackageBlobsSharedHandlers(this);
    }







    private global::Sungero.SmartProcessing.IBlob _Blob;
    public virtual global::Sungero.SmartProcessing.IBlob Blob
    {
      get
      {
        return this._Blob;
      }

      set
      {
        this.SetPropertyValue("Blob", this._Blob, value, (propertyValue) => { this._Blob = propertyValue; }, this.BlobChangedHandler);
      }
    }




    #region Framework events

    protected void BlobChangedHandler()
    {
      var args = new global::Sungero.SmartProcessing.Shared.BlobPackageBlobsBlobChangedEventArgs(this.State.Properties.Blob, this.Blob, this);
     ((global::Sungero.SmartProcessing.IBlobPackageBlobsSharedHandlers)this.SharedHandlers).BlobsBlobChanged(args);
    }



    #endregion


    public BlobPackageBlobs()
    {
    }

  }
}

// ==================================================================
// BlobPackageBlobsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{
  public partial class BlobPackageBlobsBlobPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.SmartProcessing.IBlob
  {
    private global::Sungero.SmartProcessing.IBlobPackageBlobs _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageBlobs)this.Entity; }
    }

    private global::Sungero.SmartProcessing.IBlobPackage _root
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackage)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> BlobsBlobFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public BlobPackageBlobsBlobPropertyFilteringServerHandler(global::Sungero.SmartProcessing.IBlobPackageBlobs entity, global::Sungero.SmartProcessing.IBlobPackage root)
      : base(entity, root)
    {
    }
  }

  public partial class BlobPackageBlobsBlobSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.SmartProcessing.IBlob
  {

    public virtual global::System.Linq.IQueryable<T> BlobsBlobSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public BlobPackageBlobsBlobSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// BlobPackageBlobsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}
