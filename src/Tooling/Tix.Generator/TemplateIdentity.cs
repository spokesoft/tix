namespace Tix.Generator;

public static class TemplateIdentity
{
    // Domain Templates
    public const string DomainEntity = "domain:entity";
    public const string DomainEventsArchived = "domain:events:archived";
    public const string DomainEventsCreated = "domain:events:created";
    public const string DomainEventsDeleted = "domain:events:deleted";
    public const string DomainEventsRestored = "domain:events:restored";
    public const string DomainEventsUpdated = "domain:events:updated";
    public const string DomainExceptionsNotFound = "domain:exceptions:notfound";
    public const string DomainExceptionsDuplicate = "domain:exceptions:duplicate";
    
    // Application Templates
    public const string ApplicationCommandsCreate = "Tix.Templates.Application.Commands.Create";
    public const string ApplicationCommandsUpdate = "Tix.Templates.Application.Commands.Update";
    public const string ApplicationCommandsDelete = "Tix.Templates.Application.Commands.Delete";
    public const string ApplicationCommandsArchive = "Tix.Templates.Application.Commands.Archive";
    public const string ApplicationCommandsRestore = "Tix.Templates.Application.Commands.Restore";
    public const string ApplicationCommandsCreateRange = "Tix.Templates.Application.Commands.CreateRange";
    public const string ApplicationCommandsUpdateRange = "Tix.Templates.Application.Commands.UpdateRange";
    public const string ApplicationCommandsDeleteRange = "Tix.Templates.Application.Commands.DeleteRange";
    public const string ApplicationCommandsArchiveRange = "Tix.Templates.Application.Commands.ArchiveRange";
    public const string ApplicationCommandsRestoreRange = "Tix.Templates.Application.Commands.RestoreRange";
    public const string ApplicationDTOsDetails = "Tix.Templates.Application.DTOs.Details";
    public const string ApplicationDTOsListItem = "Tix.Templates.Application.DTOs.ListItem";
    public const string ApplicationDTOsSelectListItem = "Tix.Templates.Application.DTOs.SelectListItem";
    public const string ApplicationInterfacesRepository = "Tix.Templates.Application.Interfaces.Repository";
    public const string ApplicationInterfacesService = "Tix.Templates.Application.Interfaces.Service";
    public const string ApplicationQueriesGetList = "Tix.Templates.Application.Queries.GetList";
    public const string ApplicationQueriesGetById = "Tix.Templates.Application.Queries.GetById";
    public const string ApplicationQueriesGetByCode = "Tix.Templates.Application.Queries.GetByCode";
    public const string ApplicationQueriesGetByName = "Tix.Templates.Application.Queries.GetByName";
    public const string ApplicationService = "Tix.Templates.Application.Service";
    public const string ApplicationValidatorsCreate = "Tix.Templates.Application.Validators.Create";
    public const string ApplicationValidatorsUpdate = "Tix.Templates.Application.Validators.Update";
    public const string ApplicationValidatorsDelete = "Tix.Templates.Application.Validators.Delete";
    
    // Infrastructure Templates
    public const string InfrastructureIdentityEntity = "Tix.Templates.Infrastructure.Identity.Entity";
    public const string InfrastructureConfiguration = "Tix.Templates.Infrastructure.Configuration";
    public const string InfrastructureRepository = "Tix.Templates.Infrastructure.Repository";
    
    // API Templates
    public const string ApiController = "Tix.Templates.Api.Controller";
    public const string ApiResponsesGet = "Tix.Templates.Api.Responses.Get";
    public const string ApiResponsesCreate = "Tix.Templates.Api.Responses.Create";
    public const string ApiResponsesUpdate = "Tix.Templates.Api.Responses.Update";
    public const string ApiResponsesDelete = "Tix.Templates.Api.Responses.Delete";
    public const string ApiResponsesCreateRange = "Tix.Templates.Api.Responses.CreateRange";
    public const string ApiResponsesUpdateRange = "Tix.Templates.Api.Responses.UpdateRange";
    public const string ApiResponsesDeleteRange = "Tix.Templates.Api.Responses.DeleteRange";
    
    // MVC Templates
    public const string MvcModelsIndexViewModel = "Tix.Templates.Mvc.Models.IndexViewModel";
    public const string MvcModelsDetailsViewModel = "Tix.Templates.Mvc.Models.DetailsViewModel";
    public const string MvcModelsCreateViewModel = "Tix.Templates.Mvc.Models.CreateViewModel";
    public const string MvcModelsUpdateViewModel = "Tix.Templates.Mvc.Models.UpdateViewModel";
    public const string MvcModelsDeleteViewModel = "Tix.Templates.Mvc.Models.DeleteViewModel";
    public const string MvcViewsFormsInline = "Tix.Templates.Mvc.Views.Forms.Inline";
    public const string MvcViewsFormsCreate = "Tix.Templates.Mvc.Views.Forms.Create";
    public const string MvcViewsFormsUpdate = "Tix.Templates.Mvc.Views.Forms.Update";
    public const string MvcViewsGrid = "Tix.Templates.Mvc.Views.Grid";
    public const string MvcViewsModalsCreate = "Tix.Templates.Mvc.Views.Modals.Create";
    public const string MvcViewsModalsUpdate = "Tix.Templates.Mvc.Views.Modals.Update";
    public const string MvcViewsModalsDelete = "Tix.Templates.Mvc.Views.Modals.Delete";
    public const string MvcViewsModalsDetails = "Tix.Templates.Mvc.Views.Modals.Details";
    public const string MvcViewsIndex = "Tix.Templates.Mvc.Views.Index";
    public const string MvcViewsDetails = "Tix.Templates.Mvc.Views.Details";
    public const string MvcViewsCreate = "Tix.Templates.Mvc.Views.Create";
    public const string MvcViewsUpdate = "Tix.Templates.Mvc.Views.Update";
    public const string MvcViewsDelete = "Tix.Templates.Mvc.Views.Delete";
    public const string MvcController = "Tix.Templates.Mvc.Controller";
    
    // Console Templates
    public const string ConsoleCommandsCreate = "Tix.Templates.Console.Commands.Create";
    public const string ConsoleCommandsUpdate = "Tix.Templates.Console.Commands.Update";
    public const string ConsoleCommandsDelete = "Tix.Templates.Console.Commands.Delete";
    public const string ConsoleViewsDetails = "Tix.Templates.Console.Views.Details";
    public const string ConsoleViewsList = "Tix.Templates.Console.Views.List";
    public const string ConsoleViewsPagedList = "Tix.Templates.Console.Views.PagedList";
}