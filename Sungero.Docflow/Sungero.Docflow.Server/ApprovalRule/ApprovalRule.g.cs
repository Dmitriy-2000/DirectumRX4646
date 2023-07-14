
// ==================================================================
// ApprovalRule.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalRuleFilter<T> :
      global::Sungero.Docflow.Server.ApprovalRuleBaseFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalRule
    {
      private global::Sungero.Docflow.IApprovalRuleFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IApprovalRuleFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalRuleFilter(global::Sungero.Docflow.IApprovalRuleFilterState filter)
      : base(filter)
      {
      }

      protected ApprovalRuleFilter()
      {
      }
    }
      public class ApprovalRuleUiFilter<T> :
        global::Sungero.Docflow.Server.ApprovalRuleBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IApprovalRule
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalRuleSearchDialogModel : global::Sungero.Docflow.Server.ApprovalRuleBaseSearchDialogModel
        {
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Int32? Priority { get; protected set; }
                  public override global::System.String Note { get; protected set; }
                  public override global::System.Boolean? IsSmallApprovalAllowed { get; protected set; }
                  public override global::System.Int32? ReworkDeadline { get; protected set; }
                  public override global::System.Boolean? NeedRestrictInitiatorRights { get; protected set; }
                  public override global::System.Int32? Id { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ReworkPerformerType { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> ReworkPerformer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IApprovalRoleBase> ReworkApprovalRole { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> DocumentFlow { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleDocumentKindsModel DocumentKinds { get { return (ApprovalRuleDocumentKindsModel)base.DocumentKinds; } protected set { base.DocumentKinds = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleConditionsModel Conditions { get { return (ApprovalRuleConditionsModel)base.Conditions; } protected set { base.Conditions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleTransitionsModel Transitions { get { return (ApprovalRuleTransitionsModel)base.Transitions; } protected set { base.Transitions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleDepartmentsModel Departments { get { return (ApprovalRuleDepartmentsModel)base.Departments; } protected set { base.Departments = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleStagesModel Stages { get { return (ApprovalRuleStagesModel)base.Stages; } protected set { base.Stages = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleBusinessUnitsModel BusinessUnits { get { return (ApprovalRuleBusinessUnitsModel)base.BusinessUnits; } protected set { base.BusinessUnits = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ApprovalRuleDocumentGroupsModel DocumentGroups { get { return (ApprovalRuleDocumentGroupsModel)base.DocumentGroups; } protected set { base.DocumentGroups = value; } }

        }

      public class ApprovalRuleDocumentKindsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleConditionsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseConditionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleTransitionsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseTransitionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleDepartmentsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseDepartmentsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleStagesModel : global::Sungero.Docflow.Server.ApprovalRuleBaseStagesModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleBusinessUnitsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseBusinessUnitsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ApprovalRuleDocumentGroupsModel : global::Sungero.Docflow.Server.ApprovalRuleBaseDocumentGroupsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalRuleFilter<global::Sungero.Docflow.IApprovalRule>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ApprovalRuleUiFilter<global::Sungero.Docflow.IApprovalRule>))]

  public class ApprovalRule :
    global::Sungero.Docflow.Server.ApprovalRuleBase, global::Sungero.Docflow.IApprovalRule
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a8dc61a5-862e-4c8a-a0e0-a5735ec3c3b3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalRule.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRule, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleState State
    {
      get { return (global::Sungero.Docflow.IApprovalRuleState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalRuleInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalRuleAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalRuleAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalRuleFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseDocumentKinds> CreateDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleDocumentKinds>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseConditions> CreateConditionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleConditions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseTransitions> CreateTransitionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleTransitions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseDepartments> CreateDepartmentsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleDepartments>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseStages> CreateStagesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleStages>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits> CreateBusinessUnitsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBusinessUnits>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups> CreateDocumentGroupsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IApprovalRuleDocumentGroups>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalRuleCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalRule)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalRuleCreatingFromServerHandler((global::Sungero.Docflow.IApprovalRule)entitySource, this.Info);
    }

    #region Framework events










    #endregion


    public ApprovalRule()
    {
    }

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

  public partial class ApprovalRuleFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalRuleBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalRule
  {
    private global::Sungero.Docflow.IApprovalRuleFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IApprovalRuleFilterState)this.Filter;
      }
    }

    public ApprovalRuleFilteringServerHandler(global::Sungero.Docflow.IApprovalRuleFilterState filter)
    : base(filter)
    {
    }

    protected ApprovalRuleFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ApprovalRuleUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalRuleBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IApprovalRule
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalRuleSearchDialogServerHandler : global::Sungero.Docflow.ApprovalRuleBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalRuleSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalRuleSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalRuleSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalRuleSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalRuleServerHandlers : global::Sungero.Docflow.ApprovalRuleBaseServerHandlers
  {
    private global::Sungero.Docflow.IApprovalRule _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRule)this.Entity; }
    }

    public ApprovalRuleServerHandlers(global::Sungero.Docflow.IApprovalRule entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalRuleCreatingFromServerHandler : global::Sungero.Docflow.ApprovalRuleBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalRule _source
    {
      get { return (global::Sungero.Docflow.IApprovalRule)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalRuleInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalRuleInfo)this._Info; }
    }

    public ApprovalRuleCreatingFromServerHandler(global::Sungero.Docflow.IApprovalRule source, global::Sungero.Docflow.IApprovalRuleInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalRuleEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalRuleAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalRuleAccessRights : 
    Sungero.Docflow.Server.ApprovalRuleBaseAccessRights, Sungero.Docflow.IApprovalRuleAccessRights
  {

    public ApprovalRuleAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalRuleTypeAccessRights : 
    Sungero.Docflow.Server.ApprovalRuleBaseTypeAccessRights, Sungero.Docflow.IApprovalRuleAccessRights
  {

    public ApprovalRuleTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalRuleRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalRuleRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ApprovalRuleBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalRuleRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalRule 
    {
       public new global::Sungero.Docflow.IApprovalRuleAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalRuleAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalRuleInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalRuleInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalRuleTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalRulePanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalRuleServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalRuleFunctions : global::Sungero.Docflow.Server.ApprovalRuleBaseFunctions
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
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleFunctions" />
    internal static  global::System.Boolean CheckRoutePossibility(global::Sungero.Docflow.IApprovalRule approvalRule, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep> route, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.ConditionRouteStep> ruleConditions, global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep conditionStep)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRule).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckRoutePossibility", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep>), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.ConditionRouteStep>), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { route, ruleConditions, conditionStep });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleFunctions" />
    internal static  global::System.Boolean CheckAddresseeConditions(global::Sungero.Docflow.IApprovalRule approvalRule, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep> allConditions, global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRule).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckAddresseeConditions", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep>), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { allConditions, condition });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleFunctions" />
    internal static  global::System.Boolean CheckManyAddresseesConditions(global::Sungero.Docflow.IApprovalRule approvalRule, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep> allConditions, global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRule).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckManyAddresseesConditions", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep>), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { allConditions, condition });
    }

  }
}

// ==================================================================
// ApprovalRuleServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalRuleServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalRuleServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalRuleQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class ApprovalRule
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalRule.ApprovalRuleQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}