namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalArchiveHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/Archive.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/Archive/LocalArchive{0}Handler.cs" }
    };
}