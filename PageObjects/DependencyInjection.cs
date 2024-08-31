using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace PageObjects;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IForm, Forms>();
    }
}
