using System.Threading;
using System.Threading.Tasks;
using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Models.Products;

namespace Onsight.ApiClient.Abstractions.Clients
{
    public interface IProductsClient : IOnsightApiClient<ProductDto>
    {
        Task<ProductDto> UpdatePriceAsync(long id, decimal newPrice, CancellationToken token = default);
    }
}