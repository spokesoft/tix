namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class ArchiveHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/Archive.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/Archive/IArchive{0}Handler.cs" }
    };
}