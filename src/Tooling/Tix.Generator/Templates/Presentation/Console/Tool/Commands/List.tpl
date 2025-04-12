using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.List;

namespace Tix.Console.Tool.Commands.List;

public class List{{ plural }}Command(IList{{ plural }}Handler handler) : AsyncCommand<List{{ plural }}Command.Settings>
{
    private readonly IList{{ plural }}Handler _handler = handler;

    public class Settings : ListCommandSettings
    {

    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        // TODO: Implement
        return await Task.FromResult(0);
    }
}