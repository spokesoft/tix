using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}RangeCommand : ICommand
{
    public IEnumerable<Update{{ name }}Command> Commands { get; set; } = [];
}