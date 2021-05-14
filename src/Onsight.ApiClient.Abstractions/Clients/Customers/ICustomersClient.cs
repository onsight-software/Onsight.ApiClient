using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Blauhaus.Responses;
using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Commands.Customers;
using Onsight.ApiClient.Abstractions.Dtos.Common;
using Onsight.ApiClient.Abstractions.Dtos.Customers;

namespace Onsight.ApiClient.Abstractions.Clients.Customers
{
    public interface ICustomersClient : IOnsightApiClient<CustomerDto>
    {
        Task<CustomerDto> CreateAsync(CustomerCreateCommand command, CancellationToken token = default);
        Task<DtoBatch<CustomerDto>> SearchAsync(CustomerSearchCommand command, CancellationToken token = default);
    }
}