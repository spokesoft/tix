namespace Tix.Generator.Generators.Domain.Events;

public class CreatedEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Created.tpl", "src/Core/Tix.Domain/Events/{0}/{0}Created.cs" },
        { "Domain/Events/CreatedHandler.tpl", "src/Core/Tix.Domain/Events/{0}/{0}CreatedHandler.cs" }
    };
}