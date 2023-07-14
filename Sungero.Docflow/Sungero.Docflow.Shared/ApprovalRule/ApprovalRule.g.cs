
// ==================================================================
// ApprovalRuleState.g.cs
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
  public class ApprovalRuleState : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseState, global::Sungero.Docflow.IApprovalRuleState
  {
    public ApprovalRuleState(global::Sungero.Docflow.IApprovalRule entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRulePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRulePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRulePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IApprovalRuleControlStates Controls
    {
      get { return (global::Sungero.Docflow.IApprovalRuleControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleControlStates(entity);
    }

    public new global::Sungero.Docflow.IApprovalRulePageStates Pages
    {
      get { return (global::Sungero.Docflow.IApprovalRulePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRulePageStates(entity);
    }

  }


  public class ApprovalRuleControlStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseControlStates, global::Sungero.Docflow.IApprovalRuleControlStates
  {

    protected internal ApprovalRuleControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ApprovalRulePageStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBasePageStates, global::Sungero.Docflow.IApprovalRulePageStates
  {

    protected internal ApprovalRulePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRulePropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBasePropertyStates, global::Sungero.Docflow.IApprovalRulePropertyStates
  {
            public new global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentKinds> DocumentKinds
            {
              get { return (global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentKinds>)base.DocumentKinds; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseDocumentKinds> CreateDocumentKindsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentKinds>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleConditionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleConditions> Conditions
            {
              get { return (global::Sungero.Docflow.IApprovalRuleConditionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleConditions>)base.Conditions; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseConditionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseConditions> CreateConditionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleConditionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleConditions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleTransitionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleTransitions> Transitions
            {
              get { return (global::Sungero.Docflow.IApprovalRuleTransitionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleTransitions>)base.Transitions; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseTransitionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseTransitions> CreateTransitionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleTransitionsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleTransitions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleDepartmentsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDepartments> Departments
            {
              get { return (global::Sungero.Docflow.IApprovalRuleDepartmentsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDepartments>)base.Departments; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseDepartmentsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseDepartments> CreateDepartmentsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleDepartmentsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDepartments>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleStagesCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleStages> Stages
            {
              get { return (global::Sungero.Docflow.IApprovalRuleStagesCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleStages>)base.Stages; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseStagesCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseStages> CreateStagesState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleStagesCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleStages>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBusinessUnits> BusinessUnits
            {
              get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBusinessUnits>)base.BusinessUnits; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseBusinessUnitsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits> CreateBusinessUnitsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleBusinessUnitsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBusinessUnits>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IApprovalRuleDocumentGroupsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentGroups> DocumentGroups
            {
              get { return (global::Sungero.Docflow.IApprovalRuleDocumentGroupsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentGroups>)base.DocumentGroups; }
            }

            protected override global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups> CreateDocumentGroupsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalRuleDocumentGroupsCollectionPropertyState<global::Sungero.Docflow.IApprovalRuleDocumentGroups>(entity, propertyName);
            }


    protected internal ApprovalRulePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ApprovalRuleInfo.g.cs
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
  public class ApprovalRuleInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseInfo, global::Sungero.Docflow.IApprovalRuleInfo
  {
    public ApprovalRuleInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRulePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRulePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRulePropertiesInfo(entityType);
    }

  }

  public class ApprovalRulePropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBasePropertiesInfo, global::Sungero.Docflow.IApprovalRulePropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertiesInfo> DocumentKinds
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("DocumentKinds");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleConditionsPropertiesInfo> Conditions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Conditions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleConditionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleTransitionsPropertiesInfo> Transitions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Transitions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleTransitionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDepartmentsPropertiesInfo> Departments
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Departments");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDepartmentsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleStagesPropertiesInfo> Stages
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Stages");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleStagesPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertiesInfo> BusinessUnits
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("BusinessUnits");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleBusinessUnitsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDocumentGroupsPropertiesInfo> DocumentGroups
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("DocumentGroups");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalRuleDocumentGroupsPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal ApprovalRulePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ApprovalRuleHandlers.g.cs
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
  public partial class ApprovalRuleSharedHandlers : global::Sungero.Docflow.ApprovalRuleBaseSharedHandlers, IApprovalRuleSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalRule _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRule)this.Entity; }
    }


    public ApprovalRuleSharedHandlers(global::Sungero.Docflow.IApprovalRule entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalRuleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ApprovalRule
{
  /// <summary>
  /// Represents ApprovalRule resources.
  /// </summary>
  public class ApprovalRuleResources : global::Sungero.Docflow.Shared.ApprovalRuleBase.ApprovalRuleBaseResources, global::Sungero.Docflow.ApprovalRule.IApprovalRuleResources
  {
  }
}

// ==================================================================
// ApprovalRuleSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ApprovalRuleFunctions : global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions
  {
    private global::Sungero.Docflow.IApprovalRule _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRule)this.Entity; }
    }

    public ApprovalRuleFunctions(global::Sungero.Docflow.IApprovalRule entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRuleFunctions.g.cs
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
  internal static class ApprovalRule
  {
  }
}

// ==================================================================
// ApprovalRuleFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ApprovalRule
{

  public class ApprovalRuleFilterInfo : global::Sungero.Docflow.Shared.ApprovalRuleBase.ApprovalRuleBaseFilterInfo,
    global::Sungero.Docflow.IApprovalRuleFilterInfo
  {
  }

  public class ApprovalRuleFilterState : global::Sungero.Docflow.Shared.ApprovalRuleBase.ApprovalRuleBaseFilterState,
    global::Sungero.Docflow.IApprovalRuleFilterState
  {



    public new Sungero.Docflow.IApprovalRuleFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IApprovalRuleFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ApprovalRule.ApprovalRuleFilterInfo();
    }

  }
}

// ==================================================================
// ApprovalRuleSharedPublicFunctions.g.cs
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
  public class ApprovalRuleSharedPublicFunctions : global::Sungero.Docflow.Shared.IApprovalRuleSharedPublicFunctions
  {
  }
}
