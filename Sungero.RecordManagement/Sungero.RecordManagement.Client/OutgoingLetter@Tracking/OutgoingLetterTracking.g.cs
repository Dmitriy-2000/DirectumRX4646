
// ==================================================================
// OutgoingLetterTracking.g.cs
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
  public class OutgoingLetterTracking :
    global::Sungero.Docflow.Client.OutgoingDocumentBaseTracking, global::Sungero.RecordManagement.IOutgoingLetterTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0a340145-d37f-43bc-9376-8a3196327b25");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.OutgoingLetterTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IOutgoingLetterTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IOutgoingLetterTrackingState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IOutgoingLetterTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.OutgoingLetterTrackingState(this);
    }

    public new global::Sungero.RecordManagement.IOutgoingLetterTrackingInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IOutgoingLetterTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public OutgoingLetterTracking()
    {








    }

    #endregion

  }
}