using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Models.Auth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients.Auth
{
    public class AuthenticationClient : BaseOnsightApiClient, IAuthenticationClient
    {

        private static TokenResponse? _tokenResponse;

        public AuthenticationClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig config) 
                : base(httpClient, config)
        { 
        }

        //todo user authentication

        public async Task AuthenticateAsync(HttpClient httpClient, CancellationToken token = default)
        {
            if (_tokenResponse == null)
            {
                var tokenRequest = new TokenRequest(Config.ApiKey, Config.ApiSecret);

                var json = JsonConvert.SerializeObject(tokenRequest);
                var payload = new StringContent(json, new UTF8Encoding(), "application/json");

                var response = await HttpClient.PostAsync("apitokens", payload, token);
                if (response.IsSuccessStatusCode)
                {
                    var tokenRequestResult = await response.Content.ReadFromJsonAsync<TokenResponse>();
                    if (tokenRequestResult != null)
                    {
                        _tokenResponse = tokenRequestResult;
                    }
                    else
                    {
                        throw new Exception("Invalid access token received");
                    }
                }
                else
                {
                    var content = await response.Content.ReadFromJsonAsync<ApiFailResult>();
                    throw new Exception( $"Error getting access token for Onsight API: {response.StatusCode}, {content?.Message}");
                }
            }
            
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Onsight-AuthToken", _tokenResponse.Token);
             
        }
    }
}