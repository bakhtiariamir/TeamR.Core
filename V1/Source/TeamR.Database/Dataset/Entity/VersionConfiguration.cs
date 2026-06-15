using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TeamR.Database.Dataset.Entity;

public class VersionConfiguration : IEntityTypeConfiguration<Domain.Entities.Version.Version>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Version.Version> builder)
    {
        builder.ToTable("Version", "doc");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Major).IsRequired().HasMaxLength(10);
        builder.Property(p => p.Minor).IsRequired().HasMaxLength(10);
        builder.Property(p => p.Patch).IsRequired().HasMaxLength(10);
        builder.Property(p => p.ReleaseDate).HasDefaultValueSql("GETDATE()");
        builder.HasMany(item => item.Documents).WithOne(item => item.Version).HasForeignKey(item => item.VersionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}