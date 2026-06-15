using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamR.Domain.Entities.Account;

namespace TeamR.Database.Dataset.Entity;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Account", "account");
        builder.HasKey(r => r.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        builder.Property(p => p.Username).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Password).HasMaxLength(250).IsRequired();   
        builder.Property(p => p.Email).HasMaxLength(250).IsRequired();
        builder.Property(p => p.Image).IsRequired(false);
        builder.Property(p => p.User).IsRequired(false);
        
        builder.HasOne(item => item.User)
            .WithOne(item => item.Account)
            .HasForeignKey<User>(item => item.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}