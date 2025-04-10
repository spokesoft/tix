namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class RestoreHandlerInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/Restore.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/Restore/IRestore{0}Handler.cs" }
    };
}