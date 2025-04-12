using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.New;

namespace Tix.Console.Remote.Handlers.New;

public class RemoteNew{{ name }}Handler : INew{{ name }}Handler
{
    public Task<{{ tid }}> ExecuteAsync(Create{{ name }}Command command, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}