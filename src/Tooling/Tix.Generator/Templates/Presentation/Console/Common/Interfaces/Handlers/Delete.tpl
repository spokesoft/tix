using Tix.Application.Commands.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.Delete;

public interface IDelete{{ name }}Handler : ICommandHandler<Delete{{ name }}Command, int> {}