namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class UpdateHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/Update.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/Update/IUpdate{0}Handler.cs" }
    };
}