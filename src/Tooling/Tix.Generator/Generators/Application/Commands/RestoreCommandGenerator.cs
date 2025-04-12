namespace Tix.Generator.Generators.Application.Commands;

public class RestoreCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/Restore.tpl", "src/Core/Tix.Application/Commands/{0}/Restore{0}Command.cs" },
        { "Application/Commands/RestoreHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Restore{0}Handler.cs" }
    };
}