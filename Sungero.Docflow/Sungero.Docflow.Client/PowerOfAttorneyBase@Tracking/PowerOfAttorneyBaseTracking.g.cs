
// ==================================================================
// PowerOfAttorneyBaseTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class PowerOfAttorneyBaseTracking :
    global::Sungero.Docflow.Client.InternalDocumentBaseTracking, global::Sungero.Docflow.IPowerOfAttorneyBaseTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("357f5402-4b15-4c09-99d0-dd3d22e33d66");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.PowerOfAttorneyBaseTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyBaseTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyBaseTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyBaseTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyBaseTrackingState(this);
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyBaseTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyBaseTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public PowerOfAttorneyBaseTracking()
    {








    }

    #endregion

  }
}
