using System.Threading;
using System.Threading.Tasks;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Clients.Base
{
    public interface IOnsightApiClient<TModel> 
        where TModel : OnsightDto
    {
        Task<TModel> GetAsync(long id, CancellationToken token = default);
        Task DeleteAsync(long id, CancellationToken token = default);
    }
}