using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Onsight.ApiClient.Abstractions.Clients.Base;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Models.Base;
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

    public abstract class BaseOnsightApiClient<TModel> : BaseOnsightApiClient, IOnsightApiClient<TModel> where TModel : OnsightDto
    {
        private readonly IAuthenticationClient _authenticationClient;
        private readonly string _uri;

        protected BaseOnsightApiClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig config,
            IAuthenticationClient authenticationClient,
            string endpoint) 
                : base(httpClient, config)
        {
            _authenticationClient = authenticationClient;

            var baseUrl = config.ServiceUrl;
            if (!baseUrl.EndsWith('/')) baseUrl += '/';

            if (!endpoint.EndsWith('/')) endpoint += '/';

            _uri = baseUrl + endpoint;
        }

        public async Task<TModel> GetAsync(long id, CancellationToken token = default)
        {
            await _authenticationClient.AuthenticateAsync(HttpClient, token);
            
            var uri = new Uri(_uri + id);
            var response = await HttpClient.GetAsync(uri, token);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var responseDto = JsonConvert.DeserializeObject<TModel>(responseString);
                if (responseDto == null)
                {
                    throw new Exception($"Null response returned from API for {typeof(TModel).Name} with id {id}");
                }
                
                return responseDto;
            }

            throw new Exception($"Error response returned from API for {typeof(TModel).Name} with id {id}: {response.StatusCode} ({response.ReasonPhrase})");
        }


        protected async Task<TModel> PatchAsync<T>(T dto, string route, CancellationToken token = default)
        {
            await _authenticationClient.AuthenticateAsync(HttpClient, token);

            var uri = new Uri(_uri + route);

            var json = JsonConvert.SerializeObject(dto);
            var payload = new StringContent(json, new UTF8Encoding(), "application/json");

            var response = await HttpClient.PatchAsync(uri, payload, token);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var responseDto = JsonConvert.DeserializeObject<TModel>(responseString);
                if (responseDto == null)
                {
                    throw new Exception($"Null response returned from API for {typeof(TModel).Name}");
                }

                return responseDto;
            }

            throw new Exception($"Error response returned from API for {typeof(TModel).Name}: {response.StatusCode} ({response.ReasonPhrase})");
        }

         
         
    }
}