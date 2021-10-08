using System.Collections.Generic;
using Blauhaus.Analytics.Abstractions.Config;
using Blauhaus.Analytics.Abstractions.Service;
using Blauhaus.Common.ValueObjects.BuildConfigs;
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