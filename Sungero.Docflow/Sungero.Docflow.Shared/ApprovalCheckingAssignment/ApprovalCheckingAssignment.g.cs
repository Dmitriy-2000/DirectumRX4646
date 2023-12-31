
// ==================================================================
// ApprovalCheckingAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalCheckingAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IApprovalCheckingAssignmentState
  {
    public ApprovalCheckingAssignmentState(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IApprovalCheckingAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IApprovalCheckingAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ApprovalCheckingAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ApprovalCheckingAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IApprovalCheckingAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("852b3e7d-f178-47d3-8fad-a64021065cfd"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("bd87e6b5-e247-485a-93bf-52f24a64af5a"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("08e1ef90-521f-41a1-a13f-c6f175007e54"));
        }
      }


      protected internal ApprovalCheckingAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ApprovalCheckingAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IApprovalCheckingAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("6a3e30b0-6c3e-4dda-a19b-cb2ab6b0fff9")); }
        }


    protected internal ApprovalCheckingAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ApprovalCheckingAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IApprovalCheckingAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState StatusStages
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("StatusStages"); }
        }


    protected internal ApprovalCheckingAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalCheckingAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IApprovalCheckingAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> StageSubject 
            {
              get { return this.GetPropertyState<global::System.String>("StageSubject"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> StageNumber 
            {
              get { return this.GetPropertyState<global::System.Int32?>("StageNumber"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> ReworkPerformer 
            {
              get { return this.InternalReworkPerformer; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalReworkPerformer
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("ReworkPerformer"); }
            }


    protected internal ApprovalCheckingAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalCheckingAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IApprovalCheckingAssignmentInfo
  {
    public ApprovalCheckingAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentActionsInfo(entityType);
    }
  }

  public class ApprovalCheckingAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IApprovalCheckingAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo StageSubject 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("StageSubject");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo StageNumber 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("StageNumber");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> ReworkPerformer 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ReworkPerformer");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }


    protected internal ApprovalCheckingAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ApprovalCheckingAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IApprovalCheckingAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Accept 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Accept")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForRework 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRework")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }


    protected internal ApprovalCheckingAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentHandlers.g.cs
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
  public partial class ApprovalCheckingAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IApprovalCheckingAssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }
    public virtual void StageSubjectChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void StageNumberChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void ReworkPerformerChanged(global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentReworkPerformerChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ApprovalCheckingAssignmentSharedHandlers(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ApprovalCheckingAssignment
{
  /// <summary>
  /// Represents ApprovalCheckingAssignment resources.
  /// </summary>
  public class ApprovalCheckingAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.ApprovalCheckingAssignment.IApprovalCheckingAssignmentResources
  {
  }
}

// ==================================================================
// ApprovalCheckingAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ApprovalCheckingAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public ApprovalCheckingAssignmentFunctions(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentFunctions.g.cs
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
  internal static class ApprovalCheckingAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalCheckingAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalCheckingAssignment approvalCheckingAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("c09f0ae4-c959-4a57-9895-ae9aaf1f1855"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalCheckingAssignment)"
          , approvalCheckingAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ApprovalCheckingAssignment
{

  public class ApprovalCheckingAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IApprovalCheckingAssignmentFilterInfo
  {
  }

  public class ApprovalCheckingAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState
  {



    public new Sungero.Docflow.IApprovalCheckingAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IApprovalCheckingAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ApprovalCheckingAssignment.ApprovalCheckingAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ApprovalCheckingAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalCheckingAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IApprovalCheckingAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalCheckingAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{

  public class ApprovalCheckingAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalCheckingAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalCheckingAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "852b3e7d-f178-47d3-8fad-a64021065cfd") { }
  }

  public class ApprovalCheckingAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalCheckingAssignmentOtherGroupAttachments
  {

    public ApprovalCheckingAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "bd87e6b5-e247-485a-93bf-52f24a64af5a") { }
  }

  public class ApprovalCheckingAssignmentDocumentGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalCheckingAssignmentDocumentGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalCheckingAssignmentDocumentGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "08e1ef90-521f-41a1-a13f-c6f175007e54") { }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.ApprovalCheckingAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V2 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(2, global::System.Guid.Parse("5d0fc175-90d1-403e-8925-56540910cc8c"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("a74b50c6-c2b5-432c-97bb-468af776c4da"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V4 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(4, global::System.Guid.Parse("9b47647d-edd2-4852-a5ff-94ad69ae237a"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V5 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(5, global::System.Guid.Parse("8b22b7a1-cf3f-4ffd-9ec0-98dbb98740e3"));
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
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"));
      }
    }

}
