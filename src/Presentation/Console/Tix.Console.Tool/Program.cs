using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;
using Tix.Console.Common.Configuration;
using Tix.Console.Common.Extensions;
using Tix.Console.Local.Extensions;
using Tix.Console.Remote.Extensions;
using Tix.Console.Tool.Extensions;
using Tix.Console.Tool.Infrastructure;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddEnvironmentVariables("Tix_")
    .AddJsonFile("appsettings.json", optional: false)
    .AddCommandLine(args)
    .Build();

var services = new ServiceCollection();

services.AddSingleton(configuration);
services.AddTixOptions(configuration);
services.AddSingleton<TypeRegistrar>();

var mode = configuration[$"{TixOptions.SectionName}:Mode"];

switch(mode)
{
    case "Local":
        services.AddLocalHandlers();
        break;
    case "Remote":
        services.AddRemoteHandlers();
        break;
}

var provider = services.BuildServiceProvider();
var registrar = new TypeRegistrar(services);
var app = new CommandApp(registrar);

app.Configure(builder => 
{
    builder.SetApplicationName("tix");
    builder.SetApplicationVersion(VersionHelper.GetProductVersion());
    builder.AddCommands();
});

return await app.RunAsync(args);