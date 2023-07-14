
// ==================================================================
// ProjectDocumentRightsQueueItemEventArgs.g.cs
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
// ProjectDocumentRightsQueueItemHandlers.g.cs
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

  public partial class ProjectDocumentRightsQueueItemFilteringClientHandler
    : global::Sungero.Projects.ProjectQueueItemBaseFilteringClientHandler
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectDocumentRightsQueueItemFilterState)this.Filter;
      }
    }

    public ProjectDocumentRightsQueueItemFilteringClientHandler(global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected ProjectDocumentRightsQueueItemFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ProjectDocumentRightsQueueItemClientHandlers : global::Sungero.Projects.ProjectQueueItemBaseClientHandlers
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; }
    }

    public virtual void DocumentIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public ProjectDocumentRightsQueueItemClientHandlers(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectDocumentRightsQueueItemClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectDocumentRightsQueueItemFunctions : global::Sungero.Projects.Client.ProjectQueueItemBaseFunctions
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; }
    }

    public ProjectDocumentRightsQueueItemFunctions(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemFunctions.g.cs
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
  internal static class ProjectDocumentRightsQueueItem
  {
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemClientPublicFunctions.g.cs
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
  public class ProjectDocumentRightsQueueItemClientPublicFunctions : global::Sungero.Projects.Client.IProjectDocumentRightsQueueItemClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemActions.g.cs
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
  public partial class ProjectDocumentRightsQueueItemActions : global::Sungero.Projects.Client.ProjectQueueItemBaseActions
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj { get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; } }
    public ProjectDocumentRightsQueueItemActions(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity) { }
  }

  public partial class ProjectDocumentRightsQueueItemCollectionActions : global::Sungero.Projects.Client.ProjectQueueItemBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectDocumentRightsQueueItem> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectDocumentRightsQueueItem>(this.Entities); }
    }
  }

  public partial class ProjectDocumentRightsQueueItemCollectionBulkActions : global::Sungero.Projects.Client.ProjectQueueItemBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectDocumentRightsQueueItemAnyChildEntityActions : global::Sungero.Projects.Client.ProjectQueueItemBaseAnyChildEntityActions
  {
  }

  public partial class ProjectDocumentRightsQueueItemAnyChildEntityCollectionActions : global::Sungero.Projects.Client.ProjectQueueItemBaseAnyChildEntityCollectionActions
  {
  }



}
