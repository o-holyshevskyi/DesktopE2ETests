using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace ClientSession;

public class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IClient, Client>();
    }
}
