using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tix.Domain.Entities;

namespace Tix.Infrastructure.Common.Configurations;

public class {{ name }}TypeConfiguration : IEntityTypeConfiguration<{{ name }}>
{
    public void Configure(EntityTypeBuilder<{{ name }}> builder)
    {
        // TODO: Implement
    }
}