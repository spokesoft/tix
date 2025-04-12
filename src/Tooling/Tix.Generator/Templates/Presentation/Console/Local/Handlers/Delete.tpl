using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Delete;

namespace Tix.Console.Local.Handlers.Delete;

public class LocalDelete{{ name }}Handler(
    Delete{{ name }}Handler handler) : IDelete{{ name }}Handler
{
    private readonly Delete{{ name }}Handler _handler = handler;
    public async Task<int> ExecuteAsync(Delete{{ name }}Command command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}