namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalRestoreHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/Restore.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/Restore/LocalRestore{0}Handler.cs" }
    };
}