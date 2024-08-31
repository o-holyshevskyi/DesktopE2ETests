using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace DriverCore;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IWinDriver, WinDriver>();
    }
}
