using Spectre.Console.Cli;
using Tix.Console.Common.Interfaces.Handlers.Project;

namespace Tix.Console.Tool.Extensions;

public static class ConfiguratorExtensions
{
    class CreateProjectCommand(ICreateProjectHandler handler) : AsyncCommand<CreateProjectCommand.Settings>
    {
        private readonly ICreateProjectHandler _handler = handler;

        public class Settings : CommandSettings
        {

        }

        public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
        {
            var request = new Tix.Application.Commands.Project.CreateProjectCommand
            {
                Code = "abc"
            };
            var created = await _handler.ExecuteAsync(request);
            System.Console.WriteLine($"Created project with id {created}");
            return 0;
        }
    }
    
    public static IConfigurator AddCommands(this IConfigurator builder)
    {
        builder.AddBranch("new", CreateNewBranch).WithAlias("create");
        builder.AddBranch("update", CreateUpdateBranch).WithAlias("edit");
        builder.AddBranch("delete", CreateDeleteBranch).WithAlias("rm");
        builder.AddBranch("view", CreateViewBranch).WithAlias("read");
        return builder;
    }

    public static void CreateNewBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Create a new resource");
        builder.AddCommand<CreateProjectCommand>("project");
    }

    public static void CreateViewBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("View an existing resource");
        builder.AddCommand<CreateProjectCommand>("project");
    }

    public static void CreateUpdateBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Update an existing resource");
        builder.AddCommand<CreateProjectCommand>("project");
    }

    public static void CreateDeleteBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Delete an existing resource");
        builder.AddCommand<CreateProjectCommand>("project");
    }
}