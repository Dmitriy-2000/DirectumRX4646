
// ==================================================================
// ReviewResolutionAssignmentState.g.cs
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
  public class ReviewResolutionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IReviewResolutionAssignmentState
  {
    public ReviewResolutionAssignmentState(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IReviewResolutionAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ReviewResolutionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ReviewResolutionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IReviewResolutionAssignmentAttachmentStates
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


      protected internal ReviewResolutionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ReviewResolutionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IReviewResolutionAssignmentControlStates
  {

    protected internal ReviewResolutionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ReviewResolutionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IReviewResolutionAssignmentPageStates
  {

    protected internal ReviewResolutionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ReviewResolutionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IDataPropertyState ResolutionText 
            {
              get { return this.GetDataPropertyState("ResolutionText"); }
            }


    protected internal ReviewResolutionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ReviewResolutionAssignmentInfo.g.cs
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
  public class ReviewResolutionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo
  {
    public ReviewResolutionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IReviewResolutionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentActionsInfo(entityType);
    }
  }

  public class ReviewResolutionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IReviewResolutionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.ITextPropertyInfo ResolutionText 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ResolutionText");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }


    protected internal ReviewResolutionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ReviewResolutionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IReviewResolutionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo AddAssignment 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AddAssignment")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateActionItem 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateActionItem")); }
        }


    protected internal ReviewResolutionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentHandlers.g.cs
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
  public partial class ReviewResolutionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IReviewResolutionAssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }
    public virtual void ResolutionTextChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }



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

    public ReviewResolutionAssignmentSharedHandlers(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewResolutionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ReviewResolutionAssignment
{
  /// <summary>
  /// Represents ReviewResolutionAssignment resources.
  /// </summary>
  public class ReviewResolutionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.ReviewResolutionAssignment.IReviewResolutionAssignmentResources
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ReviewResolutionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }

    public ReviewResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentFunctions.g.cs
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
  internal static class ReviewResolutionAssignment
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ReviewResolutionAssignment
{

  public class ReviewResolutionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterInfo
  {
  }

  public class ReviewResolutionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState
  {



    public new Sungero.RecordManagement.IReviewResolutionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IReviewResolutionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ReviewResolutionAssignment.ReviewResolutionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ReviewResolutionAssignmentSharedPublicFunctions.g.cs
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
  public class ReviewResolutionAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IReviewResolutionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentAttachmentGroups.g.cs
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

  public class ReviewResolutionAssignmentResolutionGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentResolutionGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTasks
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.RecordManagement.IActionItemExecutionTask>();
        } 
      }


    public ReviewResolutionAssignmentResolutionGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "2f76847e-e2a7-4414-92fe-5cfa01b1d9ea") { }
  }

  public class ReviewResolutionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewResolutionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "5320f83f-1364-4035-a7ab-44e457b9b388") { }
  }

  public class ReviewResolutionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentOtherGroupAttachments
  {

    public ReviewResolutionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "4cee386f-c292-4735-af4c-3e2069c6b057") { }
  }

  public class ReviewResolutionAssignmentDocumentForReviewGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewResolutionAssignmentDocumentForReviewGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewResolutionAssignmentDocumentForReviewGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820") { }
  }

}

// ==================================================================
// ReviewResolutionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ReviewResolutionAssignment
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
