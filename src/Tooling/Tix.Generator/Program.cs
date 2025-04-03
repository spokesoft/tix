using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tix.Generator.Extensions;
using Tix.Generator.Interfaces;
using Tix.Generator.Services;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var services = new ServiceCollection();
services.AddSingleton<IConfiguration>(configuration);
services.AddSingleton<ISourceCodeService, SourceCodeService>();
services.AddSingleton<ITemplatePathResolver, TemplatePathResolver>();
services.AddSingleton<ITemplateGenerator, TemplateGenerator>();
services.AddSingleton<GeneratorService>();
services.AddGenerators();

var provider = services.BuildServiceProvider();
var generator = provider.GetRequiredService<GeneratorService>();

generator.GenerateAll();