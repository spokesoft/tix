using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands;

public abstract class CommandHandler<TCommand, TResult>
    : ICommandHandler<TCommand, TResult> where TCommand : ICommand
{
    public TResult Handle(TCommand request) => HandleAsync(request, CancellationToken.None).Result;

    public abstract Task<TResult> HandleAsync(TCommand request, CancellationToken token = default);
}

public class ArchiveProjectCommand : ICommand
{

}

public class ArchiveProjectRangeCommand : ICommand
{
    public IEnumerable<ArchiveProjectCommand> Commands { get; set; } = [];
}

public class ArchiveProjectHandler(ArchiveProjectRangeHandler rangeHandler) : CommandHandler<ArchiveProjectCommand, long>
{
    private readonly ArchiveProjectRangeHandler _handler = rangeHandler;
    public override async Task<long> HandleAsync(ArchiveProjectCommand request, CancellationToken token = default)
    {
        var single = new ArchiveProjectRangeCommand { Commands = [request] };
        var result = await _handler.HandleAsync(single, token);
        return result.First();
    }
}

public class ArchiveProjectRangeHandler : CommandHandler<ArchiveProjectRangeCommand, IEnumerable<long>>
{
    public override async Task<IEnumerable<long>> HandleAsync(ArchiveProjectRangeCommand request, CancellationToken token = default)
    {
        var createdIds = new List<long>();
        foreach (var command in request.Commands)
        {
            token.ThrowIfCancellationRequested();
            // TODO: Impltement archive command
            var created = await Task.Run(() => 1, token);
            createdIds.Add(created);
        }
        return createdIds;
    }
}