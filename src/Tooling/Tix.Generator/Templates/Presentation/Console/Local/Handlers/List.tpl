using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.List;

namespace Tix.Console.Local.Handlers.List;

public class LocalList{{ plural }}Handler(
    Get{{ name }}ListHandler handler) : IList{{ plural }}Handler
{
    private readonly Get{{ name }}ListHandler _handler = handler;
    public async Task<IEnumerable<{{ name }}ListItemDto>> ExecuteAsync(Get{{ name }}ListQuery command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}