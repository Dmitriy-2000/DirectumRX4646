
// ==================================================================
// IncomingDocumentBaseTrackingState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class IncomingDocumentBaseTrackingState : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingState, global::Sungero.Docflow.IIncomingDocumentBaseTrackingState
  {
    public IncomingDocumentBaseTrackingState(global::Sungero.Docflow.IIncomingDocumentBaseTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.IncomingDocumentBaseTrackingPropertyStates(entity);
    }


  }


  public class IncomingDocumentBaseTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertyStates, global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IIncomingDocumentBase> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IIncomingDocumentBase>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IIncomingDocumentBase>("OfficialDocument"); }
            }


    protected internal IncomingDocumentBaseTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class IncomingDocumentBaseTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingCollectionPropertyState<T>, global::Sungero.Docflow.IIncomingDocumentBaseTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IIncomingDocumentBaseTracking
  {
    public new global::Sungero.Docflow.IIncomingDocumentBaseTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IIncomingDocumentBaseTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.IncomingDocumentBaseTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal IncomingDocumentBaseTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class IncomingDocumentBaseTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingCollectionPropertyStates, global::Sungero.Docflow.IIncomingDocumentBaseTrackingCollectionPropertyStates
  {

    protected internal IncomingDocumentBaseTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// IncomingDocumentBaseTrackingInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class IncomingDocumentBaseTrackingInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingInfo, global::Sungero.Docflow.IIncomingDocumentBaseTrackingInfo
  {
    public IncomingDocumentBaseTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.IncomingDocumentBaseTrackingPropertiesInfo(entityType);
    }

  }

  public class IncomingDocumentBaseTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertiesInfo, global::Sungero.Docflow.IIncomingDocumentBaseTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IIncomingDocumentBaseInfo, global::Sungero.Docflow.IIncomingDocumentBase> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IIncomingDocumentBaseInfo, global::Sungero.Docflow.IIncomingDocumentBase>(propertyMetadata);
          }
        }


    protected internal IncomingDocumentBaseTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
