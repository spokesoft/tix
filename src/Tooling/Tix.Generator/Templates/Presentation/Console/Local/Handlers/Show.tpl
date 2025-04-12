using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Show;

namespace Tix.Console.Local.Handlers.Show;

public class LocalShow{{ name }}Handler(
    Get{{ name }}ByIdHandler handler) : IShow{{ name }}Handler
{
    private readonly Get{{ name }}ByIdHandler _handler = handler;
    public async Task<{{ name }}DetailsDto> ExecuteAsync(Get{{ name }}ByIdQuery command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}