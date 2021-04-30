using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Models.Products;

namespace Onsight.ApiClient.Abstractions.Clients
{
    public interface IProductsClient : IOnsightApiClient<ProductDto>
    {
        
    }
}