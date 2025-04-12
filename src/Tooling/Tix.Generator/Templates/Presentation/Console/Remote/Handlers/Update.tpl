using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Update;

namespace Tix.Console.Remote.Handlers.Update;

public class RemoteUpdate{{ name }}Handler : IUpdate{{ name }}Handler
{
    public Task<int> ExecuteAsync(Update{{ name }}Command command, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}