namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class NewHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/New.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/New/INew{0}Handler.cs" }
    };
}