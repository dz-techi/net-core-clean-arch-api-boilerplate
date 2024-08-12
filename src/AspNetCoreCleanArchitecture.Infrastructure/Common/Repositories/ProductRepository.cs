using AspNetCoreCleanArchitecture.Domain.Models;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Database;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories.Interfaces;

namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories;

public class ProductRepository : BaseRepository<ProductDto>, IProductRepository
{
    protected override string CollectionName => "products";
    
    public ProductRepository(IAppDbContext appDbContext) : base(appDbContext)
    {
    }
}