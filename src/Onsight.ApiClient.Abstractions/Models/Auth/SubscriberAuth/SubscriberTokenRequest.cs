namespace Onsight.ApiClient.Abstractions.Models.Auth.SubscriberAuth
{
    public class SubscriberTokenRequest
    {
        public SubscriberTokenRequest(string apiKey, string apiSecret)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public string ApiKey { get; }
        public string ApiSecret { get; }
    }
}