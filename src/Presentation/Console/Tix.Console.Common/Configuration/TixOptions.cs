using Tix.Console.Common.Enums;

namespace Tix.Console.Common.Configuration;

public class TixOptions
{
    public const string SectionName = "Tix";

    public ExecutionMode Mode { get; set; } = ExecutionMode.Local;
    public LocalOptions Local { get; set; } = new();
    public RemoteOptions Remote { get; set; } = new();
}