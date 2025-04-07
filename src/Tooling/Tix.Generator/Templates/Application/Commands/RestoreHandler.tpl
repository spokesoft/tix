namespace Tix.Application.Commands.{{ name }};

public class Restore{{ name }}Handler(Restore{{ name }}RangeHandler rangeHandler) : CommandHandler<Restore{{ name }}Command, int>
{
    private readonly Restore{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<int> HandleAsync(Restore{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Restore{{ name }}RangeCommand { Ids = [request.Id] };
        return await _handler.HandleAsync(rangeRequest, token);
    }
}