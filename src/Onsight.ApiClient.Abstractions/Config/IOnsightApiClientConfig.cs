namespace Onsight.ApiClient.Abstractions.Config
{
    public interface IOnsightApiClientConfig
    {
        public string ServiceUrl { get; }
        public string ApiKey { get; }
        public string ApiSecret { get; }
    }
}