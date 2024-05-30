using Blitz.Exercises.Data.Models;

namespace Blitz.Exercises.Data.Repositories.Interfaces.Core;

public interface ICollectionRepository<out TEntity, in TKey>
    where TEntity : Entity
    where TKey : struct
{
    IQueryable<TEntity> GetAll();
}