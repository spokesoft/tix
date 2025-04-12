namespace Tix.Console.Common.Interfaces;

public interface ICommandHandler {}

public interface ICommandHandler<TCommand, TResult> : ICommandHandler
{
    Task<TResult> ExecuteAsync(TCommand command, CancellationToken token = default);
}