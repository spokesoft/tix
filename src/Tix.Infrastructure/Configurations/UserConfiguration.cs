using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tix.Infrastructure.Identity;

namespace Tix.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users", "Auth");
        
        builder.HasKey(u => u.Id);
        
        builder.HasIndex(u => u.NormalizedUserName)
            .HasDatabaseName("UserNameIndex")
            .IsUnique();
            
        builder.HasIndex(u => u.NormalizedEmail)
            .HasDatabaseName("EmailIndex");
            
        builder.Property(u => u.ConcurrencyStamp)
            .IsConcurrencyToken();
            
        builder.Property(u => u.UserName)
            .HasMaxLength(256);
            
        builder.Property(u => u.NormalizedUserName)
            .HasMaxLength(256);
            
        builder.Property(u => u.Email)
            .HasMaxLength(256);
            
        builder.Property(u => u.NormalizedEmail)
            .HasMaxLength(256);
            
        builder.Property(u => u.DisplayName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.LastLoginAt)
            .IsRequired(false);

        builder.Property(u => u.CreatedAt)
            .IsRequired();

        builder.Property(u => u.UpdatedAt)
            .IsRequired();

        // Self-referencing relationships
        builder.HasOne(u => u.CreatedBy)
            .WithMany()
            .HasForeignKey(u => u.CreatedById)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(u => u.UpdatedBy)
            .WithMany()
            .HasForeignKey(u => u.UpdatedById)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(u => u.DeletedBy)
            .WithMany()
            .HasForeignKey(u => u.DeletedById)
            .OnDelete(DeleteBehavior.NoAction);

        // Soft delete filter
        builder.HasQueryFilter(u => u.DeletedAt == null);
    }
}
