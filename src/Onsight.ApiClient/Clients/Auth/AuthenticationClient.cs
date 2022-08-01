using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Onsight.ApiClient.Abstractions.Config;
using Onsight.ApiClient.Abstractions.Models.Auth;
using Onsight.ApiClient.Abstractions.Models.Auth.SubscriberAuth;
using Onsight.ApiClient.Abstractions.Models.Auth.UserAuth;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Clients.Auth
{
    public class AuthenticationClient : BaseOnsightApiClient, IAuthenticationClient
    {

        private static SubscriberToken? _subscriberToken;
        private static UserToken? _userToken;   

        public AuthenticationClient(
            HttpClient httpClient, 
            IOnsightApiClientConfig clientConfig) 
                : base(httpClient, clientConfig)
        { 
        }

        //todo user authentication

        public async Task AuthenticateAsync(HttpClient httpClient, CancellationToken token = default)
        {
            if (_subscriberToken == null && !string.IsNullOrEmpty(ClientConfig.ApiKey))
            {
                var tokenRequest = new SubscriberTokenRequest(ClientConfig.ApiKey, ClientConfig.ApiSecret);

                var json = JsonConvert.SerializeObject(tokenRequest);
                var payload = new StringContent(json, new UTF8Encoding(), "application/json");

                var response = await HttpClient.PostAsync("apitokens", payload, token);
                if (response.IsSuccessStatusCode)
                {
                    var tokenRequestResult = await response.Content.ReadFromJsonAsync<SubscriberToken>(cancellationToken: token);
                    if (tokenRequestResult != null)
                    {
                        _subscriberToken = tokenRequestResult;
                    }
                    else
                    {
                        throw new Exception("Invalid access token received");
                    }
                }
                else
                {
                    var content = await response.Content.ReadFromJsonAsync<ApiFailResult>(cancellationToken: token);
                    throw new Exception( $"Error getting access token for Onsight API: {response.StatusCode}, {content?.Message}");
                }
            }
            
            httpClient.DefaultRequestHeaders.Clear();

            if (_subscriberToken != null)
            {
                httpClient.DefaultRequestHeaders.Add("X-Onsight-AuthToken", _subscriberToken.Token);
            }

            if (_userToken != null)
            {
                httpClient.DefaultRequestHeaders.Add("XClientId", new List<string> { ClientConfig.DeviceId }  );
                httpClient.DefaultRequestHeaders.Add("XSessionId", _userToken.SessionKey);
            }
             
        }

        public async Task AuthenticateUserAsync(HttpClient httpClient, string emailAddress, string password, CancellationToken token = default)
        {
            
            httpClient.DefaultRequestHeaders.Clear();

            if (_userToken == null)
            {
                var tokenRequest = new UserTokenRequest(emailAddress, password);

                var json = JsonConvert.SerializeObject(tokenRequest);
                var payload = new StringContent(json, new UTF8Encoding(), "application/json");
                
                var response = await HttpClient.PostAsync(ClientConfig.UserAuthEndpoint, payload, token);

                if (response.IsSuccessStatusCode)
                {
                    var tokenRequestResult = await response.Content.ReadFromJsonAsync<UserToken>(cancellationToken: token);
                    if (tokenRequestResult != null)
                    {
                        _userToken = tokenRequestResult;
                    }
                    else
                    {
                        throw new Exception("Invalid access token received");
                    }
                }
                else
                {
                    var content = await response.Content.ReadFromJsonAsync<ApiFailResult>(cancellationToken: token);
                    throw new Exception( $"Error getting access token for Onsight API: {response.StatusCode}, {content?.Message}");
                }

            }
            httpClient.DefaultRequestHeaders.Add("XClientId", new List<string> { ClientConfig.DeviceId }  );
            httpClient.DefaultRequestHeaders.Add("XSessionId", _userToken.SessionKey);
        }
    }
}