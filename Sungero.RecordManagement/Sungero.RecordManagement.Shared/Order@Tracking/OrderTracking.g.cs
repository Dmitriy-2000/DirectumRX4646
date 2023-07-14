
// ==================================================================
// OrderTrackingState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class OrderTrackingState : 
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingState, global::Sungero.RecordManagement.IOrderTrackingState
  {
    public OrderTrackingState(global::Sungero.RecordManagement.IOrderTracking entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IOrderTrackingPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.OrderTrackingPropertyStates(entity);
    }


  }


  public class OrderTrackingPropertyStates : 
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingPropertyStates, global::Sungero.RecordManagement.IOrderTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IOrder> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IOrder>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IOrder>("OfficialDocument"); }
            }


    protected internal OrderTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OrderTrackingCollectionPropertyState<T> :
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingCollectionPropertyState<T>, global::Sungero.RecordManagement.IOrderTrackingCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IOrderTracking
  {
    public new global::Sungero.RecordManagement.IOrderTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.OrderTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OrderTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OrderTrackingCollectionPropertyStates :
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingCollectionPropertyStates, global::Sungero.RecordManagement.IOrderTrackingCollectionPropertyStates
  {

    protected internal OrderTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OrderTrackingInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class OrderTrackingInfo : 
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingInfo, global::Sungero.RecordManagement.IOrderTrackingInfo
  {
    public OrderTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IOrderTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.OrderTrackingPropertiesInfo(entityType);
    }

  }

  public class OrderTrackingPropertiesInfo : 
    global::Sungero.RecordManagement.Shared.OrderBaseTrackingPropertiesInfo, global::Sungero.RecordManagement.IOrderTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IOrderInfo, global::Sungero.RecordManagement.IOrder> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IOrderInfo, global::Sungero.RecordManagement.IOrder>(propertyMetadata);
          }
        }


    protected internal OrderTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
