using Microsoft.Extensions.Configuration;
using Onsight.ApiClient.Abstractions.Config;

namespace Onsight.ApiClient.Tests.Config
{
    public class AppTest3Config : OnsightApiClientConfig
    {
        public AppTest3Config(IConfiguration config)
            : base(config.GetSection("APPTEST3_APIKEY").Value, config.GetSection("APPTEST3_APISECRET").Value)
        {
        }

    }
     
}