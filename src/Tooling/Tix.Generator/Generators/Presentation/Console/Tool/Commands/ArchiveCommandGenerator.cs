namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class ArchiveCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/Archive.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/Archive/Archive{0}Command.cs" }
    };
}