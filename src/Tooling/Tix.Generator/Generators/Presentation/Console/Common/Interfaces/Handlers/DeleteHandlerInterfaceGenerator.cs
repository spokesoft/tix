namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class DeleteHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/Delete.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/Delete/IDelete{0}Handler.cs" }
    };
}