
// ==================================================================
// ActionItemSupervisorNotificationState.g.cs
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
  public class ActionItemSupervisorNotificationState : 
    global::Sungero.Workflow.Shared.NoticeState, global::Sungero.RecordManagement.IActionItemSupervisorNotificationState
  {
    public ActionItemSupervisorNotificationState(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorNotificationPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IActionItemSupervisorNotificationControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotificationControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorNotificationControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IActionItemSupervisorNotificationPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotificationPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorNotificationPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IActionItemSupervisorNotificationAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotificationAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ActionItemSupervisorNotificationAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ActionItemSupervisorNotificationAttachmentStates :
      global::Sungero.Workflow.Shared.NoticeAttachmentStates, global::Sungero.RecordManagement.IActionItemSupervisorNotificationAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("d44a8df5-3fe9-4a1b-a5a0-e8aaa65820da"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentsGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("804f50fe-f3da-411b-bb2e-e5373936e029"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("13a98dcd-c5ec-4fd0-a682-424613f615d4"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ResultGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("6977b087-9b93-4527-9d0f-24d0e8b7ce88"));
        }
      }


      protected internal ActionItemSupervisorNotificationAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ActionItemSupervisorNotificationControlStates : 
    global::Sungero.Workflow.Shared.NoticeControlStates, global::Sungero.RecordManagement.IActionItemSupervisorNotificationControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("014f1265-8174-4a79-a253-c464e6de8696")); }
        }


    protected internal ActionItemSupervisorNotificationControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ActionItemSupervisorNotificationPageStates : 
    global::Sungero.Workflow.Shared.NoticePageStates, global::Sungero.RecordManagement.IActionItemSupervisorNotificationPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState State
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("State"); }
        }


    protected internal ActionItemSupervisorNotificationPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ActionItemSupervisorNotificationPropertyStates : 
    global::Sungero.Workflow.Shared.NoticePropertyStates, global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertyStates
  {

    protected internal ActionItemSupervisorNotificationPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ActionItemSupervisorNotificationInfo.g.cs
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
  public class ActionItemSupervisorNotificationInfo : 
    global::Sungero.Workflow.Shared.NoticeInfo, global::Sungero.RecordManagement.IActionItemSupervisorNotificationInfo
  {
    public ActionItemSupervisorNotificationInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemSupervisorNotificationPropertiesInfo(entityType);
    }

  }

  public class ActionItemSupervisorNotificationPropertiesInfo : 
    global::Sungero.Workflow.Shared.NoticePropertiesInfo, global::Sungero.RecordManagement.IActionItemSupervisorNotificationPropertiesInfo
  {

    protected internal ActionItemSupervisorNotificationPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ActionItemSupervisorNotificationHandlers.g.cs
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
  public partial class ActionItemSupervisorNotificationSharedHandlers : global::Sungero.Workflow.NoticeSharedHandlers, IActionItemSupervisorNotificationSharedHandlers
  {
    private global::Sungero.RecordManagement.IActionItemSupervisorNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotification)this.Entity; }
    }

    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentsGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentsGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentsGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void ResultGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void ResultGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ResultGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ActionItemSupervisorNotificationSharedHandlers(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ActionItemSupervisorNotificationResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ActionItemSupervisorNotification
{
  /// <summary>
  /// Represents ActionItemSupervisorNotification resources.
  /// </summary>
  public class ActionItemSupervisorNotificationResources : global::Sungero.Workflow.Shared.Notice.NoticeResources, global::Sungero.RecordManagement.ActionItemSupervisorNotification.IActionItemSupervisorNotificationResources
  {
  }
}

// ==================================================================
// ActionItemSupervisorNotificationSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ActionItemSupervisorNotificationFunctions : global::Sungero.Workflow.Shared.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IActionItemSupervisorNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotification)this.Entity; }
    }

    public ActionItemSupervisorNotificationFunctions(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemSupervisorNotificationFunctions.g.cs
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
  internal static class ActionItemSupervisorNotification
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemSupervisorNotificationFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IActionItemSupervisorNotification actionItemSupervisorNotification)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("da4946ab-6876-4bae-b35b-fc63e76974fd"),
          "GetStateView(global::Sungero.RecordManagement.IActionItemSupervisorNotification)"
          , actionItemSupervisorNotification);
      }

    }
  }
}

// ==================================================================
// ActionItemSupervisorNotificationFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ActionItemSupervisorNotification
{

  public class ActionItemSupervisorNotificationFilterInfo : global::Sungero.Workflow.Shared.Notice.NoticeFilterInfo,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationFilterInfo
  {
  }

  public class ActionItemSupervisorNotificationFilterState : global::Sungero.Workflow.Shared.Notice.NoticeFilterState,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationFilterState
  {



    public new Sungero.RecordManagement.IActionItemSupervisorNotificationFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IActionItemSupervisorNotificationFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ActionItemSupervisorNotification.ActionItemSupervisorNotificationFilterInfo();
    }

  }
}

// ==================================================================
// ActionItemSupervisorNotificationSharedPublicFunctions.g.cs
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
  public class ActionItemSupervisorNotificationSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IActionItemSupervisorNotificationSharedPublicFunctions
  {
  }
}

// ==================================================================
// ActionItemSupervisorNotificationAttachmentGroups.g.cs
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

  public class ActionItemSupervisorNotificationAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemSupervisorNotificationAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "d44a8df5-3fe9-4a1b-a5a0-e8aaa65820da") { }
  }

  public class ActionItemSupervisorNotificationDocumentsGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationDocumentsGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemSupervisorNotificationDocumentsGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "804f50fe-f3da-411b-bb2e-e5373936e029") { }
  }

  public class ActionItemSupervisorNotificationOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationOtherGroupAttachments
  {

    public ActionItemSupervisorNotificationOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "13a98dcd-c5ec-4fd0-a682-424613f615d4") { }
  }

  public class ActionItemSupervisorNotificationResultGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemSupervisorNotificationResultGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemSupervisorNotificationResultGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "6977b087-9b93-4527-9d0f-24d0e8b7ce88") { }
  }

}

// ==================================================================
// ActionItemSupervisorNotificationExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ActionItemSupervisorNotification
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V2 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(2, global::System.Guid.Parse("8590f64e-66d4-406b-9580-5e552631703d"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("3a0f3d16-d632-47a2-94fc-080db692e8c9"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V4 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(4, global::System.Guid.Parse("14e85e09-3118-4de5-a8fc-56fb5e641255"));
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
          global::System.Guid.Parse("c290b098-12c7-487d-bb38-73e2c98f9789"));
      }
    }

}
