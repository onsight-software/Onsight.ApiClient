namespace Onsight.ApiClient.Abstractions.Config
{
    public class OnsightApiClientConfig : IOnsightApiClientConfig
    {

        public OnsightApiClientConfig(string apiKey, string apiSecret, string? serviceUrl = null)
        {
            ServiceUrl = serviceUrl ?? "http://publicapiv5.onsightapp.com";
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public string ServiceUrl { get; protected set; }
        public string ApiKey { get; protected set; }
        public string ApiSecret { get; protected set; }
    }
}