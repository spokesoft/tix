using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class MvcGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        GenerateMvcModels(entity);
        GenerateMvcViewsForms(entity);
        GenerateMvcViewsGrid(entity);
        GenerateMvcViewsModals(entity);
        GenerateMvcViews(entity);
        GenerateMvcController(entity);
    }

    #region MVC View Model Templates

    public void GenerateMvcModels(EntityInfo entity)
    {
        GenerateMvcModelsIndexViewModel(entity);
        GenerateMvcModelsDetailsViewModel(entity);
        GenerateMvcModelsCreateViewModel(entity);
        GenerateMvcModelsUpdateViewModel(entity);
    }

    public void GenerateMvcModelsIndexViewModel(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcModelsIndexViewModel, entity);
    }

    public void GenerateMvcModelsDetailsViewModel(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcModelsDetailsViewModel, entity);
    }

    public void GenerateMvcModelsCreateViewModel(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcModelsCreateViewModel, entity);
    }

    public void GenerateMvcModelsUpdateViewModel(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcModelsUpdateViewModel, entity);
    }

    public void GenerateMvcModelsDeleteViewModel(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcModelsDeleteViewModel, entity);
    }

    #endregion

    #region MVC View Form Templates

    public void GenerateMvcViewsForms(EntityInfo entity)
    {
        GenerateMvcViewsFormsInline(entity);
        GenerateMvcViewsFormsCreate(entity);
        GenerateMvcViewsFormsUpdate(entity);
    }

    public void GenerateMvcViewsFormsInline(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsFormsInline, entity);
    }

    public void GenerateMvcViewsFormsCreate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsFormsCreate, entity);
    }

    public void GenerateMvcViewsFormsUpdate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsFormsUpdate, entity);
    }

    #endregion

    #region MVC View Grid Templates
    
    public void GenerateMvcViewsGrid(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsGrid, entity);
    }

    #endregion

    #region MVC View Modal Templates

    public void GenerateMvcViewsModals(EntityInfo entity)
    {
        GenerateMvcViewsModalsCreate(entity);
        GenerateMvcViewsModalsUpdate(entity);
        GenerateMvcViewsModalsDelete(entity);
        GenerateMvcViewsModalsDetails(entity);
    }

    public void GenerateMvcViewsModalsCreate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsModalsCreate, entity);
    }

    public void GenerateMvcViewsModalsUpdate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsModalsUpdate, entity);
    }

    public void GenerateMvcViewsModalsDelete(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsModalsDelete, entity);
    }

    public void GenerateMvcViewsModalsDetails(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsModalsDetails, entity);
    }

    #endregion

    #region MVC View Templates

    public void GenerateMvcViews(EntityInfo entity)
    {
        GenerateMvcViewsIndexView(entity);
        GenerateMvcViewsDetailsView(entity);
        GenerateMvcViewsCreateView(entity);
        GenerateMvcViewsUpdateView(entity);
    }

    public void GenerateMvcViewsIndexView(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsIndex, entity);
    }

    public void GenerateMvcViewsDetailsView(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsDetails, entity);
    }

    public void GenerateMvcViewsCreateView(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsCreate, entity);
    }

    public void GenerateMvcViewsUpdateView(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsUpdate, entity);
    }

    public void GenerateMvcViewsDeleteView(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcViewsDelete, entity);
    }

    #endregion

    #region MVC Controller Template

    public void GenerateMvcController(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.MvcController, entity);
    }

    #endregion
}