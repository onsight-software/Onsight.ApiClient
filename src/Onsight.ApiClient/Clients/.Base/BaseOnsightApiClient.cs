using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Blauhaus.Analytics.Abstractions.Extensions;
using Blauhaus.Analytics.Abstractions.Service;
using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Extensions;
using Onsight.ApiClient.Clients.Auth;

namespace Onsight.ApiClient.Clients.Base
{

    public abstract class BaseOnsightApiClient
    {
        protected readonly HttpClient HttpClient;
        protected readonly IOnsightApiClientConfig Config;

        protected BaseOnsightApiClient(
            HttpClient httpClient,
            IOnsightApiClientConfig config)
        {
            HttpClient = httpClient;
            Config = config;

            HttpClient.BaseAddress = new Uri(config.ServiceUrl);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }

    public abstract class BaseOnsightApiClient<TDto> : BaseOnsightApiClient, IOnsightApiClient<TDto> where TDto : OnsightDto
    {
        private readonly IAuthenticationClient _authenticationClient;
        private readonly string _uri;

        protected readonly IAnalyticsService AnalyticsService;

        protected BaseOnsightApiClient(
            HttpClient httpClient, 
            IAnalyticsService analyticsService,
            IOnsightApiClientConfig config,
            IAuthenticationClient authenticationClient,
            string endpoint) 
                : base(httpClient, config)
        {
            AnalyticsService = analyticsService;
            _authenticationClient = authenticationClient;

            var baseUrl = config.ServiceUrl;
            if (!baseUrl.EndsWith('/')) baseUrl += '/';

            if (!endpoint.EndsWith('/')) endpoint += '/';

            _uri = baseUrl + endpoint;
        }

        public async Task<TDto> GetAsync(long id, CancellationToken token = default)
        {
            var uri = new Uri(_uri + id);
            using var _ = AnalyticsService.StartTrace(this, $"GET {uri}");
            
            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            
            var response = await HttpClient.GetAsync(uri, token);
            return await response.UnwrapResponseAsync<TDto>();
        }


        protected async Task<TDto> PatchAsync<T>(T command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = AnalyticsService.StartTrace(this, $"PATCH {uri}", LogSeverity.Verbose, command.ToObjectDictionary());

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            var response = await HttpClient.PatchAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TDto>(); 
        }

        protected async Task<TDto> PostAsync<TCommand>(TCommand command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = AnalyticsService.StartTrace(this, $"POST {uri}", LogSeverity.Verbose, command.ToObjectDictionary());

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            HttpResponseMessage response = await HttpClient.PostAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TDto>(); 
        }

        protected async Task<TReturnValue> PostAsync<TReturnValue, TCommand>(TCommand command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = AnalyticsService.StartTrace(this, $"POST {uri}", LogSeverity.Verbose, command.ToObjectDictionary());

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            HttpResponseMessage response = await HttpClient.PostAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TReturnValue>(); 
        }
         
        
        public async Task DeleteAsync(long id, CancellationToken token = default)
        {
            var uri = new Uri(_uri + id);
            
            using var _ = AnalyticsService.StartTrace(this, $"DELETE {uri}", LogSeverity.Verbose, id.ToObjectDictionary());

            await _authenticationClient.AuthenticateAsync(HttpClient, token);

            HttpResponseMessage response = await HttpClient.DeleteAsync(uri, token);
            await response.EnsureSuccessStatusCodeAsync(); 
        }

    }
}