namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}Handler(Restore{{ name }}RangeHandler rangeHandler) : CommandHandler<Restore{{ name }}Command, long>
{
    private readonly Restore{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<long> HandleAsync(Restore{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Restore{{ name }}RangeCommand { Commands = [request] };
        var result = await _handler.HandleAsync(rangeRequest, token);
        return result.First();
    }
}