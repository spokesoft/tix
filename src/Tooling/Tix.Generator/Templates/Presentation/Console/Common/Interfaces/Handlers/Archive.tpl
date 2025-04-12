using Tix.Application.Commands.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.Archive;

public interface IArchive{{ name }}Handler : ICommandHandler<Archive{{ name }}Command, int>
{
}