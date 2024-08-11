namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Database;

public class MongoDbSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;
}