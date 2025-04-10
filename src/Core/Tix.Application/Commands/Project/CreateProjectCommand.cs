using Tix.Application.Interfaces.Infrastructure;

namespace Tix.Application.Commands.Project;

public class CreateProjectCommand : ICommand
{
    public required string Code { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}