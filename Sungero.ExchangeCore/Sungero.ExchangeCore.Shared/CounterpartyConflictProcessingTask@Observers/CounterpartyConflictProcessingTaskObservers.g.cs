
// ==================================================================
// CounterpartyConflictProcessingTaskObserversState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class CounterpartyConflictProcessingTaskObserversState : 
    global::Sungero.Workflow.Shared.TaskObserversState, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversState
  {
    public CounterpartyConflictProcessingTaskObserversState(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObservers entity) : base(entity) { }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskObserversPropertyStates(entity);
    }


  }


  public class CounterpartyConflictProcessingTaskObserversPropertyStates : 
    global::Sungero.Workflow.Shared.TaskObserversPropertyStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask> Task
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask>)base.Task; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> InternalTask
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask>("Task"); }
            }


    protected internal CounterpartyConflictProcessingTaskObserversPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CounterpartyConflictProcessingTaskObserversCollectionPropertyState<T> :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyState<T>, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversCollectionPropertyState<T>
    where T : global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObservers
  {
    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversCollectionPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskObserversCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal CounterpartyConflictProcessingTaskObserversCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class CounterpartyConflictProcessingTaskObserversCollectionPropertyStates :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversCollectionPropertyStates
  {

    protected internal CounterpartyConflictProcessingTaskObserversCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// CounterpartyConflictProcessingTaskObserversInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class CounterpartyConflictProcessingTaskObserversInfo : 
    global::Sungero.Workflow.Shared.TaskObserversInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversInfo
  {
    public CounterpartyConflictProcessingTaskObserversInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertiesInfo Properties
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskObserversPropertiesInfo(entityType);
    }

  }

  public class CounterpartyConflictProcessingTaskObserversPropertiesInfo : 
    global::Sungero.Workflow.Shared.TaskObserversPropertiesInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObserversPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask> Task
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Task");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask>(propertyMetadata);
          }
        }


    protected internal CounterpartyConflictProcessingTaskObserversPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
