using Tix.Generator.Models;

namespace Tix.Generator.Interfaces;

public interface IOutputPathService
{
    public string Generate(string templateId, EntityInfo entity);
}