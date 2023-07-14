
// ==================================================================
// AddendumEventArgs.g.cs
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
// AddendumHandlers.g.cs
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

  public partial class AddendumFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IAddendumFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IAddendumFilterState)this.Filter;
      }
    }

    public AddendumFilteringClientHandler(global::Sungero.Docflow.IAddendumFilterState filter)
    : base(filter)
    {
    }

    protected AddendumFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class AddendumClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.IAddendum _obj
    {
      get { return (global::Sungero.Docflow.IAddendum)this.Entity; }
    }

    public AddendumClientHandlers(global::Sungero.Docflow.IAddendum entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AddendumClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class AddendumFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IAddendum _obj
    {
      get { return (global::Sungero.Docflow.IAddendum)this.Entity; }
    }

    public AddendumFunctions(global::Sungero.Docflow.IAddendum entity) : base(entity) { }
  }
}

// ==================================================================
// AddendumFunctions.g.cs
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
  internal static class Addendum
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AddendumFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTypesAvailableForChange", new System.Type[] {  });
      return (global::System.Collections.Generic.List<Domain.Shared.IEntityInfo>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AddendumFunctions" />
    internal static  global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.Docflow.IAddendum addendum, global::System.Collections.Generic.List<Sungero.Domain.Shared.IEntityInfo> types)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentType", new System.Type[] { typeof(global::System.Collections.Generic.List<Sungero.Domain.Shared.IEntityInfo>) });
      return (global::Sungero.Docflow.IOfficialDocument)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { types });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AddendumFunctions" />
    internal static  global::System.Boolean CanChangeDocumentType(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanChangeDocumentType", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::System.String GetDocumentName(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.AddendumFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDocumentName",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { document });
      }
      else
      {
        return global::Sungero.Docflow.Shared.AddendumFunctions.GetDocumentName(document);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IAddendum addendum, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::System.String GetLeadDocumentNumber(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetLeadDocumentNumber", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IAddendum addendum, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::System.Boolean IsProjectDocument(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsProjectDocument", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::System.Boolean IsProjectDocument(global::Sungero.Docflow.IAddendum addendum, global::System.Collections.Generic.List<global::System.Int32> leadingDocumentIds)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsProjectDocument", new System.Type[] { typeof(global::System.Collections.Generic.List<global::System.Int32>) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { leadingDocumentIds });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::Sungero.Docflow.IProjectBase GetProject(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetProject", new System.Type[] {  });
      return (global::Sungero.Docflow.IProjectBase)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void FillRequiredProperties(global::Sungero.Docflow.IAddendum addendum, System.Collections.Generic.IDictionary<global::System.String, System.Object> properties)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillRequiredProperties", new System.Type[] { typeof(System.Collections.Generic.IDictionary<global::System.String, System.Object>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { properties });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AddendumFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IAddendum addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)addendum).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AddendumFunctions" />
      internal static  global::Sungero.Docflow.IAddendum Create()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IAddendum>(
          global::System.Guid.Parse("58b9ed35-9c84-46cd-aa79-9b5ef5a82f5d"),
          "Create()"
      );
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AddendumFunctions" />
      internal static  global::Sungero.Docflow.Structures.Addendum.LeadingDocument GetLeadingDocument(global::System.Int32 documentId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.Addendum.LeadingDocument>(
          global::System.Guid.Parse("58b9ed35-9c84-46cd-aa79-9b5ef5a82f5d"),
          "GetLeadingDocument(global::System.Int32)"
      , documentId);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AddendumFunctions" />
      internal static  void RestoreAddendumRelationToLeadingDocument(global::System.Int32 addendumId)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("58b9ed35-9c84-46cd-aa79-9b5ef5a82f5d"),
          "RestoreAddendumRelationToLeadingDocument(global::System.Int32)"
      , addendumId);
      }

    }
  }
}

// ==================================================================
// AddendumClientPublicFunctions.g.cs
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
  public class AddendumClientPublicFunctions : global::Sungero.Docflow.Client.IAddendumClientPublicFunctions
  {
    public global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.Docflow.IAddendum addendum, global::System.Collections.Generic.List<Sungero.Domain.Shared.IEntityInfo> types)
    {
      return global::Sungero.Docflow.Functions.Addendum.ChangeDocumentType(addendum, types);
    }
  }
}

// ==================================================================
// AddendumActions.g.cs
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
  public partial class AddendumActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.IAddendum _obj { get { return (global::Sungero.Docflow.IAddendum)this.Entity; } }
    public AddendumActions(global::Sungero.Docflow.IAddendum entity) : base(entity) { }
  }

  public partial class AddendumCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IAddendum> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IAddendum>(this.Entities); }
    }
  }

  public partial class AddendumCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AddendumAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class AddendumAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
