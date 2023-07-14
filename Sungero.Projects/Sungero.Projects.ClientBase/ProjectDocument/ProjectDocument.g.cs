
// ==================================================================
// ProjectDocumentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{ 
}

// ==================================================================
// ProjectDocumentHandlers.g.cs
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

  public partial class ProjectDocumentFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Projects.IProjectDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectDocumentFilterState)this.Filter;
      }
    }

    public ProjectDocumentFilteringClientHandler(global::Sungero.Projects.IProjectDocumentFilterState filter)
    : base(filter)
    {
    }

    protected ProjectDocumentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ProjectDocumentClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Projects.IProjectDocument _obj
    {
      get { return (global::Sungero.Projects.IProjectDocument)this.Entity; }
    }

    public ProjectDocumentClientHandlers(global::Sungero.Projects.IProjectDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectDocumentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectDocumentFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Projects.IProjectDocument _obj
    {
      get { return (global::Sungero.Projects.IProjectDocument)this.Entity; }
    }

    public ProjectDocumentFunctions(global::Sungero.Projects.IProjectDocument entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectDocumentFunctions.g.cs
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
  internal static class ProjectDocument
  {
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void FillName(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  global::System.Boolean NeedClearProject(global::Sungero.Projects.IProjectDocument projectDocument, Sungero.Docflow.Shared.OfficialDocumentDocumentKindChangedEventArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedClearProject", new System.Type[] { typeof(Sungero.Docflow.Shared.OfficialDocumentDocumentKindChangedEventArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDefaultSignatory(global::Sungero.Projects.IProjectDocument projectDocument, global::System.Collections.Generic.List<Docflow.Structures.SignatureSetting.Signatory> signatories)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDefaultSignatory", new System.Type[] { typeof(global::System.Collections.Generic.List<Docflow.Structures.SignatureSetting.Signatory>) });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signatories });
    }

  }
}

// ==================================================================
// ProjectDocumentClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectDocumentClientPublicFunctions : global::Sungero.Projects.Client.IProjectDocumentClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectDocumentActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public partial class ProjectDocumentActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Projects.IProjectDocument _obj { get { return (global::Sungero.Projects.IProjectDocument)this.Entity; } }
    public ProjectDocumentActions(global::Sungero.Projects.IProjectDocument entity) : base(entity) { }
  }

  public partial class ProjectDocumentCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectDocument> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectDocument>(this.Entities); }
    }
  }

  public partial class ProjectDocumentCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectDocumentAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class ProjectDocumentAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
