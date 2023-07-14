
// ==================================================================
// AcquaintanceTaskAcquainters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class AcquaintanceTaskAcquaintersFilterForAcquainter<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters
    where TRootEntity : class, global::Sungero.RecordManagement.IAcquaintanceTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceTaskAcquaintersAcquainterPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("AcquaintersAcquainterFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.RecordManagement.AcquaintanceTaskAcquaintersAcquainterPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AcquaintersAcquainterFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AcquaintanceTaskAcquaintersFilterForAcquainter(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class AcquaintanceTaskAcquaintersSearchFilterForAcquainter<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceTaskAcquaintersAcquainterSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AcquaintersAcquainterSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.RecordManagement.AcquaintanceTaskAcquaintersAcquainterSearchPropertyFilteringServerHandler<TQueryEntity>().AcquaintersAcquainterSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AcquaintanceTaskAcquaintersSearchFilterForAcquainter(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceTaskAcquaintersFilterForAcquainter<global::Sungero.Company.IEmployee, global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters, global::Sungero.RecordManagement.IAcquaintanceTask>), "Acquainter")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceTaskAcquaintersSearchFilterForAcquainter<global::Sungero.CoreEntities.IRecipient>), "Acquainter")]


  public class AcquaintanceTaskAcquainters :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("be141725-abac-4ecb-a6ff-00051643f4a1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceTaskAcquainters.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceTaskAcquainters, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintersState State
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintersState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskAcquaintersState(this);
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintersInfo Info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintersInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IAcquaintanceTask AcquaintanceTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceTask; }
      set { this.AcquaintanceTask = (global::Sungero.RecordManagement.IAcquaintanceTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskAcquaintersSharedHandlers(this);
    }







    private global::Sungero.Company.IEmployee _Acquainter;
    public virtual global::Sungero.Company.IEmployee Acquainter
    {
      get
      {
        return this._Acquainter;
      }

      set
      {
        this.SetPropertyValue("Acquainter", this._Acquainter, value, (propertyValue) => { this._Acquainter = propertyValue; }, this.AcquainterChangedHandler);
      }
    }




    #region Framework events

    protected void AcquainterChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.AcquaintanceTaskAcquaintersAcquainterChangedEventArgs(this.State.Properties.Acquainter, this.Acquainter, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintersSharedHandlers)this.SharedHandlers).AcquaintersAcquainterChanged(args);
    }



    #endregion


    public AcquaintanceTaskAcquainters()
    {
    }

  }
}

// ==================================================================
// AcquaintanceTaskAcquaintersHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{
  public partial class AcquaintanceTaskAcquaintersAcquainterPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters)this.Entity; }
    }

    private global::Sungero.RecordManagement.IAcquaintanceTask _root
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTask)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> AcquaintersAcquainterFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public AcquaintanceTaskAcquaintersAcquainterPropertyFilteringServerHandler(global::Sungero.RecordManagement.IAcquaintanceTaskAcquainters entity, global::Sungero.RecordManagement.IAcquaintanceTask root)
      : base(entity, root)
    {
    }
  }

  public partial class AcquaintanceTaskAcquaintersAcquainterSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AcquaintersAcquainterSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public AcquaintanceTaskAcquaintersAcquainterSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// AcquaintanceTaskAcquaintersEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}