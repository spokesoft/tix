using System.Reflection;
using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class OutputPathService : IOutputPathService
{
    public string Generate(string templateId, EntityInfo entity)
    {
        var template = GetOutputPathTemplate(templateId);
        var path = Path.Combine(GetSolutionDirectory(), string.Format(template, entity.Name));
        return Path.Combine(path.Split('\\', '/'));
    }

    private static string GetSolutionDirectory()
    {
        string baseDir = AppContext.BaseDirectory;
        var directory = new DirectoryInfo(baseDir);

        const int maxDepth = 10;
        int currentDepth = 0;

        while (directory != null && currentDepth < maxDepth)
        {
            var solutionFiles = directory.GetFiles("*.sln")
                .Where(f => string.Equals(f.Name, "Tix.sln", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            if (solutionFiles.Length > 0)
            {
                return directory.FullName;
            }

            directory = directory.Parent;
            currentDepth++;
        }

        throw new DirectoryNotFoundException("Solution directory could not be located. Ensure the application is running within a valid solution structure.");
    }

    private static string GetOutputPathTemplate(string templateId)
    {
        return templateId switch
        {
            // Domain Templates
            TemplateIdentity.DomainEventsArchived => "src/Core/Tix.Domain/Events/{0}/{0}Archived.cs",
            TemplateIdentity.DomainEventsCreated => "src/Core/Tix.Domain/Events/{0}/{0}Created.cs",
            TemplateIdentity.DomainEventsDeleted => "src/Core/Tix.Domain/Events/{0}/{0}Deleted.cs",
            TemplateIdentity.DomainEventsRestored => "src/Core/Tix.Domain/Events/{0}/{0}Restored.cs",
            TemplateIdentity.DomainEventsUpdated => "src/Core/Tix.Domain/Events/{0}/{0}Updated.cs",
            TemplateIdentity.DomainExceptionsNotFound => "src/Core/Tix.Domain/Exceptions/{0}/{0}NotFoundException.cs",
            TemplateIdentity.DomainExceptionsDuplicate => "src/Core/Tix.Domain/Exceptions/{0}/Duplicate{0}Exception.cs",

            // Application Templates
            TemplateIdentity.ApplicationCommandsCreate => "src/Tix.Application/Commands/{0}/Create{0}Command.cs",
            TemplateIdentity.ApplicationCommandsUpdate => "src/Tix.Application/Commands/{0}/Update{0}Command.cs",
            TemplateIdentity.ApplicationCommandsDelete => "src/Tix.Application/Commands/{0}/Delete{0}Command.cs",
            TemplateIdentity.ApplicationCommandsArchive => "src/Tix.Application/Commands/{0}/Archive{0}Command.cs",
            TemplateIdentity.ApplicationCommandsRestore => "src/Tix.Application/Commands/{0}/Restore{0}Command.cs",
            TemplateIdentity.ApplicationCommandsCreateRange => "src/Tix.Application/Commands/{0}/Create{0}RangeCommand.cs",
            TemplateIdentity.ApplicationCommandsUpdateRange => "src/Tix.Application/Commands/{0}/Update{0}RangeCommand.cs",
            TemplateIdentity.ApplicationCommandsDeleteRange => "src/Tix.Application/Commands/{0}/Delete{0}RangeCommand.cs",
            TemplateIdentity.ApplicationCommandsArchiveRange => "src/Tix.Application/Commands/{0}/Archive{0}RangeCommand.cs",
            TemplateIdentity.ApplicationCommandsRestoreRange => "src/Tix.Application/Commands/{0}/Restore{0}RangeCommand.cs",
            TemplateIdentity.ApplicationDTOsDetails => "src/Tix.Application/DTOs/{0}/{0}DetailsDto.cs",
            TemplateIdentity.ApplicationDTOsListItem => "src/Tix.Application/DTOs/{0}/{0}ListItemDto.cs",
            TemplateIdentity.ApplicationDTOsSelectListItem => "src/Tix.Application/DTOs/{0}/{0}SelectListItemDto.cs",
            TemplateIdentity.ApplicationInterfacesRepository => "src/Tix.Application/Interfaces/Repositories/I{0}Repository.cs",
            TemplateIdentity.ApplicationInterfacesService => "src/Tix.Application/Interfaces/Services/I{0}Service.cs",
            TemplateIdentity.ApplicationQueriesGetList => "src/Tix.Application/Queries/{0}/Get{0}ListQuery.cs",
            TemplateIdentity.ApplicationQueriesGetById => "src/Tix.Application/Queries/{0}/Get{0}ByIdQuery.cs",
            TemplateIdentity.ApplicationQueriesGetByCode => "src/Tix.Application/Queries/{0}/Get{0}ByCodeQuery.cs",
            TemplateIdentity.ApplicationQueriesGetByName => "src/Tix.Application/Queries/{0}/Get{0}ByNameQuery.cs",
            TemplateIdentity.ApplicationService => "src/Tix.Application/Services/{0}Service.cs",
            TemplateIdentity.ApplicationValidatorsCreate => "src/Tix.Application/Validators/{0}/Create{0}Validator.cs",
            TemplateIdentity.ApplicationValidatorsUpdate => "src/Tix.Application/Validators/{0}/Update{0}Validator.cs",
            TemplateIdentity.ApplicationValidatorsDelete => "src/Tix.Application/Validators/{0}/Delete{0}Validator.cs",

            // Infrastructure Templates
            TemplateIdentity.InfrastructureIdentityEntity => "src/Tix.Infrastructure/Identity/Entities/{0}Identity.cs",
            TemplateIdentity.InfrastructureConfiguration => "src/Tix.Infrastructure/Persistence/Configurations/{0}Configuration.cs",
            TemplateIdentity.InfrastructureRepository => "src/Tix.Infrastructure/Persistence/Repositories/{0}Repository.cs",

            // API Templates
            TemplateIdentity.ApiController => "src/Tix.Api/Controllers/{0}Controller.cs",
            TemplateIdentity.ApiResponsesGet => "src/Tix.Api/Responses/{0}/{0}GetResponse.cs",
            TemplateIdentity.ApiResponsesCreate => "src/Tix.Api/Responses/{0}/{0}CreateResponse.cs",
            TemplateIdentity.ApiResponsesUpdate => "src/Tix.Api/Responses/{0}/{0}UpdateResponse.cs",
            TemplateIdentity.ApiResponsesDelete => "src/Tix.Api/Responses/{0}/{0}DeleteResponse.cs",
            TemplateIdentity.ApiResponsesCreateRange => "src/Tix.Api/Responses/{0}/{0}CreateRangeResponse.cs",
            TemplateIdentity.ApiResponsesUpdateRange => "src/Tix.Api/Responses/{0}/{0}UpdateRangeResponse.cs",
            TemplateIdentity.ApiResponsesDeleteRange => "src/Tix.Api/Responses/{0}/{0}DeleteRangeResponse.cs",

            // MVC Templates
            TemplateIdentity.MvcModelsIndexViewModel => "src/Tix.Web/Models/{0}/{0}IndexViewModel.cs",
            TemplateIdentity.MvcModelsDetailsViewModel => "src/Tix.Web/Models/{0}/{0}DetailsViewModel.cs",
            TemplateIdentity.MvcModelsCreateViewModel => "src/Tix.Web/Models/{0}/{0}CreateViewModel.cs",
            TemplateIdentity.MvcModelsUpdateViewModel => "src/Tix.Web/Models/{0}/{0}UpdateViewModel.cs",
            TemplateIdentity.MvcModelsDeleteViewModel => "src/Tix.Web/Models/{0}/{0}DeleteViewModel.cs",
            TemplateIdentity.MvcViewsFormsInline => "src/Tix.Web/Views/{0}/Forms/_Inline{0}Form.cshtml",
            TemplateIdentity.MvcViewsFormsCreate => "src/Tix.Web/Views/{0}/Forms/_Create{0}Form.cshtml",
            TemplateIdentity.MvcViewsFormsUpdate => "src/Tix.Web/Views/{0}/Forms/_Update{0}Form.cshtml",
            TemplateIdentity.MvcViewsGrid => "src/Tix.Web/Views/{0}/_Grid.cshtml",
            TemplateIdentity.MvcViewsModalsCreate => "src/Tix.Web/Views/{0}/Modals/_Create{0}Modal.cshtml",
            TemplateIdentity.MvcViewsModalsUpdate => "src/Tix.Web/Views/{0}/Modals/_Update{0}Modal.cshtml",
            TemplateIdentity.MvcViewsModalsDelete => "src/Tix.Web/Views/{0}/Modals/_Delete{0}Modal.cshtml",
            TemplateIdentity.MvcViewsModalsDetails => "src/Tix.Web/Views/{0}/Modals/_Details{0}Modal.cshtml",
            TemplateIdentity.MvcViewsIndex => "src/Tix.Web/Views/{0}/Index.cshtml",
            TemplateIdentity.MvcViewsDetails => "src/Tix.Web/Views/{0}/Details.cshtml",
            TemplateIdentity.MvcViewsCreate => "src/Tix.Web/Views/{0}/Create.cshtml",
            TemplateIdentity.MvcViewsUpdate => "src/Tix.Web/Views/{0}/Update.cshtml",
            TemplateIdentity.MvcViewsDelete => "src/Tix.Web/Views/{0}/Delete.cshtml",
            TemplateIdentity.MvcController => "src/Tix.Web/Controllers/{0}Controller.cs",

            // Console Templates
            TemplateIdentity.ConsoleCommandsCreate => "src/Tix.Console/Commands/{0}/Create{0}Command.cs",
            TemplateIdentity.ConsoleCommandsUpdate => "src/Tix.Console/Commands/{0}/Update{0}Command.cs",
            TemplateIdentity.ConsoleCommandsDelete => "src/Tix.Console/Commands/{0}/Delete{0}Command.cs",
            TemplateIdentity.ConsoleViewsDetails => "src/Tix.Console/Views/{0}/{0}DetailsView.cs",
            TemplateIdentity.ConsoleViewsList => "src/Tix.Console/Views/{0}/{0}ListView.cs",
            TemplateIdentity.ConsoleViewsPagedList => "src/Tix.Console/Views/{0}/{0}PagedListView.cs",

            _ => throw new ArgumentException($"Output path for {templateId} was not found")
        };
    }
}