using Tix.Generator.Models;

namespace Tix.Generator.Interfaces;

public interface ITemplateGeneratorService
{
    void Generate(string shortName, EntityInfo? entity, string[] args);
}