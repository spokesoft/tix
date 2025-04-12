using Tix.Application.DTOs.{{ name }};
using Tix.Application.Queries.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.List;

public interface IList{{ plural }}Handler : ICommandHandler<Get{{ name }}ListQuery, IEnumerable<{{ name }}ListItemDto>> {}