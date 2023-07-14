
// ==================================================================
// ProjectApprovalRoleState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectApprovalRoleState : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseState, global::Sungero.Projects.IProjectApprovalRoleState
  {
    public ProjectApprovalRoleState(global::Sungero.Projects.IProjectApprovalRole entity) : base(entity) { }

    public new global::Sungero.Projects.IProjectApprovalRolePropertyStates Properties
    {
      get { return (global::Sungero.Projects.IProjectApprovalRolePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectApprovalRolePropertyStates(entity);
    }


    public new global::Sungero.Projects.IProjectApprovalRoleControlStates Controls
    {
      get { return (global::Sungero.Projects.IProjectApprovalRoleControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectApprovalRoleControlStates(entity);
    }

    public new global::Sungero.Projects.IProjectApprovalRolePageStates Pages
    {
      get { return (global::Sungero.Projects.IProjectApprovalRolePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectApprovalRolePageStates(entity);
    }

  }


  public class ProjectApprovalRoleControlStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseControlStates, global::Sungero.Projects.IProjectApprovalRoleControlStates
  {

    protected internal ProjectApprovalRoleControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ProjectApprovalRolePageStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePageStates, global::Sungero.Projects.IProjectApprovalRolePageStates
  {

    protected internal ProjectApprovalRolePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ProjectApprovalRolePropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePropertyStates, global::Sungero.Projects.IProjectApprovalRolePropertyStates
  {

    protected internal ProjectApprovalRolePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ProjectApprovalRoleInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectApprovalRoleInfo : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseInfo, global::Sungero.Projects.IProjectApprovalRoleInfo
  {
    public ProjectApprovalRoleInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Projects.IProjectApprovalRolePropertiesInfo Properties
    {
      get { return (global::Sungero.Projects.IProjectApprovalRolePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Projects.Shared.ProjectApprovalRolePropertiesInfo(entityType);
    }

  }

  public class ProjectApprovalRolePropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePropertiesInfo, global::Sungero.Projects.IProjectApprovalRolePropertiesInfo
  {

    protected internal ProjectApprovalRolePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ProjectApprovalRoleHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects
{
  public partial class ProjectApprovalRoleSharedHandlers : global::Sungero.Docflow.ApprovalRoleBaseSharedHandlers, IProjectApprovalRoleSharedHandlers
  {
    private global::Sungero.Projects.IProjectApprovalRole _obj
    {
      get { return (global::Sungero.Projects.IProjectApprovalRole)this.Entity; }
    }


    public ProjectApprovalRoleSharedHandlers(global::Sungero.Projects.IProjectApprovalRole entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectApprovalRoleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared.ProjectApprovalRole
{
  /// <summary>
  /// Represents ProjectApprovalRole resources.
  /// </summary>
  public class ProjectApprovalRoleResources : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseResources, global::Sungero.Projects.ProjectApprovalRole.IProjectApprovalRoleResources
  {
  }
}

// ==================================================================
// ProjectApprovalRoleSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Shared
{
  public partial class ProjectApprovalRoleFunctions : global::Sungero.Docflow.Shared.ApprovalRoleBaseFunctions
  {
    private global::Sungero.Projects.IProjectApprovalRole _obj
    {
      get { return (global::Sungero.Projects.IProjectApprovalRole)this.Entity; }
    }

    public ProjectApprovalRoleFunctions(global::Sungero.Projects.IProjectApprovalRole entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectApprovalRoleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Functions
{
  internal static class ProjectApprovalRole
  {
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectApprovalRoleFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> Filter(global::Sungero.Projects.IProjectApprovalRole projectApprovalRole, global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> kinds)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectApprovalRole).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Filter", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind>) });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { kinds });
    }

  }
}

// ==================================================================
// ProjectApprovalRoleFilterState.g.cs
// ==================================================================

namespace Sungero.Projects.Shared.ProjectApprovalRole
{

  public class ProjectApprovalRoleFilterInfo : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseFilterInfo,
    global::Sungero.Projects.IProjectApprovalRoleFilterInfo
  {
  }

  public class ProjectApprovalRoleFilterState : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseFilterState,
    global::Sungero.Projects.IProjectApprovalRoleFilterState
  {



    public new Sungero.Projects.IProjectApprovalRoleFilterInfo Info
    {
      get
      {
        return (Sungero.Projects.IProjectApprovalRoleFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Projects.Shared.ProjectApprovalRole.ProjectApprovalRoleFilterInfo();
    }

  }
}

// ==================================================================
// ProjectApprovalRoleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectApprovalRoleSharedPublicFunctions : global::Sungero.Projects.Shared.IProjectApprovalRoleSharedPublicFunctions
  {
  }
}
