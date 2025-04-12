namespace Tix.Generator.Generators.Domain.Exceptions;

public class NotFoundExceptionGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Exceptions/NotFound.tpl", "src/Core/Tix.Domain/Exceptions/{0}/{0}NotFoundException.cs" }
    };
}