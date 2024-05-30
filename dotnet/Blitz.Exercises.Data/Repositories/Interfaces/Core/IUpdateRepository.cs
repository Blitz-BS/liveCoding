using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

public interface IUpdateRepository<TEntity, in TKey>
    where TEntity : Entity
    where TKey : struct
{
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
}