
// ==================================================================
// EntityRecognitionInfoAdditionalClassifiers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{


  public class EntityRecognitionInfoAdditionalClassifiers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("977c2af3-1cde-4f76-a516-b6c36ad031dd");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Server.EntityRecognitionInfoAdditionalClassifiers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersState State
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersState(this);
    }

    public new virtual global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersInfo Info
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersInfo)base.Info; }
    }


    public global::Sungero.Commons.IEntityRecognitionInfo EntityRecognitionInfo { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.EntityRecognitionInfo; }
      set { this.EntityRecognitionInfo = (global::Sungero.Commons.IEntityRecognitionInfo)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersSharedHandlers(this);
    }

    private global::System.Int32? _ClassifierID;
    public virtual global::System.Int32? ClassifierID
    {
      get
      {
        return this._ClassifierID;
      }

      set
      {
        this.SetPropertyValue("ClassifierID", this._ClassifierID, value, (propertyValue) => { this._ClassifierID = propertyValue; }, this.ClassifierIDChangedHandler);
      }
    }
    private global::System.String _PredictedClass;
    public virtual global::System.String PredictedClass
    {
      get
      {
        return this._PredictedClass;
      }

      set
      {
        this.SetPropertyValue("PredictedClass", this._PredictedClass, value, (propertyValue) => { this._PredictedClass = propertyValue; }, this.PredictedClassChangedHandler);
      }
    }
    private global::System.Double? _Probability;
    public virtual global::System.Double? Probability
    {
      get
      {
        return this._Probability;
      }

      set
      {
        this.SetPropertyValue("Probability", this._Probability, value, (propertyValue) => { this._Probability = propertyValue; }, this.ProbabilityChangedHandler);
      }
    }










    #region Framework events

    protected void ClassifierIDChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ClassifierID, this.ClassifierID, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersClassifierIDChanged(args);
    }

    protected void PredictedClassChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.PredictedClass, this.PredictedClass, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersPredictedClassChanged(args);
    }

    protected void ProbabilityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs(this.State.Properties.Probability, this.Probability, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersProbabilityChanged(args);
    }



    #endregion


    public EntityRecognitionInfoAdditionalClassifiers()
    {
    }

  }
}

// ==================================================================
// EntityRecognitionInfoAdditionalClassifiersHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{

}

// ==================================================================
// EntityRecognitionInfoAdditionalClassifiersEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}
