using Onsight.ApiClient.Abstractions.Config;
using System.Net.Http.Headers;
using System.Net.Http;
using System;

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
}