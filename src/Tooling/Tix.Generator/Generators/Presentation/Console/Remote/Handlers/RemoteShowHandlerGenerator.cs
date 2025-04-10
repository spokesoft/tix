namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteShowHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/Show.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/Show/RemoteShow{0}Handler.cs" }
    };
}