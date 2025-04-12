using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Restore;

namespace Tix.Console.Remote.Handlers.Restore;

public class RemoteRestore{{ name }}Handler : IRestore{{ name }}Handler
{
    public Task<int> ExecuteAsync(Restore{{ name }}Command command, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}