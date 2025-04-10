using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;

namespace Tix.Console.Tool.Infrastructure;

/// <summary>
/// Provides type registrar services for Spectre.Console using Microsoft DI container
/// </summary>
public sealed class TypeRegistrar(IServiceCollection services) : ITypeRegistrar
{
    private readonly IServiceCollection _services = services ?? throw new ArgumentNullException(nameof(services));

    public ITypeResolver Build()
    {
        return new TypeResolver(_services.BuildServiceProvider());
    }

    public void Register(Type service, Type implementation)
    {
        ArgumentNullException.ThrowIfNull(service);
        ArgumentNullException.ThrowIfNull(implementation);

        _services.AddSingleton(service, implementation);
    }

    public void RegisterInstance(Type service, object implementation)
    {
        ArgumentNullException.ThrowIfNull(service);
        ArgumentNullException.ThrowIfNull(implementation);

        _services.AddSingleton(service, implementation);
    }

    public void RegisterLazy(Type service, Func<object> factory)
    {
        ArgumentNullException.ThrowIfNull(service);
        ArgumentNullException.ThrowIfNull(factory);

        _services.AddSingleton(service, _ => factory());
    }
}