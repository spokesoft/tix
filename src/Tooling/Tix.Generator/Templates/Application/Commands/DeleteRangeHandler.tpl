namespace Tix.Application.Commands.{{ name }};

public class Delete{{ name }}RangeHandler : CommandHandler<Delete{{ name }}RangeCommand, IEnumerable<long>>
{
    public override async Task<IEnumerable<long>> HandleAsync(Delete{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var createdIds = new List<long>();
        foreach (var command in request.Commands)
        {
            token.ThrowIfCancellationRequested();
            // TODO: Impltement Delete command
            var created = await Task.Run(() => 1, token);
            createdIds.Add(created);
        }
        return createdIds;
    }
}