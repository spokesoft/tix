namespace Tix.Application.Commands.{{ name }};

public class Update{{ name }}Handler(Update{{ name }}RangeHandler rangeHandler) : CommandHandler<Update{{ name }}Command, int>
{
    private readonly Update{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<int> HandleAsync(Update{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Update{{ name }}RangeCommand { Commands = [request] };
        return await _handler.HandleAsync(rangeRequest, token);
    }
}