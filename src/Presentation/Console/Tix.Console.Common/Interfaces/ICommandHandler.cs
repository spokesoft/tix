namespace Tix.Console.Common.Interfaces;

public interface ICommandHandler {}

public interface ICommandHandler<TCommand, TResult> : ICommandHandler
    where TCommand : class
{
    Task<TResult> ExecuteAsync(TCommand command, CancellationToken token = default);
}