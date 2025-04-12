using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Update;

namespace Tix.Console.Local.Handlers.Update;

public class LocalUpdate{{ name }}Handler(
    Update{{ name }}Handler handler) : IUpdate{{ name }}Handler
{
    private readonly Update{{ name }}Handler _handler = handler;
    public async Task<int> ExecuteAsync(Update{{ name }}Command command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}