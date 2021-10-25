namespace Onsight.ApiClient.Abstractions.Config
{
    public interface IOnsightApiClientConfig
    {
        public string ServiceUrl { get; }
        public string ApiKey { get; }
        public string ApiSecret { get; }
        public string UserAuthEndpoint { get; }
        public string DeviceId { get; }
    }
}