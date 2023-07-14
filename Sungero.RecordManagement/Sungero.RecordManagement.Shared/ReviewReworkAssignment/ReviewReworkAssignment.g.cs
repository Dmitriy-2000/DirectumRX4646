
// ==================================================================
// ReviewReworkAssignmentState.g.cs
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
  public class ReviewReworkAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IReviewReworkAssignmentState
  {
    public ReviewReworkAssignmentState(global::Sungero.RecordManagement.IReviewReworkAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IReviewReworkAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IReviewReworkAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ReviewReworkAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ReviewReworkAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IReviewReworkAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentForReviewGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820"));
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
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ResolutionGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("2f76847e-e2a7-4414-92fe-5cfa01b1d9ea"));
        }
      }


      protected internal ReviewReworkAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ReviewReworkAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IReviewReworkAssignmentControlStates
  {

    protected internal ReviewReworkAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ReviewReworkAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IReviewReworkAssignmentPageStates
  {

    protected internal ReviewReworkAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ReviewReworkAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IReviewReworkAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }


    protected internal ReviewReworkAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ReviewReworkAssignmentInfo.g.cs
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
  public class ReviewReworkAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IReviewReworkAssignmentInfo
  {
    public ReviewReworkAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IReviewReworkAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentActionsInfo(entityType);
    }
  }

  public class ReviewReworkAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IReviewReworkAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }


    protected internal ReviewReworkAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ReviewReworkAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IReviewReworkAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo SendForReview 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendForReview")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Abort 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Abort")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Forward 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Forward")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo AddResolution 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AddResolution")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo PrintResolution 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("PrintResolution")); }
        }


    protected internal ReviewReworkAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ReviewReworkAssignmentHandlers.g.cs
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
  public partial class ReviewReworkAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IReviewReworkAssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IReviewReworkAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignment)this.Entity; }
    }
    public virtual void AddresseeChanged(global::Sungero.RecordManagement.Shared.ReviewReworkAssignmentAddresseeChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void DocumentForReviewGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentForReviewGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentForReviewGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void ResolutionGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ReviewReworkAssignmentSharedHandlers(global::Sungero.RecordManagement.IReviewReworkAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewReworkAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ReviewReworkAssignment
{
  /// <summary>
  /// Represents ReviewReworkAssignment resources.
  /// </summary>
  public class ReviewReworkAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.ReviewReworkAssignment.IReviewReworkAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString ConfirmDeleteDraftResolutionAssignment
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewReworkAssignment) , "ConfirmDeleteDraftResolutionAssignment");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ConfirmDeleteDraftResolutionAssignmentFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewReworkAssignment), "ConfirmDeleteDraftResolutionAssignment", false, args);
    }

  }
}

// ==================================================================
// ReviewReworkAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ReviewReworkAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewReworkAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewReworkAssignment)this.Entity; }
    }

    public ReviewReworkAssignmentFunctions(global::Sungero.RecordManagement.IReviewReworkAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewReworkAssignmentFunctions.g.cs
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
  internal static class ReviewReworkAssignment
  {
  }
}

// ==================================================================
// ReviewReworkAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ReviewReworkAssignment
{

  public class ReviewReworkAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IReviewReworkAssignmentFilterInfo
  {
  }

  public class ReviewReworkAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IReviewReworkAssignmentFilterState
  {



    public new Sungero.RecordManagement.IReviewReworkAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IReviewReworkAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ReviewReworkAssignment.ReviewReworkAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ReviewReworkAssignmentSharedPublicFunctions.g.cs
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
  public class ReviewReworkAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IReviewReworkAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ReviewReworkAssignmentAttachmentGroups.g.cs
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

  public class ReviewReworkAssignmentDocumentForReviewGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewReworkAssignmentDocumentForReviewGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewReworkAssignmentDocumentForReviewGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820") { }
  }

  public class ReviewReworkAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewReworkAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewReworkAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "5320f83f-1364-4035-a7ab-44e457b9b388") { }
  }

  public class ReviewReworkAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewReworkAssignmentOtherGroupAttachments
  {

    public ReviewReworkAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "4cee386f-c292-4735-af4c-3e2069c6b057") { }
  }

  public class ReviewReworkAssignmentResolutionGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewReworkAssignmentResolutionGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTasks
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.RecordManagement.IActionItemExecutionTask>();
        } 
      }


    public ReviewReworkAssignmentResolutionGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "2f76847e-e2a7-4414-92fe-5cfa01b1d9ea") { }
  }

}

// ==================================================================
// ReviewReworkAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ReviewReworkAssignment
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