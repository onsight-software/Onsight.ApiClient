using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Blauhaus.Analytics.Abstractions.Service;
using Onsight.ApiClient.Abstractions.Clients.Products;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Dtos.Common;
using Onsight.ApiClient.Abstractions.Dtos.Products;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients
{
    public class ProductsClient : BaseOnsightApiClient<ProductDto>, IProductsClient
    {
        public ProductsClient(
            HttpClient httpClient, 
            IAnalyticsService analyticsService,
            IOnsightApiClientConfig clientConfig,
            IAuthenticationClient authenticationClient) 
            : base(httpClient, analyticsService, clientConfig, authenticationClient, "products")
        {
        }

        public async Task<ProductDto> UpdatePriceAsync(long id, decimal newPrice, CancellationToken token = default)
        {
            var existingProduct = await GetAsync(id, token);

            var updatedProduct = existingProduct with
            {
                Links = Array.Empty<LinkDto>(),
                PrimaryImage = $"{existingProduct.ImageLocation}/id/{existingProduct.PrimaryImage}",
                Price = newPrice,
            };

            return await PatchAsync(updatedProduct, id.ToString(), token);
        }
    }
}