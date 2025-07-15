using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PrimitiveTypeObsession.Infrastructure.Database;

namespace PrimitiveTypeObsession.Infrastructure;

public static class DiConfig
{
    public static void ConfigureServices(IServiceCollection services, ConfigurationManager config)
    {
        services.AddDbContext<DatabaseContext>(options =>
        {
            var dbConnectionString = config.GetConnectionString("MyDatabase");
            options.UseSqlServer(dbConnectionString);
        });
    }
}