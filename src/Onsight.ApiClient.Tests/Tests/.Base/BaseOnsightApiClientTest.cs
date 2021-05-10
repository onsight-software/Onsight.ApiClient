using System;
using Blauhaus.TestHelpers.BaseTests;
using NUnit.Framework;
using Onsight.ApiClient.Clients.Base;
using Onsight.ApiClient.Ioc;
using Onsight.ApiClient.Tests.Config;

namespace Onsight.ApiClient.Tests.Tests.Base
{

    public abstract class BaseOnsightApiClientTest<TApiClient> : BaseServiceTest<TApiClient> 
        where TApiClient : BaseOnsightApiClient
    {
        protected Random Random = new();

        [SetUp]
        public virtual void Setup()
        {
            base.Cleanup();

            Services.AddOnsightApiClient<AppTest3Config>();
        }
    }
}