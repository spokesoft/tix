using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Restore;

namespace Tix.Console.Local.Handlers.Restore;

public class LocalRestore{{ name }}Handler(
    Restore{{ name }}Handler handler) : IRestore{{ name }}Handler
{
    private readonly Restore{{ name }}Handler _handler = handler;
    public async Task<int> ExecuteAsync(Restore{{ name }}Command command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}