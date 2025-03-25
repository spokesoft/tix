using Tix.Application.Interfaces.Repositories;

namespace Tix.Infrastructure.Repositories;

public abstract class RepositoryBase : IRepository
{
    public bool Any()
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        throw new NotImplementedException();
    }
}

public abstract class RepositoryBase<T> : RepositoryBase, IRepository<T>
{
    public T Create(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> CreateAsync(T entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> CreateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public T Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(T entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> DeleteRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Query()
    {
        throw new NotImplementedException();
    }

    public T Update(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> UpdateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}

public abstract class RepositoryBase<T, TId> : RepositoryBase<T>, IRepository<T, TId>
{
    public T Delete(TId id)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(TId id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> DeleteRange(IEnumerable<TId> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<TId> ids, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public T Get(TId id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync(TId id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public T GetRange(IEnumerable<TId> ids)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetRangeAsync(IEnumerable<TId> ids, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}