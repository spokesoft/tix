namespace Tix.Application.Commands.{{ name }};

public class Archive{{ name }}Handler(Archive{{ name }}RangeHandler rangeHandler) : CommandHandler<Archive{{ name }}Command, int>
{
    private readonly Archive{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<int> HandleAsync(Archive{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Archive{{ name }}RangeCommand { Ids = [request.Id] };
        var result = await _handler.HandleAsync(rangeRequest, token);
        return result;
    }
}