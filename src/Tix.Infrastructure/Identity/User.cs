using Microsoft.AspNetCore.Identity;
using Tix.Domain.Interfaces;

namespace Tix.Infrastructure.Identity;

public class User : IdentityUser<long>, IUser
{
    public string DisplayName { get; set; } = string.Empty;
    public DateTime? LastLoginAt { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public long CreatedById { get; set; }
    public long UpdatedById { get; set; }
    public long? DeletedById { get; set; }

    public IUser CreatedBy { get; set; } = null!;
    public IUser UpdatedBy { get; set; } = null!;
    public IUser? DeletedBy { get; set; }
}