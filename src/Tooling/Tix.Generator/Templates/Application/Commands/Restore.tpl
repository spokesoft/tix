using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}Command : ICommand
{
    public required {{ tid }} Id { get; init; }
}