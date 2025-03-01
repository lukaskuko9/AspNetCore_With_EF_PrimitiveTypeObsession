namespace PrimitiveTypeObsession.WebApi;

public static class DiConfig
{
    public static void ConfigureServices(IServiceCollection services, ConfigurationManager config)
    {
        Core.DiConfig.ConfigureServices(services, config);
        Infrastructure.DiConfig.ConfigureServices(services, config);
    }
}