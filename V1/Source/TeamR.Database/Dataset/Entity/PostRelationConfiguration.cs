using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Database.Dataset.Entity;

public class PostRelationConfiguration : IEntityTypeConfiguration<PostRelation>
{
    public void Configure(EntityTypeBuilder<PostRelation> builder)
    {
        builder.ToTable("PostRelation", "organization");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Type).IsRequired();
        
        builder.HasOne(p => p.Post).WithMany(p => p.Relations).HasForeignKey(p => p.PostId).OnDelete(DeleteBehavior.Cascade);
    }
}