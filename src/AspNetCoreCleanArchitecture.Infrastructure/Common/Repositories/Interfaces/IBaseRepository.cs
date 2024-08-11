using AspNetCoreCleanArchitecture.Domain.Common;

namespace AspNetCoreCleanArchitecture.Infrastructure.Common.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}