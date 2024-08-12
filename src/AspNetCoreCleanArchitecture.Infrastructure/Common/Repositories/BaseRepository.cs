using AspNetCoreCleanArchitecture.Domain.Common;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Database;
using AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories.Interfaces;
using MongoDB.Driver;

namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private IMongoCollection<T> Collection { get; }

    protected abstract string CollectionName { get; }    
    
    protected BaseRepository(IAppDbContext appDbContext)
    {
        Collection = appDbContext.GetCollection<T>(CollectionName);    
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var filter = Builders<T>.Filter.Eq(e => e.Id, id);

        return await Collection.Find(filter).SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<T?> AddAsync(T entityDto, CancellationToken cancellationToken)
    {
        await Collection.InsertOneAsync(entityDto, cancellationToken: cancellationToken);

        return entityDto;
    }
}