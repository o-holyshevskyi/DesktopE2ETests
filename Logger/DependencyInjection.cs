using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace Logger;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<ILogger, LoggerManager>();
    }
}
