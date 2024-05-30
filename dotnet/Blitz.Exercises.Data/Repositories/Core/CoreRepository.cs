using Blitz.Exercises.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blitz.Exercises.Data.Repositories.Core;

public abstract class CoreRepository<TEntity> : IDisposable
    where TEntity : Entity
{
    /// <summary>
    /// Context MUST NOT be seen by inheritors. This way, we can ensure that each repository handles only the
    /// entities it is meant to.
    /// </summary>
    private readonly Context _context;

    protected readonly DbSet<TEntity> _entities;

    protected CoreRepository(IDbContextFactory<Context> contextFactory)
    {
        _context = contextFactory.CreateDbContext();
        _entities = _context.Set<TEntity>();
    }

    /// <summary>
    /// Allows inheritors to use context in order to save changes made to entities.
    /// </summary>
    /// <param name="cancellationToken">Request cancellation token.</param>
    /// <returns>Save operation result.</returns>
    protected async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}