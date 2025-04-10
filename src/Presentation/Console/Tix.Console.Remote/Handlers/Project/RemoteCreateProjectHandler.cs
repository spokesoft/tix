using Tix.Application.Commands.Project;
using Tix.Console.Common.Interfaces.Handlers.Project;

namespace Tix.Console.Remote.Handlers.Project;

public class RemoteCreateProjectHandler : ICreateProjectHandler
{
    public async Task<long> ExecuteAsync(CreateProjectCommand command, CancellationToken token = default)
    {
        var createdId = 1;
        System.Console.WriteLine("[RemoteCreateProjectHandler]");
        return await Task.FromResult(createdId);
    }
}