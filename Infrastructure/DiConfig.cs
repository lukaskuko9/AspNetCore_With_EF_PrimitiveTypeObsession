using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrimitiveTypeObsession.Infrastructure.Database;

namespace PrimitiveTypeObsession.Infrastructure;

public static class DiConfig
{
    public static void ConfigureServices(IServiceCollection services, ConfigurationManager config)
    {
        var dbConnectionString = config.GetConnectionString("MyDatabase");
        services.AddSqlite<MyDbContext>(dbConnectionString);
    }
}