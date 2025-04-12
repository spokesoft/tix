using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.Show;

public interface IShow{{ name }}Handler : ICommandHandler<Get{{ name }}ByIdQuery, {{ name }}DetailsDto> {}