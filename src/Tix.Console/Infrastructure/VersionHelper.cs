using System.Reflection;
using System.Text.RegularExpressions;

namespace Tix.Console.Infrastructure;

public static partial class VersionHelper
{
    private static readonly Regex _prereleaseRegex = PrereleaseRegex();

    /// <summary>
    /// Gets the product version from the executing assembly including any prerelease tag
    /// </summary>
    public static string GetProductVersion()
    {
        var assembly = Assembly.GetExecutingAssembly();

        // Try to get the informational version first (from AssemblyInformationalVersionAttribute)
        var infoVersionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
        if (infoVersionAttribute != null)
        {
            return ParseVersionWithPrerelease(infoVersionAttribute.InformationalVersion);
        }

        // Fall back to assembly version
        var version = assembly.GetName().Version;
        return version != null
            ? $"{version.Major}.{version.Minor}.{version.Build}"
            : "1.0.0";
    }

    /// <summary>
    /// Gets the file version from the executing assembly
    /// </summary>
    public static string GetFileVersion()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var fileVersionAttribute = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();

        if (fileVersionAttribute != null)
        {
            return fileVersionAttribute.Version;
        }

        // Fall back to assembly version
        var version = assembly.GetName().Version;
        return version != null
            ? $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}"
            : "1.0.0.0";
    }

    /// <summary>
    /// Gets the version components (major, minor, build, revision) as well as any prerelease tag
    /// </summary>
    public static (int Major, int Minor, int Build, int Revision, string? PrereleaseTag) GetVersionComponents()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var version = assembly.GetName().Version!;

        // Try to get prerelease tag from informational version
        var infoVersionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
        string? prereleaseTag = null;

        if (infoVersionAttribute != null)
        {
            var match = _prereleaseRegex.Match(infoVersionAttribute.InformationalVersion);
            if (match.Success && match.Groups["prerelease"].Success)
            {
                prereleaseTag = match.Groups["prerelease"].Value;
            }
        }

        return (version.Major, version.Minor, version.Build, version.Revision, prereleaseTag);
    }

    /// <summary>
    /// Parse a version string to extract the version and prerelease tag
    /// </summary>
    private static string ParseVersionWithPrerelease(string versionString)
    {
        var match = _prereleaseRegex.Match(versionString);
        if (match.Success)
        {
            var version = match.Groups["version"].Value;
            var prerelease = match.Groups["prerelease"].Value;

            return version + prerelease;
        }

        return versionString;
    }

    /// <summary>
    /// Determines if the current version is a prerelease version
    /// </summary>
    public static bool IsPrerelease()
    {
        var (_, _, _, _, prereleaseTag) = GetVersionComponents();
        return !string.IsNullOrEmpty(prereleaseTag);
    }

    [GeneratedRegex(@"(?<version>\d+\.\d+\.\d+)(?<prerelease>-[a-zA-Z0-9.-]+)?", RegexOptions.Compiled)]
    private static partial Regex PrereleaseRegex();
}