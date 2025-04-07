using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators;

public abstract class Generator : IGenerator
{
    public void Generate(EntityInfo entity) => GenerateAsync(entity).Wait();
    
    public abstract Task GenerateAsync(EntityInfo entity, CancellationToken token = default);
}