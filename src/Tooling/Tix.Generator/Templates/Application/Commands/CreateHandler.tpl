namespace Tix.Application.Commands.{{ name }};

public class Create{{ name }}Handler(Create{{ name }}RangeHandler rangeHandler) : CommandHandler<Create{{ name }}Command, {{ tid }}>
{
    private readonly Create{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<{{ tid }}> HandleAsync(Create{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Create{{ name }}RangeCommand { Commands = [request] };
        var result = await _handler.HandleAsync(rangeRequest, token);
        return result.First();
    }
}