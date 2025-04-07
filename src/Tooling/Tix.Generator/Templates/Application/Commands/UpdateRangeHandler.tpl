namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}RangeHandler : CommandHandler<Update{{ name }}RangeCommand, int>
{
    public override async Task<int> HandleAsync(Update{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var rowsAffected = 0;
        // TODO: Implement restore range handler
        return await Task.FromResult(rowsAffected);
    }
}