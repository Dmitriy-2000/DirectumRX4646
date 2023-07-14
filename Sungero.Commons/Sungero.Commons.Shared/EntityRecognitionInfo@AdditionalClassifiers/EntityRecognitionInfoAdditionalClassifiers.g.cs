
// ==================================================================
// EntityRecognitionInfoAdditionalClassifiersState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class EntityRecognitionInfoAdditionalClassifiersState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersState
  {
    public EntityRecognitionInfoAdditionalClassifiersState(global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers entity) : base(entity) { }

    public new global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertyStates Properties
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersPropertyStates(entity);
    }


  }


  public class EntityRecognitionInfoAdditionalClassifiersPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.IEntityRecognitionInfo> EntityRecognitionInfo 
            {
              get { return this.InternalEntityRecognitionInfo; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.IEntityRecognitionInfo> InternalEntityRecognitionInfo
            {
              get { return this.GetPropertyState<global::Sungero.Commons.IEntityRecognitionInfo>("EntityRecognitionInfo"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> ClassifierID 
            {
              get { return this.GetPropertyState<global::System.Int32?>("ClassifierID"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> PredictedClass 
            {
              get { return this.GetPropertyState<global::System.String>("PredictedClass"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Double?> Probability 
            {
              get { return this.GetPropertyState<global::System.Double?>("Probability"); }
            }


    protected internal EntityRecognitionInfoAdditionalClassifiersPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class EntityRecognitionInfoAdditionalClassifiersCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersCollectionPropertyState<T>
    where T : global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers
  {
    public new global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal EntityRecognitionInfoAdditionalClassifiersCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class EntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState EntityRecognitionInfo
        {
          get { return this.GetChildPropertySummaryState("EntityRecognitionInfo"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ClassifierID
        {
          get { return this.GetChildPropertySummaryState("ClassifierID"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState PredictedClass
        {
          get { return this.GetChildPropertySummaryState("PredictedClass"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Probability
        {
          get { return this.GetChildPropertySummaryState("Probability"); }
        }


    protected internal EntityRecognitionInfoAdditionalClassifiersCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// EntityRecognitionInfoAdditionalClassifiersInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class EntityRecognitionInfoAdditionalClassifiersInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersInfo
  {
    public EntityRecognitionInfoAdditionalClassifiersInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertiesInfo Properties
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersPropertiesInfo(entityType);
    }

  }

  public class EntityRecognitionInfoAdditionalClassifiersPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Commons.IEntityRecognitionInfoInfo, global::Sungero.Commons.IEntityRecognitionInfo> EntityRecognitionInfo 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("EntityRecognitionInfo");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Commons.IEntityRecognitionInfoInfo, global::Sungero.Commons.IEntityRecognitionInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo ClassifierID 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("ClassifierID");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo PredictedClass 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("PredictedClass");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDoublePropertyInfo Probability 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DoublePropertyMetadata>("Probability");
             return new global::Sungero.Domain.Shared.DoublePropertyInfo(propertyMetadata);
          }
        }


    protected internal EntityRecognitionInfoAdditionalClassifiersPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
