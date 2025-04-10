namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalNewHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/New.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/New/LocalNew{0}Handler.cs" }
    };
}