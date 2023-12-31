
// ==================================================================
// SmartProcessingSettingCaptureSources.g.cs
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
  public class SmartProcessingSettingCaptureSourcesFilterForResponsible<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Docflow.ISmartProcessingSettingCaptureSources
    where TRootEntity : class, global::Sungero.Docflow.ISmartProcessingSetting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.SmartProcessingSettingCaptureSourcesResponsiblePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("CaptureSourcesResponsibleFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.SmartProcessingSettingCaptureSourcesResponsiblePropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).CaptureSourcesResponsibleFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SmartProcessingSettingCaptureSourcesFilterForResponsible(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class SmartProcessingSettingCaptureSourcesSearchFilterForResponsible<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.SmartProcessingSettingCaptureSourcesResponsibleSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("CaptureSourcesResponsibleSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.SmartProcessingSettingCaptureSourcesResponsibleSearchPropertyFilteringServerHandler<TQueryEntity>().CaptureSourcesResponsibleSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SmartProcessingSettingCaptureSourcesSearchFilterForResponsible(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.SmartProcessingSettingCaptureSourcesFilterForResponsible<global::Sungero.CoreEntities.IRecipient, global::Sungero.Docflow.ISmartProcessingSettingCaptureSources, global::Sungero.Docflow.ISmartProcessingSetting>), "Responsible")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.SmartProcessingSettingCaptureSourcesSearchFilterForResponsible<global::Sungero.CoreEntities.IRecipient>), "Responsible")]


  public class SmartProcessingSettingCaptureSources :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.ISmartProcessingSettingCaptureSources
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1b054ae6-1507-423d-bc1c-347a231d7ba6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.SmartProcessingSettingCaptureSources.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISmartProcessingSettingCaptureSources, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesState State
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingCaptureSourcesState(this);
    }

    public new virtual global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesInfo Info
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesInfo)base.Info; }
    }


    public global::Sungero.Docflow.ISmartProcessingSetting SmartProcessingSetting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SmartProcessingSetting; }
      set { this.SmartProcessingSetting = (global::Sungero.Docflow.ISmartProcessingSetting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SmartProcessingSettingCaptureSourcesSharedHandlers(this);
    }

    private global::System.String _SenderLineName;
    public virtual global::System.String SenderLineName
    {
      get
      {
        return this._SenderLineName;
      }

      set
      {
        this.SetPropertyValue("SenderLineName", this._SenderLineName, value, (propertyValue) => { this._SenderLineName = propertyValue; }, this.SenderLineNameChangedHandler);
      }
    }
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }







    private global::Sungero.CoreEntities.IRecipient _Responsible;
    public virtual global::Sungero.CoreEntities.IRecipient Responsible
    {
      get
      {
        return this._Responsible;
      }

      set
      {
        this.SetPropertyValue("Responsible", this._Responsible, value, (propertyValue) => { this._Responsible = propertyValue; }, this.ResponsibleChangedHandler);
      }
    }




    #region Framework events

    protected void SenderLineNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SenderLineName, this.SenderLineName, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesSharedHandlers)this.SharedHandlers).CaptureSourcesSenderLineNameChanged(args);
    }

    protected void ResponsibleChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.SmartProcessingSettingCaptureSourcesResponsibleChangedEventArgs(this.State.Properties.Responsible, this.Responsible, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesSharedHandlers)this.SharedHandlers).CaptureSourcesResponsibleChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesSharedHandlers)this.SharedHandlers).CaptureSourcesNoteChanged(args);
    }



    #endregion


    public SmartProcessingSettingCaptureSources()
    {
    }

  }
}

// ==================================================================
// SmartProcessingSettingCaptureSourcesHandlers.g.cs
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
  public partial class SmartProcessingSettingCaptureSourcesResponsiblePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Docflow.ISmartProcessingSettingCaptureSources _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSources)this.Entity; }
    }

    private global::Sungero.Docflow.ISmartProcessingSetting _root
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSetting)this.Root; }
    }

    public SmartProcessingSettingCaptureSourcesResponsiblePropertyFilteringServerHandler(global::Sungero.Docflow.ISmartProcessingSettingCaptureSources entity, global::Sungero.Docflow.ISmartProcessingSetting root)
      : base(entity, root)
    {
    }
  }

  public partial class SmartProcessingSettingCaptureSourcesResponsibleSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> CaptureSourcesResponsibleSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public SmartProcessingSettingCaptureSourcesResponsibleSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// SmartProcessingSettingCaptureSourcesEventArgs.g.cs
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
