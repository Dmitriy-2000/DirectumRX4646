
// ==================================================================
// ApprovalPrintingAssignmentCollapsedStagesTypesPrState.g.cs
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
  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrState
  {
    public ApprovalPrintingAssignmentCollapsedStagesTypesPrState(global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPr entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates(entity);
    }


  }


  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalPrintingAssignment> ApprovalPrintingAssignment 
            {
              get { return this.InternalApprovalPrintingAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalPrintingAssignment> InternalApprovalPrintingAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalPrintingAssignment>("ApprovalPrintingAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> StageType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("StageType"); }
            }


    protected internal ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPr
  {
    public new global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalPrintingAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalPrintingAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState StageType
        {
          get { return this.GetChildPropertySummaryState("StageType"); }
        }


    protected internal ApprovalPrintingAssignmentCollapsedStagesTypesPrCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalPrintingAssignmentCollapsedStagesTypesPrInfo.g.cs
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
  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrInfo
  {
    public ApprovalPrintingAssignmentCollapsedStagesTypesPrInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo(entityType);
    }

  }

  public class ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalPrintingAssignmentInfo, global::Sungero.Docflow.IApprovalPrintingAssignment> ApprovalPrintingAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalPrintingAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalPrintingAssignmentInfo, global::Sungero.Docflow.IApprovalPrintingAssignment>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo StageType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("StageType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal ApprovalPrintingAssignmentCollapsedStagesTypesPrPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
