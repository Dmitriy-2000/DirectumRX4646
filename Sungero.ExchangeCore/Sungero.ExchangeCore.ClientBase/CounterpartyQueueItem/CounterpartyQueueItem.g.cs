
// ==================================================================
// CounterpartyQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class CounterpartyQueueItemMatchingTaskValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Workflow.ITask>
  {
    public CounterpartyQueueItemMatchingTaskValueInputEventArgs(global::Sungero.Workflow.ITask oldValue, global::Sungero.Workflow.ITask newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class CounterpartyQueueItemCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public CounterpartyQueueItemCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// CounterpartyQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{

  public partial class CounterpartyQueueItemFilteringClientHandler
    : global::Sungero.ExchangeCore.QueueItemBaseFilteringClientHandler
  {
    private global::Sungero.ExchangeCore.ICounterpartyQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.ExchangeCore.ICounterpartyQueueItemFilterState)this.Filter;
      }
    }

    public CounterpartyQueueItemFilteringClientHandler(global::Sungero.ExchangeCore.ICounterpartyQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected CounterpartyQueueItemFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class CounterpartyQueueItemClientHandlers : global::Sungero.ExchangeCore.QueueItemBaseClientHandlers
  {
    private global::Sungero.ExchangeCore.ICounterpartyQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyQueueItem)this.Entity; }
    }

    public virtual void MatchingTaskValueInput(global::Sungero.ExchangeCore.Client.CounterpartyQueueItemMatchingTaskValueInputEventArgs e) { }


    public virtual void SyncResultValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void CounterpartyNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CounterpartyValueInput(global::Sungero.ExchangeCore.Client.CounterpartyQueueItemCounterpartyValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> SyncResultFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }




    public CounterpartyQueueItemClientHandlers(global::Sungero.ExchangeCore.ICounterpartyQueueItem entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyQueueItemClientFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Client
{
  public partial class CounterpartyQueueItemFunctions : global::Sungero.ExchangeCore.Client.QueueItemBaseFunctions
  {
    private global::Sungero.ExchangeCore.ICounterpartyQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyQueueItem)this.Entity; }
    }

    public CounterpartyQueueItemFunctions(global::Sungero.ExchangeCore.ICounterpartyQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class CounterpartyQueueItem
  {
  }
}

// ==================================================================
// CounterpartyQueueItemClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyQueueItemClientPublicFunctions : global::Sungero.ExchangeCore.Client.ICounterpartyQueueItemClientPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyQueueItemActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public partial class CounterpartyQueueItemActions : global::Sungero.ExchangeCore.Client.QueueItemBaseActions
  {
    private global::Sungero.ExchangeCore.ICounterpartyQueueItem _obj { get { return (global::Sungero.ExchangeCore.ICounterpartyQueueItem)this.Entity; } }
    public CounterpartyQueueItemActions(global::Sungero.ExchangeCore.ICounterpartyQueueItem entity) : base(entity) { }
  }

  public partial class CounterpartyQueueItemCollectionActions : global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.ExchangeCore.ICounterpartyQueueItem> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.ExchangeCore.ICounterpartyQueueItem>(this.Entities); }
    }
  }

  public partial class CounterpartyQueueItemCollectionBulkActions : global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CounterpartyQueueItemAnyChildEntityActions : global::Sungero.ExchangeCore.Client.QueueItemBaseAnyChildEntityActions
  {
  }

  public partial class CounterpartyQueueItemAnyChildEntityCollectionActions : global::Sungero.ExchangeCore.Client.QueueItemBaseAnyChildEntityCollectionActions
  {
  }



}
