namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalShowHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/Show.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/Show/LocalShow{0}Handler.cs" }
    };
}