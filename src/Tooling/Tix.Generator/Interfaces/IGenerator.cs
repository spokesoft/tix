using Tix.Generator.Models;

namespace Tix.Generator.Interfaces;

public interface IGenerator
{
    void Generate(EntityInfo entity);
    Task GenerateAsync(EntityInfo entity, CancellationToken token = default);
}