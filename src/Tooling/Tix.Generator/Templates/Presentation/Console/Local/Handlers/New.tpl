using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.New;

namespace Tix.Console.Local.Handlers.New;

public class LocalNew{{ name }}Handler(
    Create{{ name }}Handler handler) : INew{{ name }}Handler
{
    private readonly Create{{ name }}Handler _handler = handler;
    public async Task<long> ExecuteAsync(Create{{ name }}Command command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}