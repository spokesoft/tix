using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tix.Infrastructure.Identity;

namespace Tix.Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles", "Auth");
        
        builder.HasKey(r => r.Id);
        
        builder.HasIndex(r => r.NormalizedName)
            .HasDatabaseName("RoleNameIndex")
            .IsUnique();
            
        builder.Property(r => r.ConcurrencyStamp)
            .IsConcurrencyToken();
            
        builder.Property(r => r.Name)
            .HasMaxLength(256);
            
        builder.Property(r => r.NormalizedName)
            .HasMaxLength(256);
    }
}
