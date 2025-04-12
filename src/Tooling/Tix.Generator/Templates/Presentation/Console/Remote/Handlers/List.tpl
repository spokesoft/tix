using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.List;

namespace Tix.Console.Remote.Handlers.List;

public class RemoteList{{ plural }}Handler : IList{{ plural }}Handler
{
    public Task<IEnumerable<{{ name }}ListItemDto>> ExecuteAsync(Get{{ name }}ListQuery query, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}