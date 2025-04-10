using Spectre.Console.Cli;

namespace Tix.Console.Tool.Infrastructure;

/// <summary>
/// Provides type resolution services for Spectre.Console using Microsoft DI container
/// </summary>
public sealed class TypeResolver(IServiceProvider serviceProvider) : ITypeResolver, IDisposable
{
    private readonly IServiceProvider _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

    public object Resolve(Type? type)
    {
        ArgumentNullException.ThrowIfNull(type);

        return _serviceProvider.GetService(type) ?? Activator.CreateInstance(type)!;
    }

    public void Dispose()
    {
        if (_serviceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}