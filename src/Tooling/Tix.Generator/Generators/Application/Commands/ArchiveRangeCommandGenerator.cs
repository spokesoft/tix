namespace Tix.Generator.Generators.Application.Commands;

public class ArchiveRangeCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/ArchiveRange.tpl", "src/Core/Tix.Application/Commands/{0}/Archive{0}RangeCommand.cs" },
        { "Application/Commands/ArchiveRangeHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Archive{0}RangeHandler.cs" }
    };
}