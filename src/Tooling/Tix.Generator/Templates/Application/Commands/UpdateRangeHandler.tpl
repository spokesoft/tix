namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}RangeHandler : CommandHandler<Update{{ name }}RangeCommand, IEnumerable<long>>
{
    public override async Task<IEnumerable<long>> HandleAsync(Update{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var createdIds = new List<long>();
        foreach (var command in request.Commands)
        {
            token.ThrowIfCancellationRequested();
            // TODO: Impltement Update command
            var created = await Task.Run(() => 1, token);
            createdIds.Add(created);
        }
        return createdIds;
    }
}