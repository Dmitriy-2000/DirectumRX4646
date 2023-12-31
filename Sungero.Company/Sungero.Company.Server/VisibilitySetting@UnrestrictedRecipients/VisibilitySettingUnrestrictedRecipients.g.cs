
// ==================================================================
// VisibilitySettingUnrestrictedRecipients.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
  public class VisibilitySettingUnrestrictedRecipientsFilterForRecipient<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients
    where TRootEntity : class, global::Sungero.Company.IVisibilitySetting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilitySettingUnrestrictedRecipientsRecipientPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("UnrestrictedRecipientsRecipientFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Company.VisibilitySettingUnrestrictedRecipientsRecipientPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).UnrestrictedRecipientsRecipientFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilitySettingUnrestrictedRecipientsFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class VisibilitySettingUnrestrictedRecipientsSearchFilterForRecipient<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilitySettingUnrestrictedRecipientsRecipientSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("UnrestrictedRecipientsRecipientSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Company.VisibilitySettingUnrestrictedRecipientsRecipientSearchPropertyFilteringServerHandler<TQueryEntity>().UnrestrictedRecipientsRecipientSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilitySettingUnrestrictedRecipientsSearchFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Company.Server.VisibilitySettingUnrestrictedRecipientsFilterForRecipient<global::Sungero.CoreEntities.IRecipient, global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients, global::Sungero.Company.IVisibilitySetting>), "Recipient")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Company.Server.VisibilitySettingUnrestrictedRecipientsSearchFilterForRecipient<global::Sungero.CoreEntities.IRecipient>), "Recipient")]


  public class VisibilitySettingUnrestrictedRecipients :
    global::Sungero.Domain.ChildEntity, global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1bb06c07-eafe-4248-ac43-a0daaa30dd8c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Server.VisibilitySettingUnrestrictedRecipients.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IVisibilitySettingUnrestrictedRecipients, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Company.IVisibilitySettingUnrestrictedRecipientsState State
    {
      get { return (global::Sungero.Company.IVisibilitySettingUnrestrictedRecipientsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.VisibilitySettingUnrestrictedRecipientsState(this);
    }

    public new virtual global::Sungero.Company.IVisibilitySettingUnrestrictedRecipientsInfo Info
    {
      get { return (global::Sungero.Company.IVisibilitySettingUnrestrictedRecipientsInfo)base.Info; }
    }


    public global::Sungero.Company.IVisibilitySetting VisibilitySetting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.VisibilitySetting; }
      set { this.VisibilitySetting = (global::Sungero.Company.IVisibilitySetting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.VisibilitySettingUnrestrictedRecipientsSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Recipient;
    public virtual global::Sungero.CoreEntities.IRecipient Recipient
    {
      get
      {
        return this._Recipient;
      }

      set
      {
        this.SetPropertyValue("Recipient", this._Recipient, value, (propertyValue) => { this._Recipient = propertyValue; }, this.RecipientChangedHandler);
      }
    }




    #region Framework events

    protected void RecipientChangedHandler()
    {
      var args = new global::Sungero.Company.Shared.VisibilitySettingUnrestrictedRecipientsRecipientChangedEventArgs(this.State.Properties.Recipient, this.Recipient, this);
     ((global::Sungero.Company.IVisibilitySettingUnrestrictedRecipientsSharedHandlers)this.SharedHandlers).UnrestrictedRecipientsRecipientChanged(args);
    }



    #endregion


    public VisibilitySettingUnrestrictedRecipients()
    {
    }

  }
}

// ==================================================================
// VisibilitySettingUnrestrictedRecipientsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{
  public partial class VisibilitySettingUnrestrictedRecipientsRecipientPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients _obj
    {
      get { return (global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients)this.Entity; }
    }

    private global::Sungero.Company.IVisibilitySetting _root
    {
      get { return (global::Sungero.Company.IVisibilitySetting)this.Root; }
    }

    public VisibilitySettingUnrestrictedRecipientsRecipientPropertyFilteringServerHandler(global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients entity, global::Sungero.Company.IVisibilitySetting root)
      : base(entity, root)
    {
    }
  }

  public partial class VisibilitySettingUnrestrictedRecipientsRecipientSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> UnrestrictedRecipientsRecipientSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public VisibilitySettingUnrestrictedRecipientsRecipientSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// VisibilitySettingUnrestrictedRecipientsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
}
