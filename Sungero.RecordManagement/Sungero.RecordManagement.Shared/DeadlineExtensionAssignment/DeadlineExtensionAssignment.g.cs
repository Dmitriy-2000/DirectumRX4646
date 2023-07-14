
// ==================================================================
// DeadlineExtensionAssignmentState.g.cs
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
  public class DeadlineExtensionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentState
  {
    public DeadlineExtensionAssignmentState(global::Sungero.RecordManagement.IDeadlineExtensionAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new DeadlineExtensionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class DeadlineExtensionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("40dc1024-52c0-4a37-bd51-eb03d9b963e3"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentsGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("431d8004-a022-415b-b622-917af0d570bb"));
        }
      }


      protected internal DeadlineExtensionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class DeadlineExtensionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("2105456e-0abf-44bf-8ac6-502747566d8d")); }
        }


    protected internal DeadlineExtensionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DeadlineExtensionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState State
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("State"); }
        }


    protected internal DeadlineExtensionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DeadlineExtensionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> ScheduledDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("ScheduledDate"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Reason 
            {
              get { return this.GetDataPropertyState("Reason"); }
            }


    protected internal DeadlineExtensionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DeadlineExtensionAssignmentInfo.g.cs
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
  public class DeadlineExtensionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentInfo
  {
    public DeadlineExtensionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentActionsInfo(entityType);
    }
  }

  public class DeadlineExtensionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NewDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NewDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo ScheduledDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("ScheduledDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo Reason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("Reason");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }


    protected internal DeadlineExtensionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class DeadlineExtensionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IDeadlineExtensionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Accept 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Accept")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForRework 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRework")); }
        }


    protected internal DeadlineExtensionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentHandlers.g.cs
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
  public partial class DeadlineExtensionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IDeadlineExtensionAssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignment)this.Entity; }
    }
    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void ScheduledDateChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void ReasonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentsGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentsGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentsGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public DeadlineExtensionAssignmentSharedHandlers(global::Sungero.RecordManagement.IDeadlineExtensionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.DeadlineExtensionAssignment
{
  /// <summary>
  /// Represents DeadlineExtensionAssignment resources.
  /// </summary>
  public class DeadlineExtensionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.DeadlineExtensionAssignment.IDeadlineExtensionAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString RefusalReasonNotFilled
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment) , "RefusalReasonNotFilled");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RefusalReasonNotFilledFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment), "RefusalReasonNotFilled", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Denied
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment) , "Denied");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeniedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment), "Denied", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeadlineExtended
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment) , "DeadlineExtended");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeadlineExtendedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionAssignment), "DeadlineExtended", false, args);
    }

  }
}

// ==================================================================
// DeadlineExtensionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class DeadlineExtensionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignment)this.Entity; }
    }

    public DeadlineExtensionAssignmentFunctions(global::Sungero.RecordManagement.IDeadlineExtensionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentFunctions.g.cs
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
  internal static class DeadlineExtensionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineExtensionAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionAssignment deadlineExtensionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("8a5b9f7b-0c69-455f-95b2-8b525b4e7bb1"),
          "GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionAssignment)"
          , deadlineExtensionAssignment);
      }

    }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.DeadlineExtensionAssignment
{

  public class DeadlineExtensionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IDeadlineExtensionAssignmentFilterInfo
  {
  }

  public class DeadlineExtensionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IDeadlineExtensionAssignmentFilterState
  {



    public new Sungero.RecordManagement.IDeadlineExtensionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IDeadlineExtensionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.DeadlineExtensionAssignment.DeadlineExtensionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// DeadlineExtensionAssignmentSharedPublicFunctions.g.cs
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
  public class DeadlineExtensionAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IDeadlineExtensionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineExtensionAssignmentAttachmentGroups.g.cs
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

  public class DeadlineExtensionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAddendaGroupAttachments
  {

    public DeadlineExtensionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "40dc1024-52c0-4a37-bd51-eb03d9b963e3") { }
  }

  public class DeadlineExtensionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionAssignmentOtherGroupAttachments
  {

    public DeadlineExtensionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7") { }
  }

  public class DeadlineExtensionAssignmentDocumentsGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionAssignmentDocumentsGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public DeadlineExtensionAssignmentDocumentsGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "431d8004-a022-415b-b622-917af0d570bb") { }
  }

}

// ==================================================================
// DeadlineExtensionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.DeadlineExtensionAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
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
          global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f"));
      }
    }

}
