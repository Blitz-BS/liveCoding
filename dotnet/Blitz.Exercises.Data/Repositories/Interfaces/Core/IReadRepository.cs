using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

public interface IReadRepository<out TEntity, in TKey>
    where TEntity : Entity
    where TKey : struct
{
    TEntity Get(TKey id);
}