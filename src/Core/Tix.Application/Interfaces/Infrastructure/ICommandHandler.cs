namespace Tix.Application.Interfaces.Infrastructure;

public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand
{
    TResult Handle(TCommand request);
    Task<TResult> HandleAsync(TCommand request, CancellationToken token = default);
}