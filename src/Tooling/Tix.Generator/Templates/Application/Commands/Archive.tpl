using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Archive{{ name }}Command : ICommand
{
    public required {{ tid }} Id { get; init; }
}