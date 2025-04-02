using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Queries;

public abstract class QueryHandler<TQuery, TDto>
    : IQueryHandler<TQuery, TDto> where TQuery : IQuery
{
    public TDto Handle(TQuery query) => HandleAsync(query, CancellationToken.None).Result;

    public abstract Task<TDto> HandleAsync(TQuery query, CancellationToken token = default);
}