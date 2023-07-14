
// ==================================================================
// FreeApprovalNotification.g.cs
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
    public class FreeApprovalNotificationFilter<T> :
      global::Sungero.Workflow.Server.NoticeFilter<T>
      where T : class, global::Sungero.Docflow.IFreeApprovalNotification
    {
      protected new global::Sungero.Docflow.IFreeApprovalNotificationFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IFreeApprovalNotificationFilterState filter
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

      public FreeApprovalNotificationFilter(global::Sungero.Docflow.IFreeApprovalNotificationFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected FreeApprovalNotificationFilter()
      {
      }
    }
    public class FreeApprovalNotificationSearchDialogModel : global::Sungero.Workflow.Server.NoticeSearchDialogModel
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



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IFreeApprovalAssignment> LinkedFreeApprovalAssignment { get; protected set; }


        }




  public class FreeApprovalNotificationFilterForLinkedFreeApprovalAssignment<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IFreeApprovalAssignment
    where TSourceEntity : class, global::Sungero.Docflow.IFreeApprovalNotification
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalNotificationLinkedFreeApprovalAssignmentPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("LinkedFreeApprovalAssignmentFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalNotificationLinkedFreeApprovalAssignmentPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).LinkedFreeApprovalAssignmentFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalNotificationFilterForLinkedFreeApprovalAssignment(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class FreeApprovalNotificationSearchFilterForLinkedFreeApprovalAssignment<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalNotificationLinkedFreeApprovalAssignmentSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("LinkedFreeApprovalAssignmentSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalNotificationLinkedFreeApprovalAssignmentSearchPropertyFilteringServerHandler<TQueryEntity>().LinkedFreeApprovalAssignmentSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalNotificationSearchFilterForLinkedFreeApprovalAssignment(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.FreeApprovalNotificationFilter<global::Sungero.Docflow.IFreeApprovalNotification>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalNotificationFilterForLinkedFreeApprovalAssignment<global::Sungero.Docflow.IFreeApprovalAssignment, global::Sungero.Docflow.IFreeApprovalNotification>), "LinkedFreeApprovalAssignment")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalNotificationSearchFilterForLinkedFreeApprovalAssignment<global::Sungero.Docflow.IFreeApprovalAssignment>), "LinkedFreeApprovalAssignment")]


  public class FreeApprovalNotification :
    global::Sungero.Workflow.Server.Notice, global::Sungero.Docflow.IFreeApprovalNotification, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("7d9816f6-1dea-4718-84a5-1a413df81145");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalNotification, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalNotificationState State
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotificationState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalNotificationState(this);
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalNotificationInfo Info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotificationInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalNotificationAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotificationAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalNotificationAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalNotificationFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.FreeApprovalNotificationServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalNotificationSharedHandlers(this);
    }







    private global::Sungero.Docflow.IFreeApprovalAssignment _LinkedFreeApprovalAssignment;
    public virtual global::Sungero.Docflow.IFreeApprovalAssignment LinkedFreeApprovalAssignment
    {
      get
      {
        return this._LinkedFreeApprovalAssignment;
      }

      set
      {
        this.SetPropertyValue("LinkedFreeApprovalAssignment", this._LinkedFreeApprovalAssignment, value, (propertyValue) => { this._LinkedFreeApprovalAssignment = propertyValue; }, this.LinkedFreeApprovalAssignmentChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.FreeApprovalNotificationCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IFreeApprovalNotification)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.FreeApprovalNotificationCreatingFromServerHandler((global::Sungero.Docflow.IFreeApprovalNotification)entitySource, this.Info);
    }

    #region Framework events

    protected void LinkedFreeApprovalAssignmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.FreeApprovalNotificationLinkedFreeApprovalAssignmentChangedEventArgs(this.State.Properties.LinkedFreeApprovalAssignment, this.LinkedFreeApprovalAssignment, this);
     ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).LinkedFreeApprovalAssignmentChanged(args);
    }



    #endregion


    public FreeApprovalNotification()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IFreeApprovalNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalNotificationAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalNotificationOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalNotificationForApprovalGroupAttachments ForApprovalGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalNotificationForApprovalGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).ForApprovalGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).ForApprovalGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalNotificationSharedHandlers)this.SharedHandlers).ForApprovalGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// FreeApprovalNotificationHandlers.g.cs
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
  public partial class FreeApprovalNotificationLinkedFreeApprovalAssignmentPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    private global::Sungero.Docflow.IFreeApprovalNotification _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotification)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> LinkedFreeApprovalAssignmentFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public FreeApprovalNotificationLinkedFreeApprovalAssignmentPropertyFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalNotification entity)
      : base(entity)
    {
    }
  }

  public partial class FreeApprovalNotificationLinkedFreeApprovalAssignmentSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {

    public virtual global::System.Linq.IQueryable<T> LinkedFreeApprovalAssignmentSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public FreeApprovalNotificationLinkedFreeApprovalAssignmentSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class FreeApprovalNotificationFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IFreeApprovalNotification
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IFreeApprovalNotificationFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalNotificationFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalNotificationFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class FreeApprovalNotificationSearchDialogServerHandler : global::Sungero.Workflow.NoticeSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.FreeApprovalNotificationSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.FreeApprovalNotificationSearchDialogModel)this.Dialog;
       }
     }

     public FreeApprovalNotificationSearchDialogServerHandler(global::Sungero.Docflow.Server.FreeApprovalNotificationSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class FreeApprovalNotificationServerHandlers : global::Sungero.Workflow.NoticeServerHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalNotification _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotification)this.Entity; }
    }

    public FreeApprovalNotificationServerHandlers(global::Sungero.Docflow.IFreeApprovalNotification entity)
      : base(entity)
    {
    }
  }

  public partial class FreeApprovalNotificationCreatingFromServerHandler : global::Sungero.Workflow.NoticeCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IFreeApprovalNotification _source
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotification)this.Source; }
    }

    private global::Sungero.Docflow.IFreeApprovalNotificationInfo _info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotificationInfo)this._Info; }
    }

    public FreeApprovalNotificationCreatingFromServerHandler(global::Sungero.Docflow.IFreeApprovalNotification source, global::Sungero.Docflow.IFreeApprovalNotificationInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// FreeApprovalNotificationEventArgs.g.cs
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
// FreeApprovalNotificationAccessRights.g.cs
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
  public class FreeApprovalNotificationAccessRights : 
    Sungero.Workflow.Server.NoticeAccessRights, Sungero.Docflow.IFreeApprovalNotificationAccessRights
  {

    public FreeApprovalNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class FreeApprovalNotificationTypeAccessRights : 
    Sungero.Workflow.Server.NoticeTypeAccessRights, Sungero.Docflow.IFreeApprovalNotificationAccessRights
  {

    public FreeApprovalNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// FreeApprovalNotificationRepositoryImplementer.g.cs
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
    public class FreeApprovalNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.NoticeRepositoryImplementer<T>,
      global::Sungero.Docflow.IFreeApprovalNotificationRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IFreeApprovalNotification 
    {
       public new global::Sungero.Docflow.IFreeApprovalNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IFreeApprovalNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IFreeApprovalNotificationInfo Info
       {
          get { return (global::Sungero.Docflow.IFreeApprovalNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.FreeApprovalNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// FreeApprovalNotificationPanelNavigationFilters.g.cs
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
// FreeApprovalNotificationServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class FreeApprovalNotificationFunctions : global::Sungero.Workflow.Server.NoticeFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalNotification _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalNotification)this.Entity; }
    }

    public FreeApprovalNotificationFunctions(global::Sungero.Docflow.IFreeApprovalNotification entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalNotificationFunctions.g.cs
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
  internal static class FreeApprovalNotification
  {
  }
}

// ==================================================================
// FreeApprovalNotificationServerPublicFunctions.g.cs
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
  public class FreeApprovalNotificationServerPublicFunctions : global::Sungero.Docflow.Server.IFreeApprovalNotificationServerPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalNotificationQueries.g.cs
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
  public class FreeApprovalNotification
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.FreeApprovalNotification.FreeApprovalNotificationQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// FreeApprovalNotificationBlock.g.cs
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
  public class FreeApprovalNotificationArguments: global::Sungero.Workflow.Server.Route.NoticeStartEventArguments<FreeApprovalNotificationBlock, global::Sungero.Workflow.NoticeBlock>
  {
    public FreeApprovalNotificationArguments(FreeApprovalNotificationBlock block) : base(block) { }
  }

  public class FreeApprovalNotificationEndBlockEventArguments: global::Sungero.Workflow.Server.Route.NoticeEndBlockEventArguments<FreeApprovalNotificationBlock, global::Sungero.Workflow.NoticeBlock, Sungero.Docflow.IFreeApprovalNotification> 
  {
    public FreeApprovalNotificationEndBlockEventArguments(FreeApprovalNotificationBlock block) : base(block) { }
  }

  public partial class FreeApprovalNotificationBlock : global::Sungero.Workflow.Blocks.NoticeBlockWrapper<global::Sungero.Workflow.NoticeBlock>    
  {
    public virtual global::Sungero.Docflow.IFreeApprovalAssignment LinkedFreeApprovalAssignment
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Docflow.IFreeApprovalAssignment>("LinkedFreeApprovalAssignment"); }
      set { this.SetCustomNavigationProperty("LinkedFreeApprovalAssignment", value); }
    }




    public FreeApprovalNotificationBlock(global::Sungero.Workflow.NoticeBlock block) : base(block) { }
  }
}

// ==================================================================
// FreeApprovalNotificationChildWrappers.g.cs
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
