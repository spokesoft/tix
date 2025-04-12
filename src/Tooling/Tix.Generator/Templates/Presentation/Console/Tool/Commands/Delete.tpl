using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.Delete;
using AppDelete{{ name }}Command = Tix.Application.Commands.{{ name }}.Delete{{ name }}Command;

namespace Tix.Console.Tool.Commands.Delete;

public class Delete{{ name }}Command(
    IDelete{{ name }}Handler handler,
    IAnsiConsole console) : AsyncCommand<Delete{{ name }}Command.Settings>
{
    private readonly IDelete{{ name }}Handler _handler = handler;
    private readonly IAnsiConsole _console = console;

    public class Settings : DeleteCommandSettings
    {
        public long Id { get; set; }
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        try
        {
            var command = new AppDelete{{ name }}Command
            {
                Id = settings.Id
            };
            await _handler.ExecuteAsync(command);
            _console.Markup($"[green]Success[/]: Deleted {{ name }} with id {command.Id}");
            return 0;
        }
        catch
        {
            _console.Markup($"[red]Error[/]: Could not delete {{ name }} with id {settings.Id}");
            return 1;
        }
    }
}