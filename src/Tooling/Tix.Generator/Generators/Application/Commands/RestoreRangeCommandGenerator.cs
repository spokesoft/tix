namespace Tix.Generator.Generators.Application.Commands;

public class RestoreRangeCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/RestoreRange.tpl", "src/Core/Application/Commands/{0}/Restore{0}RangeCommand.cs" },
        { "Application/Commands/RestoreRangeHandler.tpl", "src/Core/Application/Commands/{0}/Restore{0}RangeHandler.cs" }
    };
}