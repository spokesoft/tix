using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands;

public abstract class CommandHandler<TCommand, TResult> 
    : ICommandHandler<TCommand, TResult> where TCommand : ICommand
{
    public TResult Handle(TCommand request) => HandleAsync(request, CancellationToken.None).Result;

    public abstract Task<TResult> HandleAsync(TCommand request, CancellationToken token = default);
}