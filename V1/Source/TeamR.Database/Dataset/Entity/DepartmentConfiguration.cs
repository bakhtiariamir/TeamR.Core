using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Database.Dataset.Entity;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Department", "organization");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(512);
        builder.Property(p => p.Description).IsRequired(false).HasMaxLength(4000);

        builder.HasOne(p => p.Parent).WithMany().HasForeignKey(p => p.ParentId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.Chart).WithMany(p => p.Departments).HasForeignKey(p => p.ChartId).OnDelete(DeleteBehavior.Cascade);
    }
}