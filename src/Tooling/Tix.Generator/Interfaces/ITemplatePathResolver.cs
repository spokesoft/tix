namespace Tix.Generator.Interfaces;

public interface ITemplatePathResolver
{
    string GetPath(string shortName, string entityName);
}