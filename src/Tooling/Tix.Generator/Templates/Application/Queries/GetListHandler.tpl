using Tix.Application.DTOs.{{ name }};

namespace Tix.Application.Queries.{{ name }};

public class Get{{ name }}ListHandler : QueryHandler<Get{{ name }}ListQuery, IEnumerable<{{ name }}ListItemDto>>
{
    public override async Task<IEnumerable<{{ name }}ListItemDto>> HandleAsync(Get{{ name }}ListQuery query, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        var list = new List<{{ name }}ListItemDto>();
        return await Task.FromResult(list);
    }
}