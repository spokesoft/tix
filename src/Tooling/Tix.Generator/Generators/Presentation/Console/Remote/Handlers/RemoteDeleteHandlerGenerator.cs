namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteDeleteHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/Delete.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/Delete/RemoteDelete{0}Handler.cs" }
    };
}