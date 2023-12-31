
// ==================================================================
// ReceiptNotificationSendingAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class ReceiptNotificationSendingAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentState
  {
    public ReceiptNotificationSendingAssignmentState(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity) : base(entity) { }

    public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentControlStates Controls
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentControlStates(entity);
    }

    public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPageStates Pages
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAttachmentStates Attachments { get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ReceiptNotificationSendingAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ReceiptNotificationSendingAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAttachmentStates
    {

      protected internal ReceiptNotificationSendingAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ReceiptNotificationSendingAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentControlStates
  {

    protected internal ReceiptNotificationSendingAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ReceiptNotificationSendingAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPageStates
  {

    protected internal ReceiptNotificationSendingAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ReceiptNotificationSendingAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> Box 
            {
              get { return this.InternalBox; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> InternalBox
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox>("Box"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }


    protected internal ReceiptNotificationSendingAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ReceiptNotificationSendingAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class ReceiptNotificationSendingAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo
  {
    public ReceiptNotificationSendingAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentActionsInfo(entityType);
    }
  }

  public class ReceiptNotificationSendingAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox> Box 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Box");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NewDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NewDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }


    protected internal ReceiptNotificationSendingAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ReceiptNotificationSendingAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ShowDocuments 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowDocuments")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Forwarded 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Forwarded")); }
        }


    protected internal ReceiptNotificationSendingAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{
  public partial class ReceiptNotificationSendingAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IReceiptNotificationSendingAssignmentSharedHandlers
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }
    public virtual void BoxChanged(global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentBoxChangedEventArgs e) { }


    public virtual void AddresseeChanged(global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentAddresseeChangedEventArgs e) { }


    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }



    #region Workflow attachments extention


    #endregion

    public ReceiptNotificationSendingAssignmentSharedHandlers(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReceiptNotificationSendingAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared.ReceiptNotificationSendingAssignment
{
  /// <summary>
  /// Represents ReceiptNotificationSendingAssignment resources.
  /// </summary>
  public class ReceiptNotificationSendingAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Exchange.ReceiptNotificationSendingAssignment.IReceiptNotificationSendingAssignmentResources
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Exchange.Shared
{
  public partial class ReceiptNotificationSendingAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }

    public ReceiptNotificationSendingAssignmentFunctions(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Functions
{
  internal static class ReceiptNotificationSendingAssignment
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Exchange.Shared.ReceiptNotificationSendingAssignment
{

  public class ReceiptNotificationSendingAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterInfo
  {
  }

  public class ReceiptNotificationSendingAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState
  {



    public new Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Exchange.Shared.ReceiptNotificationSendingAssignment.ReceiptNotificationSendingAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class ReceiptNotificationSendingAssignmentSharedPublicFunctions : global::Sungero.Exchange.Shared.IReceiptNotificationSendingAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
}

// ==================================================================
// ReceiptNotificationSendingAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.ReceiptNotificationSendingAssignment
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
          global::System.Guid.Parse("490e66a0-8618-4eb9-aab8-2dbc8a884d98"));
      }
    }

}
