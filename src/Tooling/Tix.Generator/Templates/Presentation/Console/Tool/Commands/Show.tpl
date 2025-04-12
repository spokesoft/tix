using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.Show;

namespace Tix.Console.Tool.Commands.Show;

public class Show{{ name }}Command(IShow{{ name }}Handler handler) : AsyncCommand<Show{{ name }}Command.Settings>
{
    private readonly IShow{{ name }}Handler _handler = handler;

    public class Settings : ShowCommandSettings
    {

    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        // TODO: Implement
        return await Task.FromResult(0);
    }
}