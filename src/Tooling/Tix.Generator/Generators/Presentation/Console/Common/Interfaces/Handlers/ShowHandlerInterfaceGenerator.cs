namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class ShowHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/Show.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/Show/IShow{0}Handler.cs" }
    };
}