namespace Tix.Generator.Generators.Application.Validators;

public class CreateValidatorGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Validators/Create.tpl", "src/Core/Tix.Application/Validators/{0}/Create{0}Validator.cs" }
    };
}