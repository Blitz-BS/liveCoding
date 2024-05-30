using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

/// <summary>
/// Describes the methods a standard repository (with all CRUD operations) must implement.
/// </summary>
/// <typeparam name="TEntity">The type of the entity the repository is supposed to handle.</typeparam>
/// <typeparam name="TKey">The type of the entity's primary key.</typeparam>
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