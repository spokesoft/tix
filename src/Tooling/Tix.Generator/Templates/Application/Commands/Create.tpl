using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{name}};

public class Create{{name}}Command : ICommand
{
    {{- for prop in props }}
    {{ prop }}
    {{- end }}
}