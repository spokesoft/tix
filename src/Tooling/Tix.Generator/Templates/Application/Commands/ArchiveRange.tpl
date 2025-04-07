using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Archive{{ name }}RangeCommand : ICommand
{
    public IEnumerable<{{ tid }}> Ids { get; set; } = [];
}