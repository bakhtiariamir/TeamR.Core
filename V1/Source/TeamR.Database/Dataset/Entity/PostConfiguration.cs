using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Core.Type;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Database.Dataset.Entity;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Post", "organization");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(512);
        builder.Property(p => p.Description).IsRequired(false).HasMaxLength(4000);
        builder.Property(p => p.Capacity).IsRequired().HasMaxLength(20);
        
        builder.HasOne(p => p.Chart).WithMany(p => p.Posts).HasForeignKey(p => p.ChartId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.Department).WithMany(p => p.Posts).HasForeignKey(p => p.DepartmentId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(p => p.Relations).WithOne(p => p.Post).OnDelete(DeleteBehavior.NoAction);
    }
}