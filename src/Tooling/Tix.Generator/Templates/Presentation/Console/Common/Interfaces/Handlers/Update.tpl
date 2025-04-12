using Tix.Application.Commands.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.Update;

public interface IUpdate{{ name }}Handler : ICommandHandler<Update{{ name }}Command, int> {}