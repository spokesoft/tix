using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class ApiGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        GenerateApiController(entity);
        GenerateApiRequests(entity);
        GenerateApiResponses(entity);
    }

    public void GenerateApiController(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiController, entity);
    }

    public void GenerateApiRequests(EntityInfo entity)
    {
    }

    public void GenerateApiResponses(EntityInfo entity)
    {
    }

    public void GenerateApiResponsesGetResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesGet, entity);
    }

    public void GenerateApiResponsesCreateResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesCreate, entity);
    }

    public void GenerateApiResponsesUpdateResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesUpdate, entity);
    }

    public void GenerateApiResponsesDeleteResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesDelete, entity);
    }

    public void GenerateApiResponsesCreateRangeResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesCreateRange, entity);
    }

    public void GenerateApiResponsesUpdateRangeResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesUpdateRange, entity);
    }

    public void GenerateApiResponsesDeleteRangeResponse(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApiResponsesDeleteRange, entity);
    }
}