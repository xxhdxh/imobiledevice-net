//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iMobileDevice
{
    using iMobileDevice.Usbmuxd;
    using iMobileDevice.Plist;
    using iMobileDevice.iDeviceActivation;
    using iMobileDevice.Recovery;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.CompanionProxy;
    using iMobileDevice.DebugServer;
    using iMobileDevice.DiagnosticsRelay;
    using iMobileDevice.FileRelay;
    using iMobileDevice.HeartBeat;
    using iMobileDevice.HouseArrest;
    using iMobileDevice.InstallationProxy;
    using iMobileDevice.Misagent;
    using iMobileDevice.Mobileactivation;
    using iMobileDevice.MobileBackup;
    using iMobileDevice.MobileBackup2;
    using iMobileDevice.MobileSync;
    using iMobileDevice.MobileImageMounter;
    using iMobileDevice.NotificationProxy;
    using iMobileDevice.Pinvoke;
    using iMobileDevice.Preboard;
    using iMobileDevice.PropertyListService;
    using iMobileDevice.Restore;
    using iMobileDevice.SpringBoardServices;
    using iMobileDevice.Screenshotr;
    using iMobileDevice.Service;
    using iMobileDevice.SyslogRelay;
    using iMobileDevice.WebInspector;
    
    
    public interface ILibiMobileDevice
    {
        
        IUsbmuxdApi Usbmuxd
        {
            get;
        }
        
        IPlistApi Plist
        {
            get;
        }
        
        IiDeviceActivationApi iDeviceActivation
        {
            get;
        }
        
        IRecoveryApi Recovery
        {
            get;
        }
        
        IiDeviceApi iDevice
        {
            get;
        }
        
        ILockdownApi Lockdown
        {
            get;
        }
        
        IAfcApi Afc
        {
            get;
        }
        
        ICompanionProxyApi CompanionProxy
        {
            get;
        }
        
        IDebugServerApi DebugServer
        {
            get;
        }
        
        IDiagnosticsRelayApi DiagnosticsRelay
        {
            get;
        }
        
        IFileRelayApi FileRelay
        {
            get;
        }
        
        IHeartBeatApi HeartBeat
        {
            get;
        }
        
        IHouseArrestApi HouseArrest
        {
            get;
        }
        
        IInstallationProxyApi InstallationProxy
        {
            get;
        }
        
        IMisagentApi Misagent
        {
            get;
        }
        
        IMobileactivationApi Mobileactivation
        {
            get;
        }
        
        IMobileBackupApi MobileBackup
        {
            get;
        }
        
        IMobileBackup2Api MobileBackup2
        {
            get;
        }
        
        IMobileSyncApi MobileSync
        {
            get;
        }
        
        IMobileImageMounterApi MobileImageMounter
        {
            get;
        }
        
        INotificationProxyApi NotificationProxy
        {
            get;
        }
        
        IPinvokeApi Pinvoke
        {
            get;
        }
        
        IPreboardApi Preboard
        {
            get;
        }
        
        IPropertyListServiceApi PropertyListService
        {
            get;
        }
        
        IRestoreApi Restore
        {
            get;
        }
        
        ISpringBoardServicesApi SpringBoardServices
        {
            get;
        }
        
        IScreenshotrApi Screenshotr
        {
            get;
        }
        
        IServiceApi Service
        {
            get;
        }
        
        ISyslogRelayApi SyslogRelay
        {
            get;
        }
        
        IWebInspectorApi WebInspector
        {
            get;
        }
        
        bool LibraryFound
        {
            get;
        }
    }
}
