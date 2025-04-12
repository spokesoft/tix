using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Show;

namespace Tix.Console.Remote.Handlers.Show;

public class RemoteShow{{ name }}Handler : IShow{{ name }}Handler
{
    public Task<{{ name }}DetailsDto> ExecuteAsync(Get{{ name }}ByIdQuery query, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}