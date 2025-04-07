using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}Command : ICommand
{
    public required {{ tid }} Id { get; set; }
    {{- for prop in props }}
    {{ prop }}
    {{- end }}
}