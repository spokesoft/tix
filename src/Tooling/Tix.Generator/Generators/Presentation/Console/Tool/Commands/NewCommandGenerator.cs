namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class NewCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/New.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/New/New{0}Command.cs" }
    };
}