using Microsoft.Extensions.DependencyInjection;
using Onsight.ApiClient.Abstractions.Clients;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Clients.Auth;

namespace Onsight.ApiClient.Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOnsightApiClient<TConfig>(this IServiceCollection services) 
            where TConfig : class, IOnsightApiClientConfig
        {
            return services
                .AddSingleton<IOnsightApiClientConfig, TConfig>()
                .AddClients();
        }

        public static IServiceCollection AddOnsightApiClient(this IServiceCollection services, string apiKey, string apiSecret) 
        {
            return services
                .AddSingleton<IOnsightApiClientConfig>(new OnsightApiClientConfig(apiKey, apiSecret))
                .AddClients();
        }

        private static IServiceCollection AddClients(this IServiceCollection services)
        {
            services.AddHttpClient<IAuthenticationClient, AuthenticationClient>();
            services.AddHttpClient<IProductsClient, ProductsClient>();
            return services;
        }
    }
}