
// ==================================================================
// ApprovalManagerAssignmentAddresseesState.g.cs
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
  public class ApprovalManagerAssignmentAddresseesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesState
  {
    public ApprovalManagerAssignmentAddresseesState(global::Sungero.Docflow.IApprovalManagerAssignmentAddressees entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddresseesPropertyStates(entity);
    }


  }


  public class ApprovalManagerAssignmentAddresseesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalManagerAssignment> ApprovalManagerAssignment 
            {
              get { return this.InternalApprovalManagerAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalManagerAssignment> InternalApprovalManagerAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalManagerAssignment>("ApprovalManagerAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }


    protected internal ApprovalManagerAssignmentAddresseesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalManagerAssignmentAddresseesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalManagerAssignmentAddressees
  {
    public new global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddresseesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalManagerAssignmentAddresseesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalManagerAssignmentAddresseesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalManagerAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalManagerAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Addressee
        {
          get { return this.GetChildPropertySummaryState("Addressee"); }
        }


    protected internal ApprovalManagerAssignmentAddresseesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalManagerAssignmentAddresseesInfo.g.cs
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
  public class ApprovalManagerAssignmentAddresseesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesInfo
  {
    public ApprovalManagerAssignmentAddresseesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddresseesPropertiesInfo(entityType);
    }

  }

  public class ApprovalManagerAssignmentAddresseesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalManagerAssignmentAddresseesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalManagerAssignmentInfo, global::Sungero.Docflow.IApprovalManagerAssignment> ApprovalManagerAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalManagerAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalManagerAssignmentInfo, global::Sungero.Docflow.IApprovalManagerAssignment>(propertyMetadata);
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


    protected internal ApprovalManagerAssignmentAddresseesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
