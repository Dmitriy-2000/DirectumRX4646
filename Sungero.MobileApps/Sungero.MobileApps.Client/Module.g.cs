
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

namespace Sungero.MobileApps.Client
{
  public partial class MobileAppsModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("1a7ef5ec-c6f4-47df-98c1-b3eae77dabae"); }
    }

    public override string Name
    {
      get { return "Sungero.MobileApps"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("210b9d5c-0218-43c5-b950-c69a65caec9b"), new Sungero.MobileApps.Shared.MobileAppSettingInfo(typeof(global::Sungero.MobileApps.IMobileAppSetting)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Client.IMobileAppSettingClientPublicFunctions, global::Sungero.MobileApps.Client.MobileAppSettingClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Shared.IMobileAppSettingSharedPublicFunctions, global::Sungero.MobileApps.Shared.MobileAppSettingSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("da51e62f-53fd-42df-94f0-8f22cf245197"), new Sungero.MobileApps.Shared.MobileAppSettingVisibleFoldersInfo(typeof(global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("2856cdf1-671b-41d1-a442-d1e0badff032"), new Sungero.MobileApps.Shared.MobileDeviceInfo(typeof(global::Sungero.MobileApps.IMobileDevice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Client.IMobileDeviceClientPublicFunctions, global::Sungero.MobileApps.Client.MobileDeviceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Shared.IMobileDeviceSharedPublicFunctions, global::Sungero.MobileApps.Shared.MobileDeviceSharedPublicFunctions>();


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.IMobileAppSettingFilterState, global::Sungero.MobileApps.Shared.MobileAppSetting.MobileAppSettingFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.IMobileDeviceFilterState, global::Sungero.MobileApps.Shared.MobileDevice.MobileDeviceFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Client.IModuleClientPublicFunctions, global::Sungero.MobileApps.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.MobileApps.Shared.IModuleSharedPublicFunctions, global::Sungero.MobileApps.Shared.ModuleSharedPublicFunctions>();
    }
  }
}