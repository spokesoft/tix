namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class ShowCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/Show.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/Show/Show{0}Command.cs" }
    };
}