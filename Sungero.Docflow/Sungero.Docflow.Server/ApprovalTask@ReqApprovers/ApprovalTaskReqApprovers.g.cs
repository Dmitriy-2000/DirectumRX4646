
// ==================================================================
// ApprovalTaskReqApprovers.g.cs
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
  public class ApprovalTaskReqApproversFilterForApprover<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalTaskReqApprovers
    where TRootEntity : class, global::Sungero.Docflow.IApprovalTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalTaskReqApproversApproverPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("ReqApproversApproverFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalTaskReqApproversApproverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ReqApproversApproverFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalTaskReqApproversFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalTaskReqApproversSearchFilterForApprover<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalTaskReqApproversApproverSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ReqApproversApproverSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalTaskReqApproversApproverSearchPropertyFilteringServerHandler<TQueryEntity>().ReqApproversApproverSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalTaskReqApproversSearchFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalTaskReqApproversFilterForApprover<global::Sungero.CoreEntities.IRecipient, global::Sungero.Docflow.IApprovalTaskReqApprovers, global::Sungero.Docflow.IApprovalTask>), "Approver")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalTaskReqApproversSearchFilterForApprover<global::Sungero.CoreEntities.IRecipient>), "Approver")]


  public class ApprovalTaskReqApprovers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalTaskReqApprovers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("2cdb67a1-6004-4113-a47d-e6c580bd8909");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalTaskReqApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskReqApprovers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskReqApproversState State
    {
      get { return (global::Sungero.Docflow.IApprovalTaskReqApproversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskReqApproversState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskReqApproversInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalTaskReqApproversInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalTask ApprovalTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalTask; }
      set { this.ApprovalTask = (global::Sungero.Docflow.IApprovalTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskReqApproversSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Approver;
    public virtual global::Sungero.CoreEntities.IRecipient Approver
    {
      get
      {
        return this._Approver;
      }

      set
      {
        this.SetPropertyValue("Approver", this._Approver, value, (propertyValue) => { this._Approver = propertyValue; }, this.ApproverChangedHandler);
      }
    }




    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalTaskReqApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IApprovalTaskReqApproversSharedHandlers)this.SharedHandlers).ReqApproversApproverChanged(args);
    }



    #endregion


    public ApprovalTaskReqApprovers()
    {
    }

  }
}

// ==================================================================
// ApprovalTaskReqApproversHandlers.g.cs
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
  public partial class ApprovalTaskReqApproversApproverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Docflow.IApprovalTaskReqApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTaskReqApprovers)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalTask _root
    {
      get { return (global::Sungero.Docflow.IApprovalTask)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ReqApproversApproverFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalTaskReqApproversApproverPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalTaskReqApprovers entity, global::Sungero.Docflow.IApprovalTask root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalTaskReqApproversApproverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ReqApproversApproverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalTaskReqApproversApproverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalTaskReqApproversEventArgs.g.cs
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
