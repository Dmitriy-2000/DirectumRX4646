
// ==================================================================
// RecordManagementSetting.g.cs
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
    public class RecordManagementSettingFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.RecordManagement.IRecordManagementSetting
    {
      protected new global::Sungero.RecordManagement.IRecordManagementSettingFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IRecordManagementSettingFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public RecordManagementSettingFilter(global::Sungero.RecordManagement.IRecordManagementSettingFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected RecordManagementSettingFilter()
      {
      }
    }
      public class RecordManagementSettingUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.RecordManagement.IRecordManagementSetting
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class RecordManagementSettingSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.Boolean? AllowActionItemsWithIndefiniteDeadline { get; protected set; }
                  public virtual global::System.Boolean? AllowAcquaintanceBySubstitute { get; protected set; }



        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.RecordManagementSettingFilter<global::Sungero.RecordManagement.IRecordManagementSetting>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.RecordManagement.Server.RecordManagementSettingUiFilter<global::Sungero.RecordManagement.IRecordManagementSetting>))]

  public class RecordManagementSetting :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.RecordManagement.IRecordManagementSetting
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a154775d-9029-483a-93c4-b4b9a6e5ec1b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.RecordManagementSetting.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IRecordManagementSetting, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.RecordManagement.IRecordManagementSettingState State
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSettingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.RecordManagementSettingState(this);
    }

    public new virtual global::Sungero.RecordManagement.IRecordManagementSettingInfo Info
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSettingInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IRecordManagementSettingAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSettingAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.RecordManagementSettingAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.RecordManagementSettingFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.RecordManagementSettingFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.RecordManagementSettingServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.RecordManagementSettingSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.Boolean? _AllowActionItemsWithIndefiniteDeadline;
    public virtual global::System.Boolean? AllowActionItemsWithIndefiniteDeadline
    {
      get
      {
        return this._AllowActionItemsWithIndefiniteDeadline;
      }

      set
      {
        this.SetPropertyValue("AllowActionItemsWithIndefiniteDeadline", this._AllowActionItemsWithIndefiniteDeadline, value, (propertyValue) => { this._AllowActionItemsWithIndefiniteDeadline = propertyValue; }, this.AllowActionItemsWithIndefiniteDeadlineChangedHandler);
      }
    }
    private global::System.Int32? _ControlRelativeDeadlineInDays;
    public virtual global::System.Int32? ControlRelativeDeadlineInDays
    {
      get
      {
        return this._ControlRelativeDeadlineInDays;
      }

      set
      {
        this.SetPropertyValue("ControlRelativeDeadlineInDays", this._ControlRelativeDeadlineInDays, value, (propertyValue) => { this._ControlRelativeDeadlineInDays = propertyValue; }, this.ControlRelativeDeadlineInDaysChangedHandler);
      }
    }
    private global::System.Int32? _ControlRelativeDeadlineInHours;
    public virtual global::System.Int32? ControlRelativeDeadlineInHours
    {
      get
      {
        return this._ControlRelativeDeadlineInHours;
      }

      set
      {
        this.SetPropertyValue("ControlRelativeDeadlineInHours", this._ControlRelativeDeadlineInHours, value, (propertyValue) => { this._ControlRelativeDeadlineInHours = propertyValue; }, this.ControlRelativeDeadlineInHoursChangedHandler);
      }
    }
    private global::System.Boolean? _AllowAcquaintanceBySubstitute;
    public virtual global::System.Boolean? AllowAcquaintanceBySubstitute
    {
      get
      {
        return this._AllowAcquaintanceBySubstitute;
      }

      set
      {
        this.SetPropertyValue("AllowAcquaintanceBySubstitute", this._AllowAcquaintanceBySubstitute, value, (propertyValue) => { this._AllowAcquaintanceBySubstitute = propertyValue; }, this.AllowAcquaintanceBySubstituteChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.RecordManagementSettingCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IRecordManagementSetting)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.RecordManagementSettingCreatingFromServerHandler((global::Sungero.RecordManagement.IRecordManagementSetting)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void AllowActionItemsWithIndefiniteDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AllowActionItemsWithIndefiniteDeadline, this.AllowActionItemsWithIndefiniteDeadline, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).AllowActionItemsWithIndefiniteDeadlineChanged(args);
    }

    protected void ControlRelativeDeadlineInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ControlRelativeDeadlineInDays, this.ControlRelativeDeadlineInDays, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).ControlRelativeDeadlineInDaysChanged(args);
    }

    protected void ControlRelativeDeadlineInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ControlRelativeDeadlineInHours, this.ControlRelativeDeadlineInHours, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).ControlRelativeDeadlineInHoursChanged(args);
    }

    protected void AllowAcquaintanceBySubstituteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AllowAcquaintanceBySubstitute, this.AllowAcquaintanceBySubstitute, this);
     ((global::Sungero.RecordManagement.IRecordManagementSettingSharedHandlers)this.SharedHandlers).AllowAcquaintanceBySubstituteChanged(args);
    }



    #endregion


    public RecordManagementSetting()
    {
    }

  }
}

