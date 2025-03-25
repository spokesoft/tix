using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;
using Tix.Console.Infrastructure;

var services = new ServiceCollection();
var registrar = new TypeRegistrar(services);
var app = new CommandApp(registrar);

app.Configure(builder => 
{
    builder.SetApplicationName("tix");
    builder.SetApplicationVersion(VersionHelper.GetProductVersion());
});

return await app.RunAsync(args);