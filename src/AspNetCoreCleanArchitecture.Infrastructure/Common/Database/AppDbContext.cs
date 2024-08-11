using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Database;

public class AppDbContext
{
    private readonly IMongoDatabase _database;
    
    public AppDbContext(IOptions<MongoDbSettings> mongoDbSettings)
    {
        var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
        
        _database = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}