// ==================================================================
// RecordManagementSettingHandlers.g.cs
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

  public partial class RecordManagementSettingFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IRecordManagementSetting
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IRecordManagementSettingFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IRecordManagementSettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public RecordManagementSettingFilteringServerHandler(global::Sungero.RecordManagement.IRecordManagementSettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected RecordManagementSettingFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class RecordManagementSettingUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.RecordManagement.IRecordManagementSetting
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class RecordManagementSettingSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.RecordManagementSettingSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.RecordManagementSettingSearchDialogModel)this.Dialog;
       }
     }

     public RecordManagementSettingSearchDialogServerHandler(global::Sungero.RecordManagement.Server.RecordManagementSettingSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class RecordManagementSettingServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _obj
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Entity; }
    }

    public RecordManagementSettingServerHandlers(global::Sungero.RecordManagement.IRecordManagementSetting entity)
      : base(entity)
    {
    }
  }

  public partial class RecordManagementSettingCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _source
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Source; }
    }

    private global::Sungero.RecordManagement.IRecordManagementSettingInfo _info
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSettingInfo)this._Info; }
    }

    public RecordManagementSettingCreatingFromServerHandler(global::Sungero.RecordManagement.IRecordManagementSetting source, global::Sungero.RecordManagement.IRecordManagementSettingInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// RecordManagementSettingEventArgs.g.cs
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

// ==================================================================
// RecordManagementSettingAccessRights.g.cs
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
  public class RecordManagementSettingAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.RecordManagement.IRecordManagementSettingAccessRights
  {

    public RecordManagementSettingAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class RecordManagementSettingTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IRecordManagementSettingAccessRights
  {

    public RecordManagementSettingTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// RecordManagementSettingRepositoryImplementer.g.cs
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
    public class RecordManagementSettingRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.RecordManagement.IRecordManagementSettingRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IRecordManagementSetting 
    {
       public new global::Sungero.RecordManagement.IRecordManagementSettingAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IRecordManagementSettingAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IRecordManagementSettingInfo Info
       {
          get { return (global::Sungero.RecordManagement.IRecordManagementSettingInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.RecordManagementSettingTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// RecordManagementSettingPanelNavigationFilters.g.cs
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

// ==================================================================
// RecordManagementSettingServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class RecordManagementSettingFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _obj
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Entity; }
    }

    public RecordManagementSettingFunctions(global::Sungero.RecordManagement.IRecordManagementSetting entity) : base(entity) { }
  }
}

// ==================================================================
// RecordManagementSettingFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class RecordManagementSetting
  {
  }
}

// ==================================================================
// RecordManagementSettingServerPublicFunctions.g.cs
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
  public class RecordManagementSettingServerPublicFunctions : global::Sungero.RecordManagement.Server.IRecordManagementSettingServerPublicFunctions
  {
  }
}

// ==================================================================
// RecordManagementSettingQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Queries
{
  public class RecordManagementSetting
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.RecordManagementSetting.RecordManagementSettingQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
