namespace Tix.Generator.Generators.Domain.Events;

public class DeletedEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Deleted.tpl", "src/Core/Tix.Domain/Events/{0}/{0}Deleted.cs" },
        { "Domain/Events/DeletedHandler.tpl", "src/Core/Tix.Domain/Events/{0}/{0}DeletedHandler.cs" }
    };
}