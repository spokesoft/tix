namespace Tix.Application.Interfaces.Infrastructure;

public interface IQueryHandler<TQuery, TDto> where TQuery : IQuery
{
    TDto Handle(TQuery request);
    Task<TDto> HandleAsync(TQuery request, CancellationToken token = default);
}