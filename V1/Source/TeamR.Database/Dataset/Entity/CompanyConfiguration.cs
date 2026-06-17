using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Database.Dataset.Entity;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Company", "organization");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(512);
        builder.Property(p => p.Description).IsRequired(false).HasMaxLength(4000);
        builder.Property(p => p.ChartType).IsRequired();
        
        builder.HasMany(p => p.Departments).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId).OnDelete(DeleteBehavior.Cascade);
    }
}