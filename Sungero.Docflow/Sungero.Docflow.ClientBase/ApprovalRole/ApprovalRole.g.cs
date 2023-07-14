
// ==================================================================
// ApprovalRoleEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
}

// ==================================================================
// ApprovalRoleHandlers.g.cs
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

  public partial class ApprovalRoleFilteringClientHandler
    : global::Sungero.Docflow.ApprovalRoleBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IApprovalRoleFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IApprovalRoleFilterState)this.Filter;
      }
    }

    public ApprovalRoleFilteringClientHandler(global::Sungero.Docflow.IApprovalRoleFilterState filter)
    : base(filter)
    {
    }

    protected ApprovalRoleFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ApprovalRoleClientHandlers : global::Sungero.Docflow.ApprovalRoleBaseClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRole _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRole)this.Entity; }
    }

    public ApprovalRoleClientHandlers(global::Sungero.Docflow.IApprovalRole entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalRoleClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalRoleFunctions : global::Sungero.Docflow.Client.ApprovalRoleBaseFunctions
  {
    private global::Sungero.Docflow.IApprovalRole _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRole)this.Entity; }
    }

    public ApprovalRoleFunctions(global::Sungero.Docflow.IApprovalRole entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRoleFunctions.g.cs
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
  internal static class ApprovalRole
  {
  }
}

// ==================================================================
// ApprovalRoleClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRoleClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalRoleClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalRoleActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class ApprovalRoleActions : global::Sungero.Docflow.Client.ApprovalRoleBaseActions
  {
    private global::Sungero.Docflow.IApprovalRole _obj { get { return (global::Sungero.Docflow.IApprovalRole)this.Entity; } }
    public ApprovalRoleActions(global::Sungero.Docflow.IApprovalRole entity) : base(entity) { }
  }

  public partial class ApprovalRoleCollectionActions : global::Sungero.Docflow.Client.ApprovalRoleBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalRole> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalRole>(this.Entities); }
    }
  }

  public partial class ApprovalRoleCollectionBulkActions : global::Sungero.Docflow.Client.ApprovalRoleBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ApprovalRoleAnyChildEntityActions : global::Sungero.Docflow.Client.ApprovalRoleBaseAnyChildEntityActions
  {
  }

  public partial class ApprovalRoleAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.ApprovalRoleBaseAnyChildEntityCollectionActions
  {
  }



}