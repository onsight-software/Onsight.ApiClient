using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Blauhaus.Analytics.Abstractions.Service;
using Blauhaus.Errors;
using Blauhaus.Responses;
using Onsight.ApiClient.Abstractions.Clients.Customers;
using Onsight.ApiClient.Abstractions.Commands.Customers;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Common;
using Onsight.ApiClient.Abstractions.Dtos.Customers;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients
{
    public class CustomersClient : BaseOnsightApiClient<CustomerDto>, ICustomersClient
    {
        public CustomersClient(
            HttpClient httpClient, 
            IAnalyticsService analyticsService,
            IOnsightApiClientConfig config, 
            IAuthenticationClient authenticationClient) 
                : base(httpClient, analyticsService, config, authenticationClient, "customers")
        {
        }

        public async Task<CustomerDto> CreateAsync(CustomerCreateCommand command, CancellationToken token = default)
        {
            return await PostAsync(command, "", token);
        }
         

        public async Task<DtoBatch<CustomerDto>> SearchAsync(CustomerSearchCommand command, CancellationToken token = default)
        {
            return await PostAsync<DtoBatch<CustomerDto>, CustomerSearchCommand>(command, "search", token);
        }
    }
}