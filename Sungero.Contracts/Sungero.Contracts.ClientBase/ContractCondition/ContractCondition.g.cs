
// ==================================================================
// ContractConditionEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{ 
}

// ==================================================================
// ContractConditionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{

  public partial class ContractConditionFilteringClientHandler
    : global::Sungero.Docflow.ConditionBaseFilteringClientHandler
  {
    private global::Sungero.Contracts.IContractConditionFilterState _filter
    {
      get
      {
        return (Sungero.Contracts.IContractConditionFilterState)this.Filter;
      }
    }

    public ContractConditionFilteringClientHandler(global::Sungero.Contracts.IContractConditionFilterState filter)
    : base(filter)
    {
    }

    protected ContractConditionFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ContractConditionClientHandlers : global::Sungero.Docflow.ConditionBaseClientHandlers
  {
    private global::Sungero.Contracts.IContractCondition _obj
    {
      get { return (global::Sungero.Contracts.IContractCondition)this.Entity; }
    }

    public ContractConditionClientHandlers(global::Sungero.Contracts.IContractCondition entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContractConditionClientFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Client
{
  public partial class ContractConditionFunctions : global::Sungero.Docflow.Client.ConditionBaseFunctions
  {
    private global::Sungero.Contracts.IContractCondition _obj
    {
      get { return (global::Sungero.Contracts.IContractCondition)this.Entity; }
    }

    public ContractConditionFunctions(global::Sungero.Contracts.IContractCondition entity) : base(entity) { }
  }
}

// ==================================================================
// ContractConditionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Functions
{
  internal static class ContractCondition
  {
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>> GetSupportedConditions(global::Sungero.Contracts.IContractCondition contractCondition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSupportedConditions", new System.Type[] {  });
      return (System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  Docflow.Structures.ConditionBase.ConditionResult CheckCondition(global::Sungero.Contracts.IContractCondition contractCondition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckCondition", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractConditionFunctions" />
      internal static  global::Sungero.Contracts.IContractCondition CreateContractCondition()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Contracts.IContractCondition>(
          global::System.Guid.Parse("0523387b-a689-41e5-bed3-95892df6922c"),
          "CreateContractCondition()"
      );
      }

    }
  }
}

// ==================================================================
// ContractConditionClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractConditionClientPublicFunctions : global::Sungero.Contracts.Client.IContractConditionClientPublicFunctions
  {
  }
}

// ==================================================================
// ContractConditionActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public partial class ContractConditionActions : global::Sungero.Docflow.Client.ConditionBaseActions
  {
    private global::Sungero.Contracts.IContractCondition _obj { get { return (global::Sungero.Contracts.IContractCondition)this.Entity; } }
    public ContractConditionActions(global::Sungero.Contracts.IContractCondition entity) : base(entity) { }
  }

  public partial class ContractConditionCollectionActions : global::Sungero.Docflow.Client.ConditionBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Contracts.IContractCondition> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Contracts.IContractCondition>(this.Entities); }
    }
  }

  public partial class ContractConditionCollectionBulkActions : global::Sungero.Docflow.Client.ConditionBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ContractConditionAnyChildEntityActions : global::Sungero.Docflow.Client.ConditionBaseAnyChildEntityActions
  {
  }

  public partial class ContractConditionAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.ConditionBaseAnyChildEntityCollectionActions
  {
  }



}
