using ClientSession;
using Configurations;
using DriverCore;
using Logger;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Utils.DI;

namespace GlobalSetup;

public static class GlobalTestSetup
{
    public static void SetupDependencies()
    {
        var serviceCollection = new ServiceCollection();

        var assemblies = new[]
        {
            Assembly.GetAssembly(typeof(ILogger)),
            Assembly.GetAssembly(typeof(IWinDriver)),
            Assembly.GetAssembly(typeof(IClient)),
            Assembly.GetAssembly(typeof(IConfig)),
        };

        var injectMethods = assemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract)
                .SelectMany(t => t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                .Where(m => m.GetCustomAttribute<DependencyInjectionAttribute>() != null)
                .ToList();

        var parameters = new object[] { serviceCollection };

        injectMethods.ForEach(method =>
        {
            method.Invoke(null, parameters);
        });

        var serviceProvider = serviceCollection.BuildServiceProvider();
        ServiceLocator.SetLocatorProvider(serviceProvider);
    }
}
