
// ==================================================================
// AgendaVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{


  public class AgendaVersions :
    global::Sungero.Docflow.Server.InternalDocumentBaseVersions, global::Sungero.Meetings.IAgendaVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("82b0455e-566e-4573-8651-c9c5b52a4dd1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Server.AgendaVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IAgendaVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Meetings.IAgendaVersionsState State
    {
      get { return (global::Sungero.Meetings.IAgendaVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.AgendaVersionsState(this);
    }

    public new virtual global::Sungero.Meetings.IAgendaVersionsInfo Info
    {
      get { return (global::Sungero.Meetings.IAgendaVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public AgendaVersions()
    {
    }

  }
}

// ==================================================================
// AgendaVersionsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{

}

// ==================================================================
// AgendaVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
}