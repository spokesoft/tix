using Tix.Generator.Services;

var sourceCode = new SourceCodeService();
var outputPath = new OutputPathService();
var template = new TemplateGeneratorService(outputPath);
var generator = new GeneratorService(sourceCode, template, outputPath);

generator.GenerateAll();