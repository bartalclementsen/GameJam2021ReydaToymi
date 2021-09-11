using Core.Containers;
using Core.Loggers;
using Core.Mediators;
using System;
using UnityEngine;

public class Game
{
    private static IContainer container;
    public static IContainer Container
    {
        get
        {
            if (container == null)
                Bootstrap();
            return container;
        }
    }

    private static Core.Loggers.ILogger _logger;

    [RuntimeInitializeOnLoadMethod]
    private static void Main()
    {
        _logger = Container.Resolve<ILoggerFactory>().Create(null);

        _logger.Log("Main");
    }

    private static void Bootstrap()
    {
        Debug.Log("Starting bootstrap");

        ContainerBuilder containerBuilder = new ContainerBuilder();

        containerBuilder.Register<ILoggerFactory, LoggerFactory>();
        containerBuilder.RegisterSingleton<IMessenger, Messenger>();

        container = containerBuilder.Build();

        Debug.Log("Done bootstrap");
    }
}
