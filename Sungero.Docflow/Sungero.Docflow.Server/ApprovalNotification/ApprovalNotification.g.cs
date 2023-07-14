
// ==================================================================
// ApprovalNotification.g.cs
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
    public class ApprovalNotificationFilter<T> :
      global::Sungero.Workflow.Server.NoticeFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalNotification
    {
      protected new global::Sungero.Docflow.IApprovalNotificationFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IApprovalNotificationFilterState filter
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

      public ApprovalNotificationFilter(global::Sungero.Docflow.IApprovalNotificationFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ApprovalNotificationFilter()
      {
      }
    }
    public class ApprovalNotificationSearchDialogModel : global::Sungero.Workflow.Server.NoticeSearchDialogModel
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




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalNotificationFilter<global::Sungero.Docflow.IApprovalNotification>))]

  public class ApprovalNotification :
    global::Sungero.Workflow.Server.Notice, global::Sungero.Docflow.IApprovalNotification, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("be83f002-c2c0-49da-aff5-b7f3bddaabf7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalNotification, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalNotificationState State
    {
      get { return (global::Sungero.Docflow.IApprovalNotificationState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalNotificationState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalNotificationInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalNotificationInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalNotificationAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalNotificationAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalNotificationAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalNotificationFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalNotificationServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalNotificationSharedHandlers(this);
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalNotificationCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalNotification)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalNotificationCreatingFromServerHandler((global::Sungero.Docflow.IApprovalNotification)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public ApprovalNotification()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IApprovalNotificationDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalNotificationDocumentGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalNotificationOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalNotificationAddendaGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ApprovalNotificationHandlers.g.cs
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

  public partial class ApprovalNotificationFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalNotification
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IApprovalNotificationFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalNotificationFilteringServerHandler(global::Sungero.Docflow.IApprovalNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalNotificationFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ApprovalNotificationSearchDialogServerHandler : global::Sungero.Workflow.NoticeSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalNotificationSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalNotificationSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalNotificationSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalNotificationSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalNotificationServerHandlers : global::Sungero.Workflow.NoticeServerHandlers
  {
    private global::Sungero.Docflow.IApprovalNotification _obj
    {
      get { return (global::Sungero.Docflow.IApprovalNotification)this.Entity; }
    }

    public ApprovalNotificationServerHandlers(global::Sungero.Docflow.IApprovalNotification entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalNotificationCreatingFromServerHandler : global::Sungero.Workflow.NoticeCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalNotification _source
    {
      get { return (global::Sungero.Docflow.IApprovalNotification)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalNotificationInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalNotificationInfo)this._Info; }
    }

    public ApprovalNotificationCreatingFromServerHandler(global::Sungero.Docflow.IApprovalNotification source, global::Sungero.Docflow.IApprovalNotificationInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalNotificationEventArgs.g.cs
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
// ApprovalNotificationAccessRights.g.cs
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
  public class ApprovalNotificationAccessRights : 
    Sungero.Workflow.Server.NoticeAccessRights, Sungero.Docflow.IApprovalNotificationAccessRights
  {

    public ApprovalNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalNotificationTypeAccessRights : 
    Sungero.Workflow.Server.NoticeTypeAccessRights, Sungero.Docflow.IApprovalNotificationAccessRights
  {

    public ApprovalNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalNotificationRepositoryImplementer.g.cs
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
    public class ApprovalNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.NoticeRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalNotificationRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalNotification 
    {
       public new global::Sungero.Docflow.IApprovalNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalNotificationInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalNotificationPanelNavigationFilters.g.cs
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
// ApprovalNotificationServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalNotificationFunctions : global::Sungero.Workflow.Server.NoticeFunctions
  {
    private global::Sungero.Docflow.IApprovalNotification _obj
    {
      get { return (global::Sungero.Docflow.IApprovalNotification)this.Entity; }
    }

    public ApprovalNotificationFunctions(global::Sungero.Docflow.IApprovalNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalNotificationFunctions.g.cs
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
  internal static class ApprovalNotification
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalNotificationFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetStagesStateView(global::Sungero.Docflow.IApprovalNotification approvalNotification)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalNotification).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStagesStateView", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ApprovalNotificationServerPublicFunctions.g.cs
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
  public class ApprovalNotificationServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalNotificationServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalNotificationQueries.g.cs
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
  public class ApprovalNotification
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalNotification.ApprovalNotificationQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ApprovalNotificationBlock.g.cs
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
  public class ApprovalNotificationArguments: global::Sungero.Workflow.Server.Route.NoticeStartEventArguments<ApprovalNotificationBlock, global::Sungero.Workflow.NoticeBlock>
  {
    public ApprovalNotificationArguments(ApprovalNotificationBlock block) : base(block) { }
  }

  public class ApprovalNotificationEndBlockEventArguments: global::Sungero.Workflow.Server.Route.NoticeEndBlockEventArguments<ApprovalNotificationBlock, global::Sungero.Workflow.NoticeBlock, Sungero.Docflow.IApprovalNotification> 
  {
    public ApprovalNotificationEndBlockEventArguments(ApprovalNotificationBlock block) : base(block) { }
  }

  public partial class ApprovalNotificationBlock : global::Sungero.Workflow.Blocks.NoticeBlockWrapper<global::Sungero.Workflow.NoticeBlock>    
  {



    public ApprovalNotificationBlock(global::Sungero.Workflow.NoticeBlock block) : base(block) { }
  }
}

// ==================================================================
// ApprovalNotificationChildWrappers.g.cs
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
