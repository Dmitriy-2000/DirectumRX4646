
// ==================================================================
// FreeApprovalAssignment.g.cs
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
    public class FreeApprovalAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.IFreeApprovalAssignment
    {
      protected new global::Sungero.Docflow.IFreeApprovalAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IFreeApprovalAssignmentFilterState filter
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

      public FreeApprovalAssignmentFilter(global::Sungero.Docflow.IFreeApprovalAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected FreeApprovalAssignmentFilter()
      {
      }
    }
    public class FreeApprovalAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }
                  public override global::System.Boolean? HasSubtasksInProcess { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Performer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Deadline { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Result { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> AddresseeDeadline { get; protected set; }


        }




  public class FreeApprovalAssignmentFilterForAddressee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalAssignmentAddresseePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("AddresseeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalAssignmentAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AddresseeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalAssignmentFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class FreeApprovalAssignmentSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalAssignmentAddresseeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AddresseeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalAssignmentAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalAssignmentSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.FreeApprovalAssignmentFilter<global::Sungero.Docflow.IFreeApprovalAssignment>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalAssignmentFilterForAddressee<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IFreeApprovalAssignment>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalAssignmentSearchFilterForAddressee<global::Sungero.CoreEntities.IRecipient>), "Addressee")]


  public class FreeApprovalAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.IFreeApprovalAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("01be6c28-8785-4f74-9877-e3270704452e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalAssignmentState State
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.FreeApprovalAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers(this);
    }

    private global::System.DateTime? _AddresseeDeadline;
    public virtual global::System.DateTime? AddresseeDeadline
    {
      get
      {
        return this._AddresseeDeadline;
      }

      set
      {
        this.SetPropertyValue("AddresseeDeadline", this._AddresseeDeadline, value, (propertyValue) => { this._AddresseeDeadline = propertyValue; }, this.AddresseeDeadlineChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.FreeApprovalAssignment.Result),
      typeof(global::Sungero.Docflow.Server.FreeApprovalAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalAssignment.ResultItems; }
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




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.FreeApprovalAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IFreeApprovalAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.FreeApprovalAssignmentCreatingFromServerHandler((global::Sungero.Docflow.IFreeApprovalAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.FreeApprovalAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void AddresseeDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.AddresseeDeadline, this.AddresseeDeadline, this);
     ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddresseeDeadlineChanged(args);
    }



    #endregion


    public FreeApprovalAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentForApprovalGroupAttachments ForApprovalGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentForApprovalGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// FreeApprovalAssignmentHandlers.g.cs
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
  public partial class FreeApprovalAssignmentAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public FreeApprovalAssignmentAddresseePropertyFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class FreeApprovalAssignmentAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public FreeApprovalAssignmentAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class FreeApprovalAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IFreeApprovalAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalAssignmentFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class FreeApprovalAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.FreeApprovalAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.FreeApprovalAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public FreeApprovalAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.FreeApprovalAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class FreeApprovalAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public FreeApprovalAssignmentServerHandlers(global::Sungero.Docflow.IFreeApprovalAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class FreeApprovalAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _source
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Source; }
    }

    private global::Sungero.Docflow.IFreeApprovalAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentInfo)this._Info; }
    }

    public FreeApprovalAssignmentCreatingFromServerHandler(global::Sungero.Docflow.IFreeApprovalAssignment source, global::Sungero.Docflow.IFreeApprovalAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// FreeApprovalAssignmentEventArgs.g.cs
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

// ==================================================================
// FreeApprovalAssignmentAccessRights.g.cs
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
  public class FreeApprovalAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.IFreeApprovalAssignmentAccessRights
  {

    public FreeApprovalAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class FreeApprovalAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.IFreeApprovalAssignmentAccessRights
  {

    public FreeApprovalAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// FreeApprovalAssignmentRepositoryImplementer.g.cs
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
    public class FreeApprovalAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IFreeApprovalAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IFreeApprovalAssignment 
    {
       public new global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IFreeApprovalAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IFreeApprovalAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.FreeApprovalAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// FreeApprovalAssignmentPanelNavigationFilters.g.cs
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

// ==================================================================
// FreeApprovalAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class FreeApprovalAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public FreeApprovalAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class FreeApprovalAssignment
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FreeApprovalAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Boolean CanForwardTo(global::Sungero.Docflow.IFreeApprovalAssignment freeApprovalAssignment, global::Sungero.Company.IEmployee employee)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanForwardTo", new System.Type[] { typeof(global::Sungero.Company.IEmployee) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { employee });
    }

  }
}

// ==================================================================
// FreeApprovalAssignmentServerPublicFunctions.g.cs
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
  public class FreeApprovalAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.IFreeApprovalAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalAssignmentQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class FreeApprovalAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.FreeApprovalAssignment.FreeApprovalAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// FreeApprovalAssignmentBlock.g.cs
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
  public class FreeApprovalAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<FreeApprovalAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public FreeApprovalAssignmentArguments(FreeApprovalAssignmentBlock block) : base(block) { }
  }

  public class FreeApprovalAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<FreeApprovalAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.IFreeApprovalAssignment> 
  {
    public FreeApprovalAssignmentEndBlockEventArguments(FreeApprovalAssignmentBlock block) : base(block) { }
  }

  public partial class FreeApprovalAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.DateTime? AddresseeDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("AddresseeDeadline"); }
      set { this.SetCustomProperty("AddresseeDeadline", value); }
    }

    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Company.IEmployee>("Addressee"); }
      set { this.SetCustomNavigationProperty("Addressee", value); }
    }




    public FreeApprovalAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentChildWrappers.g.cs
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