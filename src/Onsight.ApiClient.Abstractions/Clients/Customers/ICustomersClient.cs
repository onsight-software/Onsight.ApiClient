using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Dtos.Customers;

namespace Onsight.ApiClient.Abstractions.Clients.Customers
{
    public interface ICustomersClient : IOnsightApiClient<CustomerDto>
    {
        
    }
}