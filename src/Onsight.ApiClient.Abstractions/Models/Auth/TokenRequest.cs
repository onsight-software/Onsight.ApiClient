namespace Onsight.ApiClient.Abstractions.Models.Auth
{
    public class TokenRequest
    {
        public TokenRequest(string apiKey, string apiSecret)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public string ApiKey { get; }
        public string ApiSecret { get; }
    }
}