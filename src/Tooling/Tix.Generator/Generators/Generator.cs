using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators;

public abstract class Generator : IGenerator
{
    public abstract void Generate(EntityInfo entity);
}