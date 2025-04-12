using Tix.Application.Commands.{{ name }};

namespace Tix.Console.Common.Interfaces.Handlers.New;

public interface INew{{ name }}Handler : ICommandHandler<Create{{ name }}Command, {{ tid }}> {}