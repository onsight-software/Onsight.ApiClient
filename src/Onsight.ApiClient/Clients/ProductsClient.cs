using System.Net.Http;
using Onsight.ApiClient.Abstractions.Clients;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Models.Products;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients
{
    public class ProductsClient : BaseOnsightApiClient<Product>, IProductsClient
    {
        public ProductsClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig config,
            IAuthenticationClient authenticationClient) 
            : base(httpClient, config, authenticationClient, "products")
        {
        }
    }
}