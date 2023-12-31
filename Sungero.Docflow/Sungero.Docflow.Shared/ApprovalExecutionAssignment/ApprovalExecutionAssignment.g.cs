
// ==================================================================
// ApprovalExecutionAssignmentState.g.cs
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
  public class ApprovalExecutionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IApprovalExecutionAssignmentState
  {
    public ApprovalExecutionAssignmentState(global::Sungero.Docflow.IApprovalExecutionAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IApprovalExecutionAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IApprovalExecutionAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ApprovalExecutionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ApprovalExecutionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IApprovalExecutionAssignmentAttachmentStates
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


      protected internal ApprovalExecutionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ApprovalExecutionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IApprovalExecutionAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("4367c595-e8c6-4af1-8fe1-280a875c90c6")); }
        }


    protected internal ApprovalExecutionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ApprovalExecutionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IApprovalExecutionAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState StatusStages
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("StatusStages"); }
        }


    protected internal ApprovalExecutionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalExecutionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IApprovalExecutionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> Stage 
            {
              get { return this.InternalStage; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> InternalStage
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalStage>("Stage"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState ResolutionText 
            {
              get { return this.GetDataPropertyState("ResolutionText"); }
            }
            public global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe> CollapsedStagesTypesExe 
            {
              get { return this.GetPropertyState("CollapsedStagesTypesExe", this.CreateCollapsedStagesTypesExeState); }
            }

            protected virtual global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe> CreateCollapsedStagesTypesExeState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> StageNumber 
            {
              get { return this.GetPropertyState<global::System.Int32?>("StageNumber"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
            {
              get { return this.InternalDeliveryMethod; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> InternalDeliveryMethod
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMailDeliveryMethod>("DeliveryMethod"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IExchangeService> ExchangeService 
            {
              get { return this.InternalExchangeService; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IExchangeService> InternalExchangeService
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IExchangeService>("ExchangeService"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> DeliveryMethodDescription 
            {
              get { return this.GetPropertyState<global::System.String>("DeliveryMethodDescription"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> ReworkPerformer 
            {
              get { return this.InternalReworkPerformer; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalReworkPerformer
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("ReworkPerformer"); }
            }


    protected internal ApprovalExecutionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ApprovalExecutionAssignmentInfo.g.cs
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
  public class ApprovalExecutionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IApprovalExecutionAssignmentInfo
  {
    public ApprovalExecutionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentActionsInfo(entityType);
    }
  }

  public class ApprovalExecutionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IApprovalExecutionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage> Stage 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Stage");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo ResolutionText 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ResolutionText");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo> CollapsedStagesTypesExe 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("CollapsedStagesTypesExe");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo>(propertyMetadata);
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
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DeliveryMethod");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IExchangeServiceInfo, global::Sungero.ExchangeCore.IExchangeService> ExchangeService 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ExchangeService");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IExchangeServiceInfo, global::Sungero.ExchangeCore.IExchangeService>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo DeliveryMethodDescription 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("DeliveryMethodDescription");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
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


    protected internal ApprovalExecutionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ApprovalExecutionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IApprovalExecutionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateActionItem 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateActionItem")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendViaExchangeService 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendViaExchangeService")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateAcquaintance 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateAcquaintance")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendByMail 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendByMail")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForRevision 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRevision")); }
        }


    protected internal ApprovalExecutionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ApprovalExecutionAssignmentHandlers.g.cs
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
  public partial class ApprovalExecutionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IApprovalExecutionAssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalExecutionAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignment)this.Entity; }
    }
    public virtual void StageChanged(global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentStageChangedEventArgs e) { }


    public virtual void ResolutionTextChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void CollapsedStagesTypesExeChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void StageNumberChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }




    public virtual void DeliveryMethodDescriptionChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ReworkPerformerChanged(global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentReworkPerformerChangedEventArgs e) { }



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

    public ApprovalExecutionAssignmentSharedHandlers(global::Sungero.Docflow.IApprovalExecutionAssignment entity) : base(entity)
    {
    }
  }

  public partial class ApprovalExecutionAssignmentCollapsedStagesTypesExeSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IApprovalExecutionAssignmentCollapsedStagesTypesExeSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe _obj
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe)this.Entity; }
    }
    public virtual void CollapsedStagesTypesExeStageTypeChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }



    public ApprovalExecutionAssignmentCollapsedStagesTypesExeSharedHandlers(global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe entity) : base(entity)
    {
    }
  }

  public partial class ApprovalExecutionAssignmentCollapsedStagesTypesExeSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Docflow.IApprovalExecutionAssignment _obj
    { 
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignment)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe _added
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe)this._Added; }
    }

    private global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe _deleted
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe)this._Deleted; }
    }

    private global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe _source
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe)this._Source; }
    }

    public virtual void CollapsedStagesTypesExeAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void CollapsedStagesTypesExeDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public ApprovalExecutionAssignmentCollapsedStagesTypesExeSharedCollectionHandlers(global::Sungero.Docflow.IApprovalExecutionAssignment entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// ApprovalExecutionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ApprovalExecutionAssignment
{
  /// <summary>
  /// Represents ApprovalExecutionAssignment resources.
  /// </summary>
  public class ApprovalExecutionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.ApprovalExecutionAssignment.IApprovalExecutionAssignmentResources
  {
  }
}

// ==================================================================
// ApprovalExecutionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ApprovalExecutionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalExecutionAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignment)this.Entity; }
    }

    public ApprovalExecutionAssignmentFunctions(global::Sungero.Docflow.IApprovalExecutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalExecutionAssignmentFunctions.g.cs
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
  internal static class ApprovalExecutionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalExecutionAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalExecutionAssignment approvalExecutionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("495600a5-5f7a-49aa-ac49-9351c9af1109"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalExecutionAssignment)"
          , approvalExecutionAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalExecutionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ApprovalExecutionAssignment
{

  public class ApprovalExecutionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IApprovalExecutionAssignmentFilterInfo
  {
  }

  public class ApprovalExecutionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IApprovalExecutionAssignmentFilterState
  {



    public new Sungero.Docflow.IApprovalExecutionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IApprovalExecutionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ApprovalExecutionAssignment.ApprovalExecutionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ApprovalExecutionAssignmentSharedPublicFunctions.g.cs
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
  public class ApprovalExecutionAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IApprovalExecutionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalExecutionAssignmentAttachmentGroups.g.cs
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

  public class ApprovalExecutionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalExecutionAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalExecutionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "852b3e7d-f178-47d3-8fad-a64021065cfd") { }
  }

  public class ApprovalExecutionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalExecutionAssignmentOtherGroupAttachments
  {

    public ApprovalExecutionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "bd87e6b5-e247-485a-93bf-52f24a64af5a") { }
  }

  public class ApprovalExecutionAssignmentDocumentGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalExecutionAssignmentDocumentGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalExecutionAssignmentDocumentGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "08e1ef90-521f-41a1-a13f-c6f175007e54") { }
  }

}

// ==================================================================
// ApprovalExecutionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.ApprovalExecutionAssignment
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
