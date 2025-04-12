using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.Restore;
using AppRestore{{ name }}Command = Tix.Application.Commands.{{ name }}.Restore{{ name }}Command;

namespace Tix.Console.Tool.Commands.Restore;

public class Restore{{ name }}Command(
    IRestore{{ name }}Handler handler,
    IAnsiConsole console) : AsyncCommand<Restore{{ name }}Command.Settings>
{
    private readonly IRestore{{ name }}Handler _handler = handler;
    private readonly IAnsiConsole _console = console;

    public class Settings : RestoreCommandSettings
    {
        public long Id { get; set; }
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        try
        {
            var command = new AppRestore{{ name }}Command
            {
                Id = settings.Id
            };
            await _handler.ExecuteAsync(command);
            _console.Markup($"[green]Success[/]: Restored {{ name }} with id {command.Id}");
            return 0;
        }
        catch
        {
            _console.Markup($"[red]Error[/]: Could not restore {{ name }} with id {settings.Id}");
            return 1;
        }
    }
}