using System.Collections.Generic;
using Blauhaus.Analytics.Abstractions.Config;
using Blauhaus.Analytics.Abstractions.Service;
using Blauhaus.Common.ValueObjects.BuildConfigs;
using Microsoft.Extensions.Configuration;
using Onsight.ApiClient.Abstractions.Config;

namespace Onsight.ApiClient.Tests.Config
{
    public class AppTest3UserClientConfig : OnsightApiClientConfig
    {
        public AppTest3UserClientConfig() : base(string.Empty, string.Empty)

        {
        }


    }
     
}