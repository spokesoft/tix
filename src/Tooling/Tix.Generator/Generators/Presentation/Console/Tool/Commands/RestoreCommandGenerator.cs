namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class RestoreCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/Restore.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/Restore/Restore{0}Command.cs" }
    };
}