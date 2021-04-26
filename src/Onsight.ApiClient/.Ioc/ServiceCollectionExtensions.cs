using Microsoft.Extensions.DependencyInjection;
using Onsight.ApiClient.Abstractions.Clients;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Clients.Auth;

namespace Onsight.ApiClient.Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOnsightClients<TConfig>(this IServiceCollection services) 
            where TConfig : class, IOnsightApiClientConfig
        {

            services.AddSingleton<IOnsightApiClientConfig, TConfig>();

            services.AddHttpClient<IAuthenticationClient, AuthenticationClient>();
            services.AddHttpClient<IProductsClient, ProductsClient>();

            return services;
        }
    }
}