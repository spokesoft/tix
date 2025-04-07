using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}RangeCommand : ICommand
{
    public IEnumerable<{{ tid }}> Ids { get; set; } = [];
}