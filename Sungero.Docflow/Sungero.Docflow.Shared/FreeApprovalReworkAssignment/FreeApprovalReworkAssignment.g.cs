
// ==================================================================
// FreeApprovalReworkAssignmentState.g.cs
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
  public class FreeApprovalReworkAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IFreeApprovalReworkAssignmentState
  {
    public FreeApprovalReworkAssignmentState(global::Sungero.Docflow.IFreeApprovalReworkAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IFreeApprovalReworkAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IFreeApprovalReworkAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IFreeApprovalReworkAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new FreeApprovalReworkAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class FreeApprovalReworkAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IFreeApprovalReworkAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("fe0d933f-02f8-4733-b110-1e49467a9cf8"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("698df64c-b849-4786-ae93-19a1f086a2a8"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ForApprovalGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("cd77936e-884e-44bb-b869-9a60f9f5f2b4"));
        }
      }


      protected internal FreeApprovalReworkAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class FreeApprovalReworkAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IFreeApprovalReworkAssignmentControlStates
  {

    protected internal FreeApprovalReworkAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class FreeApprovalReworkAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IFreeApprovalReworkAssignmentPageStates
  {

    protected internal FreeApprovalReworkAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class FreeApprovalReworkAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }
            public global::Sungero.Docflow.IFreeApprovalReworkAssignmentApproversCollectionPropertyState<global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers> Approvers 
            {
              get { return this.GetPropertyState("Approvers", this.CreateApproversState); }
            }

            protected virtual global::Sungero.Docflow.IFreeApprovalReworkAssignmentApproversCollectionPropertyState<global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers> CreateApproversState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentApproversCollectionPropertyState<global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers>(entity, propertyName);
            }


    protected internal FreeApprovalReworkAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// FreeApprovalReworkAssignmentInfo.g.cs
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
  public class FreeApprovalReworkAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IFreeApprovalReworkAssignmentInfo
  {
    public FreeApprovalReworkAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IFreeApprovalReworkAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentActionsInfo(entityType);
    }
  }

  public class FreeApprovalReworkAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IFreeApprovalReworkAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NewDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NewDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IFreeApprovalReworkAssignmentApproversPropertiesInfo> Approvers 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Approvers");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IFreeApprovalReworkAssignmentApproversPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal FreeApprovalReworkAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class FreeApprovalReworkAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IFreeApprovalReworkAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Reworked 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Reworked")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo AbortAction 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AbortAction")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }


    protected internal FreeApprovalReworkAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// FreeApprovalReworkAssignmentHandlers.g.cs
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
  public partial class FreeApprovalReworkAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IFreeApprovalReworkAssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalReworkAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignment)this.Entity; }
    }
    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void ApproversChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void ForApprovalGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void ForApprovalGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ForApprovalGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public FreeApprovalReworkAssignmentSharedHandlers(global::Sungero.Docflow.IFreeApprovalReworkAssignment entity) : base(entity)
    {
    }
  }

  public partial class FreeApprovalReworkAssignmentApproversSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IFreeApprovalReworkAssignmentApproversSharedHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers)this.Entity; }
    }
    public virtual void ApproversApproverChanged(global::Sungero.Docflow.Shared.FreeApprovalReworkAssignmentApproversApproverChangedEventArgs e) { }


    public virtual void ApproversApprovedChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void ApproversActionChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }



    public FreeApprovalReworkAssignmentApproversSharedHandlers(global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers entity) : base(entity)
    {
    }
  }

  public partial class FreeApprovalReworkAssignmentApproversSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalReworkAssignment _obj
    { 
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignment)this.Entity; }
    }

    private global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers _added
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers)this._Added; }
    }

    private global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers _deleted
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers)this._Deleted; }
    }

    private global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers _source
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignmentApprovers)this._Source; }
    }

    public virtual void ApproversDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public FreeApprovalReworkAssignmentApproversSharedCollectionHandlers(global::Sungero.Docflow.IFreeApprovalReworkAssignment entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// FreeApprovalReworkAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.FreeApprovalReworkAssignment
{
  /// <summary>
  /// Represents FreeApprovalReworkAssignment resources.
  /// </summary>
  public class FreeApprovalReworkAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.FreeApprovalReworkAssignment.IFreeApprovalReworkAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString Enum_Operation_DeadlineExtend
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalReworkAssignment) , "Enum_Operation_DeadlineExtend");
      }
    }

    public virtual global::CommonLibrary.LocalizedString Enum_Operation_DeadlineExtendFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalReworkAssignment), "Enum_Operation_DeadlineExtend", false, args);
    }

  }
}

// ==================================================================
// FreeApprovalReworkAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class FreeApprovalReworkAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalReworkAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalReworkAssignment)this.Entity; }
    }

    public FreeApprovalReworkAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalReworkAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalReworkAssignmentFunctions.g.cs
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
  internal static class FreeApprovalReworkAssignment
  {
  }
}

// ==================================================================
// FreeApprovalReworkAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.FreeApprovalReworkAssignment
{

  public class FreeApprovalReworkAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IFreeApprovalReworkAssignmentFilterInfo
  {
  }

  public class FreeApprovalReworkAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IFreeApprovalReworkAssignmentFilterState
  {



    public new Sungero.Docflow.IFreeApprovalReworkAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IFreeApprovalReworkAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.FreeApprovalReworkAssignment.FreeApprovalReworkAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// FreeApprovalReworkAssignmentSharedPublicFunctions.g.cs
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
  public class FreeApprovalReworkAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IFreeApprovalReworkAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalReworkAssignmentAttachmentGroups.g.cs
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

  public class FreeApprovalReworkAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalReworkAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalReworkAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "fe0d933f-02f8-4733-b110-1e49467a9cf8") { }
  }

  public class FreeApprovalReworkAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalReworkAssignmentOtherGroupAttachments
  {

    public FreeApprovalReworkAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "698df64c-b849-4786-ae93-19a1f086a2a8") { }
  }

  public class FreeApprovalReworkAssignmentForApprovalGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalReworkAssignmentForApprovalGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalReworkAssignmentForApprovalGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "cd77936e-884e-44bb-b869-9a60f9f5f2b4") { }
  }

}

// ==================================================================
// FreeApprovalReworkAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.FreeApprovalReworkAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V2 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(2, global::System.Guid.Parse("7ce6852c-2346-4ea5-86d4-bdac0b1902d0"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("b87fbd2e-278a-439c-a10a-716de8bd84bf"));
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
          global::System.Guid.Parse("77f43035-9f23-4a19-9882-5a6a2cd5c9c7"));
      }
    }

}
