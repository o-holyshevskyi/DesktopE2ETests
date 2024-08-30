using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace DriverCore;

public class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IWinDriver, WinDriver>();
    }
}
