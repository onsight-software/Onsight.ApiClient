using System;
using System.Diagnostics;
using Blauhaus.Analytics.Console.Ioc;
using Blauhaus.Common.ValueObjects.BuildConfigs;
using Blauhaus.TestHelpers.BaseTests;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

            Services
                .AddSingleton<IBuildConfig>(BuildConfig.Test)
                .RegisterConsoleLoggerService(new ConsoleTraceListener())
                .AddOnsightApiClient<AppTest3Config>();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<BaseOnsightApiClientTest<TApiClient>>()
                .Build();

            Services.AddSingleton<IConfiguration>(configuration);
        }
         
    }
}