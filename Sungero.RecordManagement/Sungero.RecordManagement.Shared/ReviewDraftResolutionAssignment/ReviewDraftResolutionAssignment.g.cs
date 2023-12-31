
// ==================================================================
// ReviewDraftResolutionAssignmentState.g.cs
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
  public class ReviewDraftResolutionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentState
  {
    public ReviewDraftResolutionAssignmentState(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ReviewDraftResolutionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ReviewDraftResolutionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ResolutionGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("2f76847e-e2a7-4414-92fe-5cfa01b1d9ea"));
        }
      }
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


      protected internal ReviewDraftResolutionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ReviewDraftResolutionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState DraftResolution
        {
        get { return this.GetControlState(global::System.Guid.Parse("5d181227-5764-417a-9695-31317efba7df")); }
        }


    protected internal ReviewDraftResolutionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ReviewDraftResolutionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPageStates
  {

    protected internal ReviewDraftResolutionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ReviewDraftResolutionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> NeedDeleteActionItems 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("NeedDeleteActionItems"); }
            }


    protected internal ReviewDraftResolutionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ReviewDraftResolutionAssignmentInfo.g.cs
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
  public class ReviewDraftResolutionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo
  {
    public ReviewDraftResolutionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentActionsInfo(entityType);
    }
  }

  public class ReviewDraftResolutionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo NeedDeleteActionItems 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("NeedDeleteActionItems");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }


    protected internal ReviewDraftResolutionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ReviewDraftResolutionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo ForExecution 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForExecution")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Informed 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Informed")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo AddResolution 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AddResolution")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Forward 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Forward")); }
        }


    protected internal ReviewDraftResolutionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentHandlers.g.cs
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
  public partial class ReviewDraftResolutionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IReviewDraftResolutionAssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }
    public virtual void AddresseeChanged(global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentAddresseeChangedEventArgs e) { }


    public virtual void NeedDeleteActionItemsChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void ResolutionGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ResolutionGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentForReviewGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentForReviewGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentForReviewGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ReviewDraftResolutionAssignmentSharedHandlers(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewDraftResolutionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignment
{
  /// <summary>
  /// Represents ReviewDraftResolutionAssignment resources.
  /// </summary>
  public class ReviewDraftResolutionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.ReviewDraftResolutionAssignment.IReviewDraftResolutionAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString NeedTextToRework
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewDraftResolutionAssignment) , "NeedTextToRework");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NeedTextToReworkFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewDraftResolutionAssignment), "NeedTextToRework", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ReworkResolution
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewDraftResolutionAssignment) , "ReworkResolution");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ReworkResolutionFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IReviewDraftResolutionAssignment), "ReworkResolution", false, args);
    }

  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ReviewDraftResolutionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public ReviewDraftResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentFunctions.g.cs
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
  internal static class ReviewDraftResolutionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment reviewDraftResolutionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("e2dd5bf3-54c8-4846-b158-9c42d09fbc33"),
          "GetStateView(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)"
          , reviewDraftResolutionAssignment);
      }

    }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignment
{

  public class ReviewDraftResolutionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterInfo
  {
  }

  public class ReviewDraftResolutionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState
  {



    public new Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignment.ReviewDraftResolutionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentSharedPublicFunctions.g.cs
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
  public class ReviewDraftResolutionAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IReviewDraftResolutionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentAttachmentGroups.g.cs
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

  public class ReviewDraftResolutionAssignmentResolutionGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentResolutionGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTasks
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.RecordManagement.IActionItemExecutionTask>();
        } 
      }


    public ReviewDraftResolutionAssignmentResolutionGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "2f76847e-e2a7-4414-92fe-5cfa01b1d9ea") { }
  }

  public class ReviewDraftResolutionAssignmentDocumentForReviewGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentDocumentForReviewGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewDraftResolutionAssignmentDocumentForReviewGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "88ec82fb-d8a8-4a36-a0d8-5c0bf42ff820") { }
  }

  public class ReviewDraftResolutionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ReviewDraftResolutionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "5320f83f-1364-4035-a7ab-44e457b9b388") { }
  }

  public class ReviewDraftResolutionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentOtherGroupAttachments
  {

    public ReviewDraftResolutionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "4cee386f-c292-4735-af4c-3e2069c6b057") { }
  }

}

// ==================================================================
// ReviewDraftResolutionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ReviewDraftResolutionAssignment
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
