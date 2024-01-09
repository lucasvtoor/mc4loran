using Injectors;
using Managers;
using Servers;
using Settings;

var injector = Injector.CreateDefaultInjector().Configure(inj =>
{
    inj.SettingsManager = new SettingsManager
    {
        SeedSetting = new SeedSetting("123"),
        PortSetting = new PortSetting("25543"),
        ChunkSizeSetting = new ChunkSizeSetting("16"),
        LogLevelSetting = new LogLevelSetting("1"),
        LogLocationSetting = new LogLocationSetting("1"),
        HostNameSetting = new HostNameSetting("127.0.0.1")
    };
    return inj;
}).Build();


var server = new Server(injector);