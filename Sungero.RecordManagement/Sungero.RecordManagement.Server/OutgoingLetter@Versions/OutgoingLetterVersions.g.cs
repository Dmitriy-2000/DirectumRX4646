
// ==================================================================
// OutgoingLetterVersions.g.cs
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


  public class OutgoingLetterVersions :
    global::Sungero.Docflow.Server.OutgoingDocumentBaseVersions, global::Sungero.RecordManagement.IOutgoingLetterVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f15b30f3-99b5-49d7-9452-770b3925ae41");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.OutgoingLetterVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IOutgoingLetterVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IOutgoingLetterVersionsState State
    {
      get { return (global::Sungero.RecordManagement.IOutgoingLetterVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.OutgoingLetterVersionsState(this);
    }

    public new virtual global::Sungero.RecordManagement.IOutgoingLetterVersionsInfo Info
    {
      get { return (global::Sungero.RecordManagement.IOutgoingLetterVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public OutgoingLetterVersions()
    {
    }

  }
}

// ==================================================================
// OutgoingLetterVersionsHandlers.g.cs
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
// OutgoingLetterVersionsEventArgs.g.cs
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
