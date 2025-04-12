using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.Archive;
using AppArchive{{ name }}Command = Tix.Application.Commands.{{ name }}.Archive{{ name }}Command;

namespace Tix.Console.Tool.Commands.Archive;

public class Archive{{ name }}Command(
    IArchive{{ name }}Handler handler,
    IAnsiConsole console) : AsyncCommand<Archive{{ name }}Command.Settings>
{
    private readonly IArchive{{ name }}Handler _handler = handler;
    private readonly IAnsiConsole _console = console;

    public class Settings : ArchiveCommandSettings
    {
        public long Id { get; set; }
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        try
        {
            var command = new AppArchive{{ name }}Command
            {
                Id = settings.Id
            };
            await _handler.ExecuteAsync(command);
            _console.Markup($"[green]Success[/]: Archived {{ name }} with id {command.Id}");
            return 0;
        }
        catch
        {
            _console.Markup($"[red]Error[/]: Could not archive {{ name }} with id {settings.Id}");
            return 1;
        }
    }
}