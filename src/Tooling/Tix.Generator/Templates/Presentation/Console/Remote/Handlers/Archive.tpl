using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Archive;

namespace Tix.Console.Remote.Handlers.Archive;

public class RemoteArchive{{ name }}Handler : IArchive{{ name }}Handler
{
    public Task<int> ExecuteAsync(Archive{{ name }}Command command, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}