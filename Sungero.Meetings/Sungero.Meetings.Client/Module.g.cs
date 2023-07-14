
// ==================================================================
// Module.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{
  public partial class MeetingsModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("593dcc11-15ee-49f2-b4ef-bf4cf7867055"); }
    }

    public override string Name
    {
      get { return "Sungero.Meetings"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("5261da93-7879-4210-b3db-c92fa894ab4d"), new Sungero.Meetings.Shared.AgendaInfo(typeof(global::Sungero.Meetings.IAgenda)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Client.IAgendaClientPublicFunctions, global::Sungero.Meetings.Client.AgendaClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Shared.IAgendaSharedPublicFunctions, global::Sungero.Meetings.Shared.AgendaSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("231c12b0-800c-457a-a920-6f1a9f51f252"), new Sungero.Meetings.Shared.AgendaTrackingInfo(typeof(global::Sungero.Meetings.IAgendaTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("82b0455e-566e-4573-8651-c9c5b52a4dd1"), new Sungero.Meetings.Shared.AgendaVersionsInfo(typeof(global::Sungero.Meetings.IAgendaVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("dbc0dd63-4d23-4f41-92ae-cab59bb70c8c"), new Sungero.Meetings.Shared.MeetingInfo(typeof(global::Sungero.Meetings.IMeeting)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Client.IMeetingClientPublicFunctions, global::Sungero.Meetings.Client.MeetingClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Shared.IMeetingSharedPublicFunctions, global::Sungero.Meetings.Shared.MeetingSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("c6d29374-7baa-4442-96dc-b13aa3ff42b8"), new Sungero.Meetings.Shared.MeetingMembersInfo(typeof(global::Sungero.Meetings.IMeetingMembers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("bb4780ff-b2c3-4044-a390-e9e110791bf6"), new Sungero.Meetings.Shared.MinutesInfo(typeof(global::Sungero.Meetings.IMinutes)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Client.IMinutesClientPublicFunctions, global::Sungero.Meetings.Client.MinutesClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Shared.IMinutesSharedPublicFunctions, global::Sungero.Meetings.Shared.MinutesSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("64a4c377-e821-4c44-8333-47c7fd0a6027"), new Sungero.Meetings.Shared.MinutesTrackingInfo(typeof(global::Sungero.Meetings.IMinutesTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("c48ebf2d-dca8-4efd-bf1b-8c21302666ba"), new Sungero.Meetings.Shared.MinutesVersionsInfo(typeof(global::Sungero.Meetings.IMinutesVersions)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.IAgendaFilterState, global::Sungero.Meetings.Shared.Agenda.AgendaFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.IMeetingFilterState, global::Sungero.Meetings.Shared.Meeting.MeetingFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.IMinutesFilterState, global::Sungero.Meetings.Shared.Minutes.MinutesFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Client.IModuleClientPublicFunctions, global::Sungero.Meetings.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Meetings.Shared.IModuleSharedPublicFunctions, global::Sungero.Meetings.Shared.ModuleSharedPublicFunctions>();
    }
  }
}
