using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

public interface IFullRepository<TEntity, in TKey> : ICreateRepository<TEntity>, IReadRepository<TEntity, TKey>,
    IUpdateRepository<TEntity, TKey>, ICollectionRepository<TEntity, TKey>, IDeleteRepository<TEntity>
    where TEntity : Entity
    where TKey : struct
{
    // Implied by ICollectionRepository + ICreateRepository association
    Task CreateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    
    // Implied by ICollectionRepository + IUpdateRepository association
    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    
    // Implied by ICollectionRepository + IDeleteRepository association
    Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
}