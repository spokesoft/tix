using Tix.Generator.Models;

namespace Tix.Generator.Generators.Infrastructure;

public class InfrastructureGenerator(
    ConfigurationGenerator configuration,
    RepositoryGenerator repository) : Generator
{
    private readonly ConfigurationGenerator _configuration = configuration;
    private readonly RepositoryGenerator _repository = repository;
    
    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        await _configuration.GenerateAsync(entity, token);
        await _repository.GenerateAsync(entity, token);
    }
}