using System;
using System.Collections.Generic;
using Managers;
using Util.Logging;

namespace Injectors;

public class Injector
{
    public T Get<T>()
    {
        return (T)Inner[typeof(T)];
    }
    public Dictionary<Type, object> Inner = new Dictionary<Type, object>();
    public Injector()
    {
        var loggerFactory = new LoggerFactory(LogLevel.Info, LogLocation.Console);
        Inner[typeof(SettingsManager)] = new SettingsManager();
        Inner[typeof(LoggerFactory)] = loggerFactory;
        Inner[typeof(PlayerManager)] = new PlayerManager(loggerFactory);
        Inner[typeof(ServerManager)] = new ServerManager();
    }
    public static InjectorFactory CreateDefaultInjector()
    {
        return new InjectorFactory()
        {
            Injector = new()
            {

            }
        };
    }

    public class InjectorFactory
    {
        public Injector Injector;

        public Injector Build()
        {
            return Injector;
        }
    }
}