using Blitz.Exercises.Data.Models;
using Blitz.Exercises.Data.Repositories.Interfaces.Core;
using Microsoft.EntityFrameworkCore;

namespace Blitz.Exercises.Data.Repositories.Core;

public abstract class FullRepository<TEntity, TKey>(IDbContextFactory<Context> contextFactory)
    : CoreRepository<TEntity>(contextFactory), IFullRepository<TEntity, TKey>
    where TEntity : Entity
    where TKey : struct
{
    public virtual TEntity Get(TKey id)
    {
        return _entities.Find(id);
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return _entities.AsQueryable();
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity, bool saveChanges = true,
        CancellationToken cancellationToken = default)
    {
        _entities.Add(entity);
        
        if (saveChanges)
        {
            await SaveChangesAsync(cancellationToken);
        }

        return entity;
    }

    public virtual async Task CreateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        _entities.AddRange(entities);
        await SaveChangesAsync(cancellationToken);
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _entities.Update(entity);
        await SaveChangesAsync(cancellationToken);

        return entity;
    }

    public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        _entities.UpdateRange(entities);
        await SaveChangesAsync(cancellationToken);
    }

    public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _entities.Remove(entity);
        await SaveChangesAsync(cancellationToken);
    }

    public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        _entities.RemoveRange(entities);
        await SaveChangesAsync(cancellationToken);
    }
}