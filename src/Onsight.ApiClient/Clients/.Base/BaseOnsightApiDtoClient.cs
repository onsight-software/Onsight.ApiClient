using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Blauhaus.Analytics.Abstractions;
using Microsoft.Extensions.Logging;
using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Extensions;
using Onsight.ApiClient.Clients.Auth;

namespace Onsight.ApiClient.Clients.Base
{



    public abstract class BaseOnsightApiDtoClient<TDto> : BaseOnsightApiClient, IOnsightApiClient<TDto> where TDto : OnsightDto
    {
        private readonly IAuthenticationClient _authenticationClient;
        private readonly string _uri;

        protected readonly IAnalyticsLogger Logger;

        protected BaseOnsightApiDtoClient(
            HttpClient httpClient, 
            IAnalyticsLogger logger,
            IOnsightApiClientConfig config,
            IAuthenticationClient authenticationClient,
            string endpoint) 
                : base(httpClient, config)
        {
            Logger = logger;
            _authenticationClient = authenticationClient;

            var baseUrl = config.ServiceUrl;
            if (!baseUrl.EndsWith('/')) baseUrl += '/';

            if (!endpoint.EndsWith('/')) endpoint += '/';

            _uri = baseUrl + endpoint;
        }

        public async Task<TDto> GetAsync(long id, CancellationToken token = default)
        {
            var uri = new Uri(_uri + id);
            using var _ = Logger.BeginTimedScope(LogLevel.Debug, "GET {uri}", _uri);
            
            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            
            var response = await HttpClient.GetAsync(uri, token);
            return await response.UnwrapResponseAsync<TDto>();
        }


        protected async Task<TDto> PatchAsync<T>(T command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = Logger.BeginTimedScope(LogLevel.Debug, "PATCH {uri}", _uri);

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            var response = await HttpClient.PatchAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TDto>(); 
        }

        protected async Task<TDto> PostAsync<TCommand>(TCommand command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = Logger.BeginTimedScope(LogLevel.Debug, "POST {uri}", _uri);

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            HttpResponseMessage response = await HttpClient.PostAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TDto>(); 
        }

        protected async Task<TReturnValue> PostAsync<TReturnValue, TCommand>(TCommand command, string route, CancellationToken token = default)
        {
            var uri = new Uri(_uri + route);
            
            using var _ = Logger.BeginTimedScope(LogLevel.Debug, "POST {uri}", _uri);

            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            var payload = command.ToHttpContent();

            HttpResponseMessage response = await HttpClient.PostAsync(uri, payload, token);
            return await response.UnwrapResponseAsync<TReturnValue>(); 
        }
         
        
        public async Task DeleteAsync(long id, CancellationToken token = default)
        {
            var uri = new Uri(_uri + id);
            
            using var _ = Logger.BeginTimedScope(LogLevel.Debug, "DELETE {uri}", _uri);

            await _authenticationClient.AuthenticateAsync(HttpClient, token);

            HttpResponseMessage response = await HttpClient.DeleteAsync(uri, token);
            await response.EnsureSuccessStatusCodeAsync(); 
        }

    }
}