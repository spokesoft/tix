namespace Tix.Generator.Generators.Application.Commands;

public class UpdateCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/Update.tpl", "src/Core/Application/Commands/{0}/Update{0}Command.cs" },
        { "Application/Commands/UpdateHandler.tpl", "src/Core/Application/Commands/{0}/Update{0}Handler.cs" }
    };
}