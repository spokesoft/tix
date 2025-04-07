namespace Tix.Generator.Generators.Application.Commands;

public class DeleteCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/Delete.tpl", "src/Core/Application/Commands/{0}/Delete{0}Command.cs" },
        { "Application/Commands/DeleteHandler.tpl", "src/Core/Application/Commands/{0}/Delete{0}Handler.cs" }
    };
}