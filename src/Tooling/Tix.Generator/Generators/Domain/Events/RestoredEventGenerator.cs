namespace Tix.Generator.Generators.Domain.Events;

public class RestoredEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Restored.tpl", "src/Core/Domain/Events/{0}/{0}Restored.cs" },
        { "Domain/Events/RestoredHandler.tpl", "src/Core/Domain/Events/{0}/{0}RestoredHandler.cs" }
    };
}