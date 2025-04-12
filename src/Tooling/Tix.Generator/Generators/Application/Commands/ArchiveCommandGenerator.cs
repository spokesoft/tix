namespace Tix.Generator.Generators.Application.Commands;

public class ArchiveCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/Archive.tpl", "src/Core/Tix.Application/Commands/{0}/Archive{0}Command.cs" },
        { "Application/Commands/ArchiveHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Archive{0}Handler.cs" }
    };
}