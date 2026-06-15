using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Account; 

namespace TeamR.Database.Dataset.Entity;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {   
        builder.ToTable("User", "account");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(x => x.Address).HasMaxLength(4000);
        builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(500).IsRequired();
        builder.Property(x => x.Mobile).HasMaxLength(256);
        builder.Property(x => x.Sex).IsRequired();
        builder.Property(x => x.Birthday).IsRequired();
        builder.Property(x => x.Latitude).IsRequired(false);
        builder.Property(x => x.Longitude).IsRequired(false);
        builder.Property(x => x.Altitude).IsRequired(false);
        builder.HasOne(item => item.Account).WithOne(item => item.User).HasForeignKey<Account>(item => item.UserId).OnDelete(DeleteBehavior.Cascade);
    }
}