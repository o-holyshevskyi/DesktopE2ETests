using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace Selectors;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<ISelectorService, SelectorService>();
    }
}
