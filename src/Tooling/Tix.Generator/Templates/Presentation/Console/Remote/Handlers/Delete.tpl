using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Delete;

namespace Tix.Console.Remote.Handlers.Delete;

public class RemoteDelete{{ name }}Handler : IDelete{{ name }}Handler
{
    public Task<int> ExecuteAsync(Delete{{ name }}Command command, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}