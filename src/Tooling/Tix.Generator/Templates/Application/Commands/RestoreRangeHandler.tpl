namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}RangeHandler : CommandHandler<Restore{{ name }}RangeCommand, IEnumerable<long>>
{
    public override async Task<IEnumerable<long>> HandleAsync(Restore{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var createdIds = new List<long>();
        foreach (var command in request.Commands)
        {
            token.ThrowIfCancellationRequested();
            // TODO: Impltement Restore command
            var created = await Task.Run(() => 1, token);
            createdIds.Add(created);
        }
        return createdIds;
    }
}