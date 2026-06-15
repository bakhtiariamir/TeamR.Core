using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Database.Dataset.Entity;

public class ChartConfiguration : IEntityTypeConfiguration<Chart>
{
    public void Configure(EntityTypeBuilder<Chart> builder)
    {
        builder.ToTable("Chart", "organization");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(512);
        builder.Property(p => p.Description).IsRequired(false).HasMaxLength(4000);
        builder.Property(p => p.ChartType).IsRequired();
        
        builder.HasMany(p => p.Departments).WithOne(p => p.Chart).HasForeignKey(p => p.ChartId).OnDelete(DeleteBehavior.Cascade);
    }
}