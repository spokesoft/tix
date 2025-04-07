namespace Tix.Application.Commands.{{ name }};

public class Archive{{ name }}RangeHandler : CommandHandler<Archive{{ name }}RangeCommand, int>
{
    public override async Task<int> HandleAsync(Archive{{ name }}RangeCommand request, CancellationToken token = default)
    {
        var rowsAffected = 0;
        // TODO: Implement archive range handler
        return await Task.FromResult(rowsAffected);
    }
}