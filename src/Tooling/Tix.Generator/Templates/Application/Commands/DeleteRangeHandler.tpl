namespace Tix.Application.Commands.{{ name }};

public class Delete{{ name }}RangeHandler : CommandHandler<Delete{{ name }}RangeCommand, int>
{
    public override async Task<int> HandleAsync(Delete{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var rowsAffected = 0;
        // TODO: Implement delete range handler
        return await Task.FromResult(rowsAffected);
    }
}