
// ==================================================================
// MemoTrackingState.g.cs
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
  public class MemoTrackingState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingState, global::Sungero.Docflow.IMemoTrackingState
  {
    public MemoTrackingState(global::Sungero.Docflow.IMemoTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IMemoTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMemoTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MemoTrackingPropertyStates(entity);
    }


  }


  public class MemoTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingPropertyStates, global::Sungero.Docflow.IMemoTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMemo> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMemo>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMemo>("OfficialDocument"); }
            }


    protected internal MemoTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MemoTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingCollectionPropertyState<T>, global::Sungero.Docflow.IMemoTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IMemoTracking
  {
    public new global::Sungero.Docflow.IMemoTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMemoTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.MemoTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal MemoTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class MemoTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingCollectionPropertyStates, global::Sungero.Docflow.IMemoTrackingCollectionPropertyStates
  {

    protected internal MemoTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// MemoTrackingInfo.g.cs
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
  public class MemoTrackingInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingInfo, global::Sungero.Docflow.IMemoTrackingInfo
  {
    public MemoTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IMemoTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IMemoTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.MemoTrackingPropertiesInfo(entityType);
    }

  }

  public class MemoTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingPropertiesInfo, global::Sungero.Docflow.IMemoTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMemoInfo, global::Sungero.Docflow.IMemo> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMemoInfo, global::Sungero.Docflow.IMemo>(propertyMetadata);
          }
        }


    protected internal MemoTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}