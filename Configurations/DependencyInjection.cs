using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace Configurations;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IConfig, SessionConfiguration>();
    }
}
