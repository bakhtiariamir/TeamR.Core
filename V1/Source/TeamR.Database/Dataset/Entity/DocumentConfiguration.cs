using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Database.Dataset.Entity;

public class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {   
        builder.ToTable("Document", "doc");
        builder.HasKey(r => r.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).HasMaxLength(500).IsRequired();
        builder.Property(p => p.Url).HasMaxLength(2000).IsRequired();
        builder.Property(p => p.Description).IsRequired(false);
        builder.Property(p => p.DocumentType).IsRequired();
        builder.Property(p => p.Body).IsRequired();
        builder.HasOne(p => p.Version).WithMany(item => item.Documents).HasForeignKey(item => item.VersionId).OnDelete(DeleteBehavior.Cascade);
    }
}