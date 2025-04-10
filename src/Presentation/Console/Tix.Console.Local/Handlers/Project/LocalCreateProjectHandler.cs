using Tix.Application.Commands.Project;
using Tix.Console.Common.Interfaces.Handlers.Project;

namespace Tix.Console.Local.Handlers.Project;

public class LocalCreateProjectHandler : ICreateProjectHandler
{
    public async Task<long> ExecuteAsync(CreateProjectCommand command, CancellationToken token = default)
    {
        var createdId = 1;
        System.Console.WriteLine("[LocalCreateProjectHandler]");
        return await Task.FromResult(createdId);
    }
}