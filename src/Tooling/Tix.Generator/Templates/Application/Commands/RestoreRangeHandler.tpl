namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}RangeHandler : CommandHandler<Restore{{ name }}RangeCommand, int>
{
    public override async Task<int> HandleAsync(Restore{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var rowsAffected = 0;
        // TODO: Implement restore range handler
        return await Task.FromResult(rowsAffected);
    }
}