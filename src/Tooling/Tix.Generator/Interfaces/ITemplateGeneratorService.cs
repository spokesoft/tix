using Tix.Generator.Models;

namespace Tix.Generator.Interfaces;
public interface ITemplateGeneratorService
{
    void Generate(string name, EntityInfo? entity = null);
}