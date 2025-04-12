namespace Tix.Generator.Generators.Domain.Events;

public class ArchivedEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Archived.tpl", "src/Core/Tix.Domain/Events/{0}/{0}Archived.cs" },
        { "Domain/Events/ArchivedHandler.tpl", "src/Core/Tix.Domain/Events/{0}/{0}ArchivedHandler.cs" }
    };
}