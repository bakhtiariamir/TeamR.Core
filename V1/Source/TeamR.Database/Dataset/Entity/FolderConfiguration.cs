using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Database.Dataset.Entity;

public class FolderConfiguration : IEntityTypeConfiguration<Folder>
{
    public void Configure(EntityTypeBuilder<Folder> builder)
    {
        builder.ToTable("Folder", "doc");
        builder.HasKey(r => r.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
        builder.Property(p => p.Path).HasMaxLength(500).IsRequired();
        builder.Property(p => p.IsHidden);
        builder.Property(p => p.Password).HasMaxLength(250).IsRequired(false);
        builder.HasOne(item => item.Parent).WithMany().OnDelete(DeleteBehavior.NoAction);
    }
}