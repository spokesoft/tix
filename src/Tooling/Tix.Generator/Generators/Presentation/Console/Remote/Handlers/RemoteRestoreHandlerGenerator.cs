namespace Tix.Generator.Generators.Presentation.Console.Remote.Handlers;

public class RemoteRestoreHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Remote/Handlers/Restore.tpl", "src/Presentation/Console/Tix.Console.Remote/Handlers/Restore/RemoteRestore{0}Handler.cs" }
    };
}