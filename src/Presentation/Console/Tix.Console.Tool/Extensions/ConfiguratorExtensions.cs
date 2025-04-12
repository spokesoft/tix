using Spectre.Console.Cli;
using Tix.Console.Tool.Commands;

namespace Tix.Console.Tool.Extensions;

public static class ConfiguratorExtensions
{
    class NoopCommand : AsyncCommand<NoopCommand.Settings>
    {
        public class Settings : CommandSettings {}

        public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
            => await Task.FromResult(0);
    }

    class ArchiveNoopCommand : AsyncCommand<ArchiveNoopCommand.Settings>
    {
        public class Settings : ArchiveCommandSettings {}

        public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
            => await Task.FromResult(0);
    }
    
    public static IConfigurator AddCommands(this IConfigurator builder)
    {
        builder.AddBranch<ArchiveCommandSettings>("archive", CreateArchiveBranch).WithAlias("create");

        builder.AddBranch("new", CreateNewBranch).WithAlias("create");
        builder.AddBranch("update", CreateUpdateBranch).WithAlias("edit");
        builder.AddBranch("delete", CreateDeleteBranch).WithAlias("rm");
        builder.AddBranch("view", CreateViewBranch).WithAlias("read");
        return builder;
    }

    public static void CreateArchiveBranch(IConfigurator<ArchiveCommandSettings> builder)
    {
        builder.SetDescription("Archive an existing resource");
        builder.AddCommand<ArchiveNoopCommand>("project");
    }

    public static void CreateNewBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Create a new resource");
        builder.AddCommand<NoopCommand>("project");
    }

    public static void CreateViewBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("View an existing resource");
        builder.AddCommand<NoopCommand>("project");
    }

    public static void CreateUpdateBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Update an existing resource");
        builder.AddCommand<NoopCommand>("project");
    }

    public static void CreateDeleteBranch(IConfigurator<CommandSettings> builder)
    {
        builder.SetDescription("Delete an existing resource");
        builder.AddCommand<NoopCommand>("project");
    }
}