namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalUpdateHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/Update.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/Update/LocalUpdate{0}Handler.cs" }
    };
}