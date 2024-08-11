using AspNetCoreCleanArchitecture.Infrastructure.Common.Database;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreCleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<AppDbContext>();

        return services;
    }
}