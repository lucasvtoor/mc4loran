using Managers;
using Util.Logging;

namespace Injectors;

public class Injector
{
    public SettingsManager SettingsManager;
    public PlayerManager PlayerManager;
    public ServerManager ServerManager;
    public LoggerFactory LoggerFactory;

    public static InjectorFactory CreateDefaultInjector()
    {
        var loggerFactory = new LoggerFactory(LogLevel.Info, LogLocation.Console);
        return new InjectorFactory()
        {
            Injector = new()
            {
                SettingsManager = new SettingsManager(),
                LoggerFactory = loggerFactory,
                PlayerManager = new PlayerManager(loggerFactory),
                ServerManager = new ServerManager()
            }
        };
    }

    public class InjectorFactory
    {
        public Injector Injector;

        private InjectorFactory AddSettingsManager(Func<SettingsManager, SettingsManager> manager)
        {
            Injector.SettingsManager = manager.Invoke(new SettingsManager());
            return this;
        }

        private InjectorFactory AddPlayerManager(Func<PlayerManager, PlayerManager> manager)
        {
            Injector.PlayerManager = manager.Invoke(new PlayerManager(Injector.LoggerFactory));
            return this;
        }

        private InjectorFactory AddServerManager(Func<ServerManager, ServerManager> manager)
        {
            Injector.ServerManager = manager.Invoke(new ServerManager());
            return this;
        }

        public InjectorFactory Configure(Func<Injector, Injector> func)
        {
            Injector = func.Invoke(Injector);
            return this;
        }

        public Injector Build()
        {
            return Injector;
        }
    }
}