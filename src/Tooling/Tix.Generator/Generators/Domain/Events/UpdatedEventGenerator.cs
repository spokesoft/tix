namespace Tix.Generator.Generators.Domain.Events;

public class UpdatedEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Updated.tpl", "src/Core/Tix.Domain/Events/{0}/{0}Updated.cs" },
        { "Domain/Events/UpdatedHandler.tpl", "src/Core/Tix.Domain/Events/{0}/{0}UpdatedHandler.cs" }
    };
}