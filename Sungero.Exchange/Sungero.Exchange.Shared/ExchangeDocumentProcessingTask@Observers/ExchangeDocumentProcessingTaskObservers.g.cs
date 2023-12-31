
// ==================================================================
// ExchangeDocumentProcessingTaskObserversState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class ExchangeDocumentProcessingTaskObserversState : 
    global::Sungero.Workflow.Shared.TaskObserversState, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversState
  {
    public ExchangeDocumentProcessingTaskObserversState(global::Sungero.Exchange.IExchangeDocumentProcessingTaskObservers entity) : base(entity) { }

    public new global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertyStates Properties
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentProcessingTaskObserversPropertyStates(entity);
    }


  }


  public class ExchangeDocumentProcessingTaskObserversPropertyStates : 
    global::Sungero.Workflow.Shared.TaskObserversPropertyStates, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Exchange.IExchangeDocumentProcessingTask> Task
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Exchange.IExchangeDocumentProcessingTask>)base.Task; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> InternalTask
            {
              get { return this.GetPropertyState<global::Sungero.Exchange.IExchangeDocumentProcessingTask>("Task"); }
            }


    protected internal ExchangeDocumentProcessingTaskObserversPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ExchangeDocumentProcessingTaskObserversCollectionPropertyState<T> :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyState<T>, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversCollectionPropertyState<T>
    where T : global::Sungero.Exchange.IExchangeDocumentProcessingTaskObservers
  {
    public new global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentProcessingTaskObserversCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ExchangeDocumentProcessingTaskObserversCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ExchangeDocumentProcessingTaskObserversCollectionPropertyStates :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyStates, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversCollectionPropertyStates
  {

    protected internal ExchangeDocumentProcessingTaskObserversCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ExchangeDocumentProcessingTaskObserversInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class ExchangeDocumentProcessingTaskObserversInfo : 
    global::Sungero.Workflow.Shared.TaskObserversInfo, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversInfo
  {
    public ExchangeDocumentProcessingTaskObserversInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertiesInfo Properties
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentProcessingTaskObserversPropertiesInfo(entityType);
    }

  }

  public class ExchangeDocumentProcessingTaskObserversPropertiesInfo : 
    global::Sungero.Workflow.Shared.TaskObserversPropertiesInfo, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Exchange.IExchangeDocumentProcessingTaskInfo, global::Sungero.Exchange.IExchangeDocumentProcessingTask> Task
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Task");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Exchange.IExchangeDocumentProcessingTaskInfo, global::Sungero.Exchange.IExchangeDocumentProcessingTask>(propertyMetadata);
          }
        }


    protected internal ExchangeDocumentProcessingTaskObserversPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
