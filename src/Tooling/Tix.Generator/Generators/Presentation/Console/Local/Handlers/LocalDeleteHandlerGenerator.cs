namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalDeleteHandlerGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/Delete.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/Delete/LocalDelete{0}Handler.cs" }
    };
}