namespace Tix.Application.Commands.{{ name }};

public class Create{{ name }}RangeHandler : CommandHandler<Create{{ name }}RangeCommand, IEnumerable<{{ tid }}>>
{
    public override async Task<IEnumerable<{{ tid }}>> HandleAsync(Create{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var createdIds = new List<{{ tid }}>();
        foreach (var command in request.Commands)
        {
            token.ThrowIfCancellationRequested();
            // TODO: Impltement Create command
            var created = await Task.Run(() => 1, token);
            createdIds.Add(created);
        }
        return createdIds;
    }
}