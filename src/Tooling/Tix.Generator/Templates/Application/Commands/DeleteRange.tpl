using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Delete{{ name }}RangeCommand : ICommand
{
    public IEnumerable<Delete{{ name }}Command> Commands { get; set; } = [];
}