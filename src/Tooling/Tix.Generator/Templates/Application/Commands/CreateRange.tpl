using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Create{{ name }}RangeCommand : ICommand
{
    public IEnumerable<Create{{ name }}Command> Commands { get; set; } = [];
}