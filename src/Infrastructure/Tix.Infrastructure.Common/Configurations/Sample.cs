using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tix.Domain.Entities;

namespace Tix.Infrastructure.Common.Configurations;

public class SampleTypeConfiguration : IEntityTypeConfiguration<Board>
{
    public void Configure(EntityTypeBuilder<Board> builder)
    {
        // TODO: Implement
    }
}