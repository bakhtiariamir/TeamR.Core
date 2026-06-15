using Microsoft.EntityFrameworkCore;
using TeamR.Database.Dataset.Entity;
using TeamR.Domain.Entities.Account;
using TeamR.Domain.Entities.Organization;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Database.Dataset;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Domain.Entities.Version.Version> Versions { get; set; }
    public DbSet<Account>  Accounts { get; set; }
    public DbSet<Folder>  Folders { get; set; }
    public DbSet<Document>  Documents { get; set; }
    public DbSet<Chart>  Charts { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostRelation> PostRelations { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new VersionConfiguration());
        modelBuilder.ApplyConfiguration(new DocumentConfiguration());
        modelBuilder.ApplyConfiguration(new FolderConfiguration());
        modelBuilder.ApplyConfiguration(new ChartConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new PostRelationConfiguration());
    }
}