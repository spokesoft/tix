using Spectre.Console;
using Spectre.Console.Cli;
using Tix.Application.Commands.{{ name }};
using Tix.Console.Common.Interfaces.Handlers.New;

namespace Tix.Console.Tool.Commands.New;

public class New{{ name }}Command(
    INew{{ name }}Handler handler,
    IAnsiConsole console) : TixCommand<New{{ name }}Command.Settings>
{
    private readonly INew{{ name }}Handler _handler = handler;
    private readonly IAnsiConsole _console = console;

    public class Settings : NewCommandSettings
    {
        {{- for prop in props }}
        {{ prop }}
        {{- end }}
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        try
        {
            var command = new Create{{ name }}Command
            {
                {{- for prop in propnames }}
                {{ prop }} = settings.{{ prop }},
                {{- end }}
            };
            var id = await _handler.ExecuteAsync(command);
            _console.Markup($"[green]Success[/]: {{ name }} created with id {id}");
            return Success();
        }
        catch
        {
            _console.Markup("[red]Error[/]: Could not create {{ name }}");
            return Error();
        }
    }
}