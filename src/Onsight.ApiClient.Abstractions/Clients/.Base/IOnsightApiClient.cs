using System.Threading;
using System.Threading.Tasks;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Clients.Base
{
    public interface IOnsightApiClient<TModel> 
        where TModel : IOnsightModel
    {
        Task<TModel> GetOneAsync(long id, CancellationToken token = default);
    }
}