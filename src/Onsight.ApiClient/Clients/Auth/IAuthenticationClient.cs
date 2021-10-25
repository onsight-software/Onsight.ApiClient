using System.Net.Http;
using System.Threading;
using System.Threading.Tasks; 

namespace Onsight.ApiClient.Clients.Auth
{
    public interface IAuthenticationClient
    {
        Task AuthenticateAsync(HttpClient httpClient, CancellationToken token = default);
        Task AuthenticateUserAsync(HttpClient httpClient, string emailAddress, string password, CancellationToken token = default);
    }
}