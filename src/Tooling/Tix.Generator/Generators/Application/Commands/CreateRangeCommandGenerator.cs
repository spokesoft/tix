namespace Tix.Generator.Generators.Application.Commands;

public class CreateRangeCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/CreateRange.tpl", "src/Core/Application/Commands/{0}/Create{0}RangeCommand.cs" },
        { "Application/Commands/CreateRangeHandler.tpl", "src/Core/Application/Commands/{0}/Create{0}RangeHandler.cs" }
    };
}