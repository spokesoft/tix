namespace Tix.Generator.Interfaces;

public interface ITemplateGenerator
{
    void Generate(string shortName, string entityName, string[] args);
}