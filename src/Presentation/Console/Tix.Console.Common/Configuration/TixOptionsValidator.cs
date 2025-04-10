using Microsoft.Extensions.Options;
using Tix.Console.Common.Enums;

namespace Tix.Console.Common.Configuration;

public class TixOptionsValidator : IValidateOptions<TixOptions>
{
    public ValidateOptionsResult Validate(string? name, TixOptions options)
    {
        var errors = new List<string>();
        switch (options.Mode)
        {
            case ExecutionMode.Local:
                if (string.IsNullOrEmpty(options.Local.DataSource))
                    errors.Add("Local data source must be provided.");
                break;
            
            case ExecutionMode.Remote:
                if (string.IsNullOrEmpty(options.Remote.Url))
                    errors.Add("Remote url must be provided.");
                break;
        }

        return errors.Count > 0
            ? ValidateOptionsResult.Fail(errors) 
            : ValidateOptionsResult.Success;
    }
}