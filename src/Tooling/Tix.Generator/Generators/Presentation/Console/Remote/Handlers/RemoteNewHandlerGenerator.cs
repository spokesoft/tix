namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteNewHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/New.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/New/RemoteNew{0}Handler.cs" }
    };
}