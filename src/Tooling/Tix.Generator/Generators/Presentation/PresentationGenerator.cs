using Tix.Generator.Generators.Presentation.Console;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Presentation;

public class PresentationGenerator(ConsoleGenerator console) : Generator
{
    private readonly ConsoleGenerator _console = console;
    
    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        await _console.GenerateAsync(entity, token);
    }
}