using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Onsight.ApiClient.Abstractions.Clients;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Models.Products;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients
{
    public class ProductsClient : BaseOnsightApiClient<ProductDto>, IProductsClient
    {
        public ProductsClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig config,
            IAuthenticationClient authenticationClient) 
            : base(httpClient, config, authenticationClient, "products")
        {
        }

        public Task<ProductDto> UpdatePriceAsync(long id, decimal newPrice, CancellationToken token = default)
        {
            throw new System.NotImplementedException();
        }
    }
}