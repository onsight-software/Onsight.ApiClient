using Onsight.ApiClient.Abstractions.Config;

namespace Onsight.ApiClient.Tests.Config
{
    public class AdrianConfig : IOnsightApiClientConfig
    {
        public AdrianConfig()
        {
            ApiKey = "SHSvDDtOaQVh/2/gLljZ/fcJfBStgRMv";
            ApiSecret = "OeH6kotD1+SrHwoGzFssi1nfs/EfzhA/";
        }

        public string ApiKey { get; }
        public string ApiSecret { get; }
    }
}