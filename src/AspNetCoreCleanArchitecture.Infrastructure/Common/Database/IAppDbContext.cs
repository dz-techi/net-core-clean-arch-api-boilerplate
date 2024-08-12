using MongoDB.Driver;

namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Database;

public interface IAppDbContext
{
    IMongoDatabase Database { get; set; }

    IMongoCollection<T> GetCollection<T>(string collectionName);
}