
// ==================================================================
// ApprovalSigningAssignmentCollapsedStagesTypesSigState.g.cs
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
  public class ApprovalSigningAssignmentCollapsedStagesTypesSigState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigState
  {
    public ApprovalSigningAssignmentCollapsedStagesTypesSigState(global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates(entity);
    }


  }


  public class ApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalSigningAssignment> ApprovalSigningAssignment 
            {
              get { return this.InternalApprovalSigningAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalSigningAssignment> InternalApprovalSigningAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalSigningAssignment>("ApprovalSigningAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> StageType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("StageType"); }
            }


    protected internal ApprovalSigningAssignmentCollapsedStagesTypesSigPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig
  {
    public new global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalSigningAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalSigningAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState StageType
        {
          get { return this.GetChildPropertySummaryState("StageType"); }
        }


    protected internal ApprovalSigningAssignmentCollapsedStagesTypesSigCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalSigningAssignmentCollapsedStagesTypesSigInfo.g.cs
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
  public class ApprovalSigningAssignmentCollapsedStagesTypesSigInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigInfo
  {
    public ApprovalSigningAssignmentCollapsedStagesTypesSigInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo(entityType);
    }

  }

  public class ApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalSigningAssignmentInfo, global::Sungero.Docflow.IApprovalSigningAssignment> ApprovalSigningAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalSigningAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalSigningAssignmentInfo, global::Sungero.Docflow.IApprovalSigningAssignment>(propertyMetadata);
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


    protected internal ApprovalSigningAssignmentCollapsedStagesTypesSigPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
