
// ==================================================================
// ExchangeDocumentProcessingTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{ 
  public class ExchangeDocumentProcessingTaskBoxValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IBoxBase>
  {
    public ExchangeDocumentProcessingTaskBoxValueInputEventArgs(global::Sungero.ExchangeCore.IBoxBase oldValue, global::Sungero.ExchangeCore.IBoxBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ExchangeDocumentProcessingTaskCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public ExchangeDocumentProcessingTaskCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ExchangeDocumentProcessingTaskExchangeServiceValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IExchangeService>
  {
    public ExchangeDocumentProcessingTaskExchangeServiceValueInputEventArgs(global::Sungero.ExchangeCore.IExchangeService oldValue, global::Sungero.ExchangeCore.IExchangeService newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ExchangeDocumentProcessingTaskAssigneeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ExchangeDocumentProcessingTaskAssigneeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ExchangeDocumentProcessingTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ExchangeDocumentProcessingTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





}

// ==================================================================
// ExchangeDocumentProcessingTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{

  public partial class ExchangeDocumentProcessingTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Exchange.IExchangeDocumentProcessingTaskFilterState Filter { get; private set; }

    private global::Sungero.Exchange.IExchangeDocumentProcessingTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ExchangeDocumentProcessingTaskFilteringClientHandler(global::Sungero.Exchange.IExchangeDocumentProcessingTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ExchangeDocumentProcessingTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ExchangeDocumentProcessingTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Exchange.IExchangeDocumentProcessingTask _obj
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTask)this.Entity; }
    }

    public virtual void BoxValueInput(global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskBoxValueInputEventArgs e) { }


    public virtual void CounterpartyValueInput(global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskCounterpartyValueInputEventArgs e) { }


    public virtual void ExchangeServiceValueInput(global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskExchangeServiceValueInputEventArgs e) { }


    public virtual void AssigneeValueInput(global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskAssigneeValueInputEventArgs e) { }


    public virtual void DeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void AddresseeValueInput(global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskAddresseeValueInputEventArgs e) { }


    public virtual void IncomeDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void IsReadressedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void IsIncomingValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }



    public ExchangeDocumentProcessingTaskClientHandlers(global::Sungero.Exchange.IExchangeDocumentProcessingTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExchangeDocumentProcessingTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Exchange.Client
{
  public partial class ExchangeDocumentProcessingTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Exchange.IExchangeDocumentProcessingTask _obj
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTask)this.Entity; }
    }

    public ExchangeDocumentProcessingTaskFunctions(global::Sungero.Exchange.IExchangeDocumentProcessingTask entity) : base(entity) { }
  }
}

// ==================================================================
// ExchangeDocumentProcessingTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Functions
{
  internal static class ExchangeDocumentProcessingTask
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Exchange.Server" type="Sungero.Exchange.Server.ExchangeDocumentProcessingTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.Exchange.IExchangeDocumentProcessingTask exchangeDocumentProcessingTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("ae03c598-ab50-4781-b1b2-968510b338b9"),
          "GetStateView(global::Sungero.Exchange.IExchangeDocumentProcessingTask)"
          , exchangeDocumentProcessingTask);
      }
      /// <redirect project="Sungero.Exchange.Server" type="Sungero.Exchange.Server.ExchangeDocumentProcessingTaskFunctions" />
      internal static  global::System.Boolean AreAllDocumentsSendToWork(global::Sungero.Exchange.IExchangeDocumentProcessingTask exchangeDocumentProcessingTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("ae03c598-ab50-4781-b1b2-968510b338b9"),
          "AreAllDocumentsSendToWork(global::Sungero.Exchange.IExchangeDocumentProcessingTask)"
          , exchangeDocumentProcessingTask);
      }

    }
  }
}

// ==================================================================
// ExchangeDocumentProcessingTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{
  public class ExchangeDocumentProcessingTaskClientPublicFunctions : global::Sungero.Exchange.Client.IExchangeDocumentProcessingTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// ExchangeDocumentProcessingTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{
  public partial class ExchangeDocumentProcessingTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Exchange.IExchangeDocumentProcessingTask _obj { get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTask)this.Entity; } }
    public ExchangeDocumentProcessingTaskActions(global::Sungero.Exchange.IExchangeDocumentProcessingTask entity) : base(entity) { }
  }

  public partial class ExchangeDocumentProcessingTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Exchange.IExchangeDocumentProcessingTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Exchange.IExchangeDocumentProcessingTask>(this.Entities); }
    }
  }

  public partial class ExchangeDocumentProcessingTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ExchangeDocumentProcessingTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class ExchangeDocumentProcessingTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
