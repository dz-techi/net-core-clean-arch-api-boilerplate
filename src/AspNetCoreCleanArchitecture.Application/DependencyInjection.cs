using AspNetCoreCleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreCleanArchitecture.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddInfrastructure();

        return services;
    }
}