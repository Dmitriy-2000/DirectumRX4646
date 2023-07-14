
// ==================================================================
// ReviewClerkNotificationState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ReviewClerkNotificationState : 
    global::Sungero.Workflow.Shared.NoticeState, global::Sungero.RecordManagement.IReviewClerkNotificationState
  {
    public ReviewClerkNotificationState(global::Sungero.RecordManagement.IReviewClerkNotification entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IReviewClerkNotificationPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotificationPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IReviewClerkNotificationControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotificationControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IReviewClerkNotificationPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotificationPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IReviewClerkNotificationAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IReviewClerkNotificationAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ReviewClerkNotificationAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ReviewClerkNotificationAttachmentStates :
      global::Sungero.Workflow.Shared.NoticeAttachmentStates, global::Sungero.RecordManagement.IReviewClerkNotificationAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ResolutionGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("2f76847e-e2a7-4414-92fe-5cfa01b1d9ea"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("5320f83f-1364-4035-a7ab-44e457b9b388"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("4cee386f-c292-4735-af4c-3e2069c6b057"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentForReviewGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820"));
        }
      }


      protected internal ReviewClerkNotificationAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ReviewClerkNotificationControlStates : 
    global::Sungero.Workflow.Shared.NoticeControlStates, global::Sungero.RecordManagement.IReviewClerkNotificationControlStates
  {

    protected internal ReviewClerkNotificationControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ReviewClerkNotificationPageStates : 
    global::Sungero.Workflow.Shared.NoticePageStates, global::Sungero.RecordManagement.IReviewClerkNotificationPageStates
  {

    protected internal ReviewClerkNotificationPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ReviewClerkNotificationPropertyStates : 
    global::Sungero.Workflow.Shared.NoticePropertyStates, global::Sungero.RecordManagement.IReviewClerkNotificationPropertyStates
  {

    protected internal ReviewClerkNotificationPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ReviewClerkNotificationInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ReviewClerkNotificationInfo : 
    global::Sungero.Workflow.Shared.NoticeInfo, global::Sungero.RecordManagement.IReviewClerkNotificationInfo
  {
    public ReviewClerkNotificationInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IReviewClerkNotificationPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotificationPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationPropertiesInfo(entityType);
    }

  }

  public class ReviewClerkNotificationPropertiesInfo : 
    global::Sungero.Workflow.Shared.NoticePropertiesInfo, global::Sungero.RecordManagement.IReviewClerkNotificationPropertiesInfo
  {

    protected internal ReviewClerkNotificationPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ReviewClerkNotificationHandlers.g.cs
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
  public partial class ReviewClerkNotificationSharedHandlers : global::Sungero.Workflow.NoticeSharedHandlers, IReviewClerkNotificationSharedHandlers
  {
    private global::Sungero.RecordManagement.IReviewClerkNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotification)this.Entity; }
    }

    #region Workflow attachments extention

        public virtual void ResolutionGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void ResolutionGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ResolutionGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentForReviewGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentForReviewGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentForReviewGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ReviewClerkNotificationSharedHandlers(global::Sungero.RecordManagement.IReviewClerkNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewClerkNotificationResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ReviewClerkNotification
{
  /// <summary>
  /// Represents ReviewClerkNotification resources.
  /// </summary>
  public class ReviewClerkNotificationResources : global::Sungero.Workflow.Shared.Notice.NoticeResources, global::Sungero.RecordManagement.ReviewClerkNotification.IReviewClerkNotificationResources
  {
  }
}

// ==================================================================
// ReviewClerkNotificationSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ReviewClerkNotificationFunctions : global::Sungero.Workflow.Shared.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IReviewClerkNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewClerkNotification)this.Entity; }
    }

    public ReviewClerkNotificationFunctions(global::Sungero.RecordManagement.IReviewClerkNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewClerkNotificationFunctions.g.cs
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
  internal static class ReviewClerkNotification
  {
  }
}

// ==================================================================
// ReviewClerkNotificationFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ReviewClerkNotification
{

  public class ReviewClerkNotificationFilterInfo : global::Sungero.Workflow.Shared.Notice.NoticeFilterInfo,
    global::Sungero.RecordManagement.IReviewClerkNotificationFilterInfo
  {
  }

  public class ReviewClerkNotificationFilterState : global::Sungero.Workflow.Shared.Notice.NoticeFilterState,
    global::Sungero.RecordManagement.IReviewClerkNotificationFilterState
  {



    public new Sungero.RecordManagement.IReviewClerkNotificationFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IReviewClerkNotificationFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ReviewClerkNotification.ReviewClerkNotificationFilterInfo();
    }

  }
}

// ==================================================================
// ReviewClerkNotificationSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ReviewClerkNotificationSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IReviewClerkNotificationSharedPublicFunctions
  {
  }
}

// ==================================================================
// ReviewClerkNotificationAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{

  public class ReviewClerkNotificationResolutionGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewClerkNotificationResolutionGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTasks
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.RecordManagement.IActionItemExecutionTask>();
        } 
      }


    public ReviewClerkNotificationResolutionGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "2f76847e-e2a7-4414-92fe-5cfa01b1d9ea") { }
  }

  public class ReviewClerkNotificationAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewClerkNotificationAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewClerkNotificationAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "5320f83f-1364-4035-a7ab-44e457b9b388") { }
  }

  public class ReviewClerkNotificationOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewClerkNotificationOtherGroupAttachments
  {

    public ReviewClerkNotificationOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "4cee386f-c292-4735-af4c-3e2069c6b057") { }
  }

  public class ReviewClerkNotificationDocumentForReviewGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewClerkNotificationDocumentForReviewGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewClerkNotificationDocumentForReviewGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820") { }
  }

}

// ==================================================================
// ReviewClerkNotificationExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ReviewClerkNotification
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("443902d4-83db-485b-8b9c-af83507128d2"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V4 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(4, global::System.Guid.Parse("f2ab4250-9e59-4909-8e25-834b7153a59f"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V5 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(5, global::System.Guid.Parse("79c59dd3-941e-48bf-8a12-18f90fbfeaf9"));
}

    public static class TaskExtensions
    {
      /// <summary>
      /// Получить версию схемы запущенной задачи.
      /// </summary>
      /// <param name="task">Задача.</param>
      /// <returns>Версия схемы запущенной задачи.</returns>
      public static global::Sungero.Workflow.Shared.ExtendedSchemeVersion GetStartedSchemeVersion(this global::Sungero.Workflow.ITask task)
      {
        return global::Sungero.Workflow.Shared.OverriddenTaskHelper.FindLayerSchemeVersionForTask(task,
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"));
      }
    }

}
