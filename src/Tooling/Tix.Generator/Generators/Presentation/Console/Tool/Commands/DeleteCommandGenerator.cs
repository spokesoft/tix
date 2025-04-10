namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class DeleteCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/Delete.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/Delete/Delete{0}Command.cs" }
    };
}