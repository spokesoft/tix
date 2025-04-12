namespace Tix.Generator.Generators.Application.Commands;

public class DeleteRangeCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/DeleteRange.tpl", "src/Core/Tix.Application/Commands/{0}/Delete{0}RangeCommand.cs" },
        { "Application/Commands/DeleteRangeHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Delete{0}RangeHandler.cs" }
    };
}