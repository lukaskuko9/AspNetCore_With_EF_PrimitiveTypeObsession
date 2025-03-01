namespace PrimitiveTypeObsession.WebApi;

public static class DiConfig
{
    public static void ConfigureServices(IServiceCollection services, ConfigurationManager config)
    {
        PrimitiveTypeObsession.Core.DiConfig.ConfigureServices(services, config);
        PrimitiveTypeObsession.Infrastructure.DiConfig.ConfigureServices(services, config);
    }
}