﻿using Microsoft.Extensions.DependencyInjection;
using Utils.DI;

namespace ClientSession;

internal class DependencyInjection
{
    [DependencyInjection]
    public static void Inject(IServiceCollection services)
    {
        services.AddSingleton<IClient, Client>();
    }
}
