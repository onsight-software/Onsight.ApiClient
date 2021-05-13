using System.Net.Http;
using Onsight.ApiClient.Abstractions.Clients.Customers;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Customers;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients
{
    public class CustomersClient : BaseOnsightApiClient<CustomerDto>, ICustomersClient
    {
        public CustomersClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig config, 
            IAuthenticationClient authenticationClient) 
                : base(httpClient, config, authenticationClient, "customers")
        {
        }
    }
}