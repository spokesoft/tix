using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tix.Infrastructure.Identity;

namespace Tix.Infrastructure.Configurations;

public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
{
    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.ToTable("UserTokens", "Auth");
        
        builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
        
        builder.Property(t => t.LoginProvider)
            .HasMaxLength(128);
            
        builder.Property(t => t.Name)
            .HasMaxLength(128);
    }
}
