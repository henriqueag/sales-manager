using Application;
using Domain;
using Identity;
using Infrastructure;
using Presentation.RestApi.Filters;

namespace Runtime.Host.IoC;

public static class NativeInjectorConfig
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterDomainServices();
        services.RegisterApplicationServices();
        services.RegisterInfrastructureServices(configuration);
        services.RegisterIdentityServices(configuration);

        services.AddMvc(options =>
        {
            options.Filters.Add<UserFriendlyExceptionFilter>();
        });        
    }
}
