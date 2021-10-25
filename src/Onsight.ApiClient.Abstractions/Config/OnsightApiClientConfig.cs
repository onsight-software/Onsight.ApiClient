using Blauhaus.Analytics.Abstractions.Config;

namespace Onsight.ApiClient.Abstractions.Config
{
    public class OnsightApiClientConfig : BaseApplicationInsightsConfig, IOnsightApiClientConfig
    {

        public OnsightApiClientConfig(string apiKey, string apiSecret, string? serviceUrl = null) : base("", "")
        {
            ServiceUrl = serviceUrl ?? "http://publicapiv2.onsightapp.com";
            UserAuthEndpoint = "https://apiv14.onsightapp.com/api/Auth/VerifyByPost";
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            DeviceId = "ApiDevice";
        }

        public string ServiceUrl { get; protected set; }
        public string ApiKey { get; protected set; }
        public string ApiSecret { get; protected set; }
        public string UserAuthEndpoint { get; protected set; }
        public string DeviceId { get; }
    }
}