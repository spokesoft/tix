using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Archive;

namespace Tix.Console.Local.Handlers.Archive;

public class LocalArchive{{ name }}Handler(
    Archive{{ name }}Handler handler) : IArchive{{ name }}Handler
{
    private readonly Archive{{ name }}Handler _handler = handler;
    public async Task<int> ExecuteAsync(Archive{{ name }}Command command, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        return await _handler.HandleAsync(command, token);
    }
}