namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteArchiveHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/Archive.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/Archive/RemoteArchive{0}Handler.cs" }
    };
}