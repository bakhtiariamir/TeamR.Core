using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TeamR.Database.Dataset;

namespace TeamR.Database;

public static class Setup
{
    public static void DatabaseSetup(this IServiceCollection service, string connectionString)
    {
        service.AddDbContextFactory<ApplicationContext>(sql => sql.UseSqlServer(connectionString));
    }
}