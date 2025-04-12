namespace Tix.Generator.Generators.Application.Commands;

public class UpdateRangeCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/UpdateRange.tpl", "src/Core/Tix.Application/Commands/{0}/Update{0}RangeCommand.cs" },
        { "Application/Commands/UpdateRangeHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Update{0}RangeHandler.cs" }
    };
}