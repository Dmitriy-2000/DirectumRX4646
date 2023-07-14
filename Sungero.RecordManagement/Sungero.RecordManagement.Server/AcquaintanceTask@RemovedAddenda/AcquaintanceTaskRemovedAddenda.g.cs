
// ==================================================================
// AcquaintanceTaskRemovedAddenda.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{


  public class AcquaintanceTaskRemovedAddenda :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddenda
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b37e7bed-745a-4840-8108-a008843d3586");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceTaskRemovedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceTaskRemovedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddendaState State
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddendaState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskRemovedAddendaState(this);
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddendaInfo Info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddendaInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IAcquaintanceTask AcquaintanceTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceTask; }
      set { this.AcquaintanceTask = (global::Sungero.RecordManagement.IAcquaintanceTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskRemovedAddendaSharedHandlers(this);
    }

    private global::System.Int32? _AddendumId;
    public virtual global::System.Int32? AddendumId
    {
      get
      {
        return this._AddendumId;
      }

      set
      {
        this.SetPropertyValue("AddendumId", this._AddendumId, value, (propertyValue) => { this._AddendumId = propertyValue; }, this.AddendumIdChangedHandler);
      }
    }










    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskRemovedAddendaSharedHandlers)this.SharedHandlers).RemovedAddendaAddendumIdChanged(args);
    }



    #endregion


    public AcquaintanceTaskRemovedAddenda()
    {
    }

  }
}

// ==================================================================
// AcquaintanceTaskRemovedAddendaHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

}

// ==================================================================
// AcquaintanceTaskRemovedAddendaEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}