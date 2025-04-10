namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class UpdateCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/Update.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/Update/Update{0}Command.cs" }
    };
}