using AspNetCoreCleanArchitecture.Infrastructure.Common.Database;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreCleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IAppDbContext, AppDbContext>();

        services.AddScoped<IProductRepository, ProductRepository>();
        
        return services;
    }
}