namespace Tix.Application.Commands.{{ name }};

public class Delete{{ name }}Handler(Delete{{ name }}RangeHandler rangeHandler) : CommandHandler<Delete{{ name }}Command, long>
{
    private readonly Delete{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<long> HandleAsync(Delete{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Delete{{ name }}RangeCommand { Commands = [request] };
        var result = await _handler.HandleAsync(rangeRequest, token);
        return result.First();
    }
}