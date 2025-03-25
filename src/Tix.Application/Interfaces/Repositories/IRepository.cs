namespace Tix.Application.Interfaces.Repositories;

public interface IRepository
{
    bool Any();
    int Count();
}

public interface IRepository<T> : IRepository
{
    IQueryable<T> Query();

    T Create(T entity);
    IEnumerable<T> CreateRange(IEnumerable<T> entities);

    T Update(T entity);
    IEnumerable<T> UpdateRange(IEnumerable<T> entities);

    T Delete(T entity);
    IEnumerable<T> DeleteRange(IEnumerable<T> entities);

    Task<T> CreateAsync(T entity, CancellationToken token = default);
    Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities, CancellationToken token = default);

    Task<T> UpdateAsync(T entity, CancellationToken token = default);
    Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities, CancellationToken token = default);

    Task<T> DeleteAsync(T entity, CancellationToken token = default);
    Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities, CancellationToken token = default);
}

public interface IRepository<T, TId> : IRepository<T>
{
    T Get(TId id);
    T GetRange(IEnumerable<TId> ids);

    T Delete(TId id);
    IEnumerable<T> DeleteRange(IEnumerable<TId> ids);

    Task<T> GetAsync(TId id, CancellationToken token = default);
    Task<T> GetRangeAsync(IEnumerable<TId> ids, CancellationToken token = default);

    Task<T> DeleteAsync(TId id, CancellationToken token = default);
    Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<TId> ids, CancellationToken token = default);
}