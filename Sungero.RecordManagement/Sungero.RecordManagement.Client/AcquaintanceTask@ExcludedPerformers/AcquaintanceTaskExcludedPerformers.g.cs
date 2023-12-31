
// ==================================================================
// AcquaintanceTaskExcludedPerformers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskExcludedPerformers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8af4c702-7ab0-4fbb-b466-5dc39898c443");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceTaskExcludedPerformers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformersState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskExcludedPerformersState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformersInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceTask> _AcquaintanceTask;

    public global::Sungero.RecordManagement.IAcquaintanceTask AcquaintanceTask
    {
      get { return this._AcquaintanceTask.Value; }
      set { this._AcquaintanceTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceTask; }
      set { this.AcquaintanceTask = (global::Sungero.RecordManagement.IAcquaintanceTask)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _ExcludedPerformer;

              public virtual global::Sungero.CoreEntities.IRecipient ExcludedPerformer
              {
              get
              {
                return this._ExcludedPerformer.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._ExcludedPerformer as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskExcludedPerformersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskExcludedPerformersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ExcludedPerformerChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.AcquaintanceTaskExcludedPerformersExcludedPerformerChangedEventArgs(this.State.Properties.ExcludedPerformer, this.ExcludedPerformer, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskExcludedPerformersSharedHandlers)this.SharedHandlers).ExcludedPerformersExcludedPerformerChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient ExcludedPerformerValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.RecordManagement.Client.AcquaintanceTaskExcludedPerformersExcludedPerformerValueInputEventArgs(this.ExcludedPerformer, value, this, this.Info.Properties.ExcludedPerformer);
    ((global::Sungero.RecordManagement.AcquaintanceTaskExcludedPerformersClientHandlers)this.Handlers).ExcludedPerformersExcludedPerformerValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitExcludedPerformerNavigationProperty()
              {
                this._ExcludedPerformer = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("ExcludedPerformer", this);
                this._ExcludedPerformer.ValueChanged += (sender, e) => { this.ExcludedPerformerChangedHandler(); };
                this.AddProperty(this._ExcludedPerformer as global::Sungero.Domain.Client.IProperty);
              }




    public AcquaintanceTaskExcludedPerformers()
    {
      this._AcquaintanceTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceTask>("AcquaintanceTask", this, true);


            this.InitExcludedPerformerNavigationProperty();








    }

    #endregion

  }
}
