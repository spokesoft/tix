using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.Update;
using AppUpdate{{ name }}Command = Tix.Application.Commands.{{ name }}.Update{{ name }}Command;

namespace Tix.Console.Tool.Commands.Update;

public class Update{{ name }}Command(
    IUpdate{{ name }}Handler handler,
    IAnsiConsole console) : TixCommand<Update{{ name }}Command.Settings>
{
    private readonly IUpdate{{ name }}Handler _handler = handler;
    private readonly IAnsiConsole _console = console;

    public class Settings : UpdateCommandSettings
    {
        public {{ tid }} Id { get; set; }
        {{- for prop in props }}
        {{ prop }}
        {{- end }}
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        try
        {
            var command = new AppUpdate{{ name }}Command
            {
                Id = settings.Id,
                {{- for prop in propnames }}
                {{ prop }} = settings.{{ prop }},
                {{- end }}
            };
            var id = await _handler.ExecuteAsync(command);
            _console.Markup($"[green]Success[/]: {{ name }} with id {id} has been updated");
            return Success();
        }
        catch
        {
            _console.Markup("[red]Error[/]: Could not update {{ name }}");
            return Error();
        }
    }
}