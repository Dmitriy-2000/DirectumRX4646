
// ==================================================================
// CounterpartyDocumentEventArgs.g.cs
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
  public class CounterpartyDocumentCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public CounterpartyDocumentCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// CounterpartyDocumentHandlers.g.cs
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

  public partial class CounterpartyDocumentFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.ICounterpartyDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.ICounterpartyDocumentFilterState)this.Filter;
      }
    }

    public CounterpartyDocumentFilteringClientHandler(global::Sungero.Docflow.ICounterpartyDocumentFilterState filter)
    : base(filter)
    {
    }

    protected CounterpartyDocumentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class CounterpartyDocumentClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public CounterpartyDocumentClientHandlers(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyDocumentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class CounterpartyDocumentFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public CounterpartyDocumentFunctions(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyDocumentFunctions.g.cs
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
  internal static class CounterpartyDocument
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void FillName(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// CounterpartyDocumentClientPublicFunctions.g.cs
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
  public class CounterpartyDocumentClientPublicFunctions : global::Sungero.Docflow.Client.ICounterpartyDocumentClientPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyDocumentActions.g.cs
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
  public partial class CounterpartyDocumentActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj { get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; } }
    public CounterpartyDocumentActions(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity) { }
  }

  public partial class CounterpartyDocumentCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.ICounterpartyDocument> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.ICounterpartyDocument>(this.Entities); }
    }
  }

  public partial class CounterpartyDocumentCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CounterpartyDocumentAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class CounterpartyDocumentAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
