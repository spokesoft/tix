using Tix.Application.DTOs.{{ name }};

namespace Tix.Application.Queries.{{ name }};

public class Get{{ name }}ByIdHandler : QueryHandler<Get{{ name }}ByIdQuery, {{ name }}DetailsDto>
{
    public override async Task<{{ name }}DetailsDto> HandleAsync(Get{{ name }}ByIdQuery query, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        var dto = new {{ name }}DetailsDto
        {
            // TODO: Implement query
        };
        return await Task.FromResult(dto);
    }
}