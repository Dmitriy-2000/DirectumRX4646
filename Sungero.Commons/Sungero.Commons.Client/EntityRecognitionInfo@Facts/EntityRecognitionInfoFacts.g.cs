
// ==================================================================
// EntityRecognitionInfoFacts.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class EntityRecognitionInfoFacts :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Commons.IEntityRecognitionInfoFacts
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ea588697-56d5-4a14-9a78-39fa6517351b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Client.EntityRecognitionInfoFacts.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.IEntityRecognitionInfoFacts, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Commons.IEntityRecognitionInfoFactsState State
    {
      get
      {
        return (global::Sungero.Commons.IEntityRecognitionInfoFactsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoFactsState(this);
    }

    public new global::Sungero.Commons.IEntityRecognitionInfoFactsInfo Info
    {
      get
      {
        return (global::Sungero.Commons.IEntityRecognitionInfoFactsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Commons.IEntityRecognitionInfo> _EntityRecognitionInfo;

    public global::Sungero.Commons.IEntityRecognitionInfo EntityRecognitionInfo
    {
      get { return this._EntityRecognitionInfo.Value; }
      set { this._EntityRecognitionInfo.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.EntityRecognitionInfo; }
      set { this.EntityRecognitionInfo = (global::Sungero.Commons.IEntityRecognitionInfo)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _FactId;

        public virtual global::System.Int32? FactId
        {
          get { return this._FactId.Value; }
          set { this._FactId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _FieldId;

        public virtual global::System.Int32? FieldId
        {
          get { return this._FieldId.Value; }
          set { this._FieldId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _PropertyName;

        public virtual global::System.String PropertyName
        {
          get { return this._PropertyName.Value; }
          set { this._PropertyName.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _PropertyValue;

        public virtual global::System.String PropertyValue
        {
          get { return this._PropertyValue.Value; }
          set { this._PropertyValue.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FactName;

        public virtual global::System.String FactName
        {
          get { return this._FactName.Value; }
          set { this._FactName.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FieldName;

        public virtual global::System.String FieldName
        {
          get { return this._FieldName.Value; }
          set { this._FieldName.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FieldValue;

        public virtual global::System.String FieldValue
        {
          get { return this._FieldValue.Value; }
          set { this._FieldValue.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Double?> _FieldProbability;

        public virtual global::System.Double? FieldProbability
        {
          get { return this._FieldProbability.Value; }
          set { this._FieldProbability.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _VerifiedValue;

        public virtual global::System.String VerifiedValue
        {
          get { return this._VerifiedValue.Value; }
          set { this._VerifiedValue.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FactLabel;

        public virtual global::System.String FactLabel
        {
          get { return this._FactLabel.Value; }
          set { this._FactLabel.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _CollectionRecordId;

        public virtual global::System.Int32? CollectionRecordId
        {
          get { return this._CollectionRecordId.Value; }
          set { this._CollectionRecordId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Double?> _Probability;

        public virtual global::System.Double? Probability
        {
          get { return this._Probability.Value; }
          set { this._Probability.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Double?> _FieldConfidence;

        public virtual global::System.Double? FieldConfidence
        {
          get { return this._FieldConfidence.Value; }
          set { this._FieldConfidence.Value = value; }
        }








      protected global::Sungero.Domain.Client.TextProperty _Position;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Position
      {
        get { return this._Position.Value; }
        set { this._Position.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.EntityRecognitionInfoFactsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void FactIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.FactId, this.FactId, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFactIdChanged(args);
    }

    protected void FieldIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.FieldId, this.FieldId, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFieldIdChanged(args);
    }

    protected void PropertyNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.PropertyName, this.PropertyName, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsPropertyNameChanged(args);
    }

    protected void PropertyValueChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.PropertyValue, this.PropertyValue, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsPropertyValueChanged(args);
    }

    protected void FactNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FactName, this.FactName, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFactNameChanged(args);
    }

    protected void FieldNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FieldName, this.FieldName, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFieldNameChanged(args);
    }

    protected void FieldValueChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FieldValue, this.FieldValue, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFieldValueChanged(args);
    }

    protected void FieldProbabilityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs(this.State.Properties.FieldProbability, this.FieldProbability, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFieldProbabilityChanged(args);
    }

    protected void PositionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Position, this.Position, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsPositionChanged(args);
    }

    protected void VerifiedValueChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.VerifiedValue, this.VerifiedValue, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsVerifiedValueChanged(args);
    }

    protected void FactLabelChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FactLabel, this.FactLabel, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFactLabelChanged(args);
    }

    protected void CollectionRecordIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.CollectionRecordId, this.CollectionRecordId, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsCollectionRecordIdChanged(args);
    }

    protected void ProbabilityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs(this.State.Properties.Probability, this.Probability, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsProbabilityChanged(args);
    }

    protected void FieldConfidenceChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs(this.State.Properties.FieldConfidence, this.FieldConfidence, this);
     ((global::Sungero.Commons.IEntityRecognitionInfoFactsSharedHandlers)this.SharedHandlers).FactsFieldConfidenceChanged(args);
    }



  protected global::System.Int32? FactIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.FactId, value, this, this.Info.Properties.FactId);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFactIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? FieldIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.FieldId, value, this, this.Info.Properties.FieldId);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFieldIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PropertyNameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.PropertyName, value, this, this.Info.Properties.PropertyName);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsPropertyNameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PropertyValueValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.PropertyValue, value, this, this.Info.Properties.PropertyValue);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsPropertyValueValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FactNameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FactName, value, this, this.Info.Properties.FactName);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFactNameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FieldNameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FieldName, value, this, this.Info.Properties.FieldName);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFieldNameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FieldValueValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FieldValue, value, this, this.Info.Properties.FieldValue);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFieldValueValueInput(args);
    return args.NewValue;
  }

  protected global::System.Double? FieldProbabilityValueInputHandler(global::System.Double? value)
  {
    var args = new global::Sungero.Presentation.DoubleValueInputEventArgs(this.FieldProbability, value, this, this.Info.Properties.FieldProbability);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFieldProbabilityValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PositionValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Position, value, this, this.Info.Properties.Position);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsPositionValueInput(args);
    return args.NewValue;
  }

  protected global::System.String VerifiedValueValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.VerifiedValue, value, this, this.Info.Properties.VerifiedValue);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsVerifiedValueValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FactLabelValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FactLabel, value, this, this.Info.Properties.FactLabel);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFactLabelValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? CollectionRecordIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.CollectionRecordId, value, this, this.Info.Properties.CollectionRecordId);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsCollectionRecordIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Double? ProbabilityValueInputHandler(global::System.Double? value)
  {
    var args = new global::Sungero.Presentation.DoubleValueInputEventArgs(this.Probability, value, this, this.Info.Properties.Probability);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsProbabilityValueInput(args);
    return args.NewValue;
  }

  protected global::System.Double? FieldConfidenceValueInputHandler(global::System.Double? value)
  {
    var args = new global::Sungero.Presentation.DoubleValueInputEventArgs(this.FieldConfidence, value, this, this.Info.Properties.FieldConfidence);
    ((global::Sungero.Commons.EntityRecognitionInfoFactsClientHandlers)this.Handlers).FactsFieldConfidenceValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public EntityRecognitionInfoFacts()
    {
      this._EntityRecognitionInfo = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Commons.IEntityRecognitionInfo>("EntityRecognitionInfo", this, true);

            this._FactId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("FactId", this);
            this._FactId.ValueChanged += (sender, e) => { this.FactIdChangedHandler(); };
            this.AddProperty(this._FactId);

            this._FieldId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("FieldId", this);
            this._FieldId.ValueChanged += (sender, e) => { this.FieldIdChangedHandler(); };
            this.AddProperty(this._FieldId);

            this._PropertyName = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("PropertyName", this);
            this._PropertyName.ValueChanged += (sender, e) => { this.PropertyNameChangedHandler(); };
            this.AddProperty(this._PropertyName);

            this._PropertyValue = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("PropertyValue", this);
            this._PropertyValue.ValueChanged += (sender, e) => { this.PropertyValueChangedHandler(); };
            this.AddProperty(this._PropertyValue);

            this._FactName = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FactName", this);
            this._FactName.ValueChanged += (sender, e) => { this.FactNameChangedHandler(); };
            this.AddProperty(this._FactName);

            this._FieldName = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FieldName", this);
            this._FieldName.ValueChanged += (sender, e) => { this.FieldNameChangedHandler(); };
            this.AddProperty(this._FieldName);

            this._FieldValue = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FieldValue", this);
            this._FieldValue.ValueChanged += (sender, e) => { this.FieldValueChangedHandler(); };
            this.AddProperty(this._FieldValue);

            this._FieldProbability = new global::Sungero.Domain.Client.SimpleProperty<global::System.Double?>("FieldProbability", this);
            this._FieldProbability.ValueChanged += (sender, e) => { this.FieldProbabilityChangedHandler(); };
            this.AddProperty(this._FieldProbability);

            this._VerifiedValue = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("VerifiedValue", this);
            this._VerifiedValue.ValueChanged += (sender, e) => { this.VerifiedValueChangedHandler(); };
            this.AddProperty(this._VerifiedValue);

            this._FactLabel = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FactLabel", this);
            this._FactLabel.ValueChanged += (sender, e) => { this.FactLabelChangedHandler(); };
            this.AddProperty(this._FactLabel);

            this._CollectionRecordId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("CollectionRecordId", this);
            this._CollectionRecordId.ValueChanged += (sender, e) => { this.CollectionRecordIdChangedHandler(); };
            this.AddProperty(this._CollectionRecordId);

            this._Probability = new global::Sungero.Domain.Client.SimpleProperty<global::System.Double?>("Probability", this);
            this._Probability.ValueChanged += (sender, e) => { this.ProbabilityChangedHandler(); };
            this.AddProperty(this._Probability);

            this._FieldConfidence = new global::Sungero.Domain.Client.SimpleProperty<global::System.Double?>("FieldConfidence", this);
            this._FieldConfidence.ValueChanged += (sender, e) => { this.FieldConfidenceChangedHandler(); };
            this.AddProperty(this._FieldConfidence);



            this._Position = new global::Sungero.Domain.Client.TextProperty("Position", this);
            this._Position.ValueChanged += (sender, e) => { this.PositionChangedHandler(); };
            this.AddProperty(this._Position);






    }

    #endregion

  }
}
