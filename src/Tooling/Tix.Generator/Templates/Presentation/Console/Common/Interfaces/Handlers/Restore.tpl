using Tix.Application.Commands.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.Restore;

public interface IRestore{{ name }}Handler : ICommandHandler<Restore{{ name }}Command, int> {}