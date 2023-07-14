
// ==================================================================
// ApprovalTaskAddressees.g.cs
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
  public class ApprovalTaskAddresseesFilterForAddressee<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalTaskAddressees
    where TRootEntity : class, global::Sungero.Docflow.IApprovalTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalTaskAddresseesAddresseePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("AddresseesAddresseeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalTaskAddresseesAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AddresseesAddresseeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalTaskAddresseesFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalTaskAddresseesSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalTaskAddresseesAddresseeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AddresseesAddresseeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalTaskAddresseesAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseesAddresseeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalTaskAddresseesSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalTaskAddresseesFilterForAddressee<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IApprovalTaskAddressees, global::Sungero.Docflow.IApprovalTask>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalTaskAddresseesSearchFilterForAddressee<global::Sungero.CoreEntities.IRecipient>), "Addressee")]


  public class ApprovalTaskAddressees :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalTaskAddressees
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("342199d9-3901-451f-b03a-2255b9db6377");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalTaskAddressees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskAddressees, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskAddresseesState State
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddresseesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddresseesState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskAddresseesInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddresseesInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalTask ApprovalTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalTask; }
      set { this.ApprovalTask = (global::Sungero.Docflow.IApprovalTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskAddresseesSharedHandlers(this);
    }







    private global::Sungero.Company.IEmployee _Addressee;
    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get
      {
        return this._Addressee;
      }

      set
      {
        this.SetPropertyValue("Addressee", this._Addressee, value, (propertyValue) => { this._Addressee = propertyValue; }, this.AddresseeChangedHandler);
      }
    }




    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalTaskAddresseesAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.IApprovalTaskAddresseesSharedHandlers)this.SharedHandlers).AddresseesAddresseeChanged(args);
    }



    #endregion


    public ApprovalTaskAddressees()
    {
    }

  }
}

// ==================================================================
// ApprovalTaskAddresseesHandlers.g.cs
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
  public partial class ApprovalTaskAddresseesAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IApprovalTaskAddressees _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddressees)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalTask _root
    {
      get { return (global::Sungero.Docflow.IApprovalTask)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseesAddresseeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalTaskAddresseesAddresseePropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalTaskAddressees entity, global::Sungero.Docflow.IApprovalTask root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalTaskAddresseesAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddresseesAddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalTaskAddresseesAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalTaskAddresseesEventArgs.g.cs
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