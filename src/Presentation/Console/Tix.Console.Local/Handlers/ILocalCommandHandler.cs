using Tix.Console.Common.Interfaces;

namespace Tix.Console.Local.Handlers;

public interface ILocalCommandHandler<TCommand, TResult> : ICommandHandler<TCommand, TResult> 
    where TCommand : class { }