namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteUpdateHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/Update.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/Update/RemoteUpdate{0}Handler.cs" }
    };
}