using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

public interface IDeleteRepository<in TEntity>
    where TEntity : Entity
{
    Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
}