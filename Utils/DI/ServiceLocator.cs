using Microsoft.Extensions.DependencyInjection;

namespace Utils.DI;

public static class ServiceLocator
{
    private static IServiceProvider _serviceProvider;

    public static void SetLocatorProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static T GetService<T>()
    {
        var service = _serviceProvider.GetRequiredService<T>();
        return service is not null ? service : throw new ArgumentNullException(nameof(service));
    }
}
