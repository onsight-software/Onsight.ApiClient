using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Clients.Products;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Ioc;
using Onsight.ApiClient.Tests.Config;
using Onsight.ApiClient.Tests.Tests.Base;

namespace Onsight.ApiClient.Tests.Tests.AuthenticationClientTests
{
    public class AuthenticateUserAsyncTests : BaseOnsightApiClientTest<AuthenticationClient>
    {
        public override void Setup()
        {
            base.Setup();

            Services
                .AddOnsightApiClient<AppTest3UserClientConfig>();
        }

        [Test]
        public async Task SHOULD_set_CurrentToken()
        {
            //Arrange
            var client = new HttpClient();

            //Act
            await Sut.AuthenticateUserAsync(client, "apptest3@onsightapp-testing.com", "password");

            //Assert
            var sessionKey = client.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "XSessionId");
            Assert.That(sessionKey, Is.Not.Null);
            Assert.That(sessionKey.Value, Is.Not.Null);
            Assert.That(sessionKey.Value, Is.Not.Empty);
            var deviceId = client.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "XClientId");
            Assert.That(deviceId, Is.Not.Null);
            Assert.That(deviceId.Value, Is.Not.Null);
            Assert.That(deviceId.Value, Is.Not.Empty);
        }

        
        [Test]
        public async Task SHOULD_allow_access()
        {
            //Arrange
            var client = new HttpClient();
            await Sut.AuthenticateUserAsync(client, "apptest3@onsightapp-testing.com", "password");

            //Act
            var productsClient = Services.BuildServiceProvider().GetRequiredService<IProductsClient>();
            var product = await productsClient.GetAsync(AppTest3Ids.ProductIds.Arrows.Carets.DownCaret);

            //Assert
            Assert.That(product, Is.Not.Null);
            Assert.That(product.Description, Is.EqualTo("This one points down"));
        }
         
    }
}