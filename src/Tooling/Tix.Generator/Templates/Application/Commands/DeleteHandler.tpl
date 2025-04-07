namespace Tix.Application.Commands.{{ name }};

public class Delete{{ name }}Handler(Delete{{ name }}RangeHandler rangeHandler) : CommandHandler<Delete{{ name }}Command, int>
{
    private readonly Delete{{ name }}RangeHandler _handler = rangeHandler;
    public override async Task<int> HandleAsync(Delete{{ name }}Command request, CancellationToken token = default)
    {
        var rangeRequest = new Delete{{ name }}RangeCommand { Ids = [request.Id] };
        return await _handler.HandleAsync(rangeRequest, token);
    }
}