namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}Handler(Update{{ name }}RangeHandler rangeHandler) : CommandHandler<Update{{ name }}Command, long>
{
    private readonly Update{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<long> HandleAsync(Update{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Update{{ name }}RangeCommand { Commands = [request] };
        var result = await _handler.HandleAsync(rangeRequest, token);
        return result.First();
    }
}