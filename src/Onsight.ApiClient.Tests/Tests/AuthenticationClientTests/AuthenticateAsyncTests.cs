using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Clients.Auth;
using Onsight.ApiClient.Tests.Tests.Base;

namespace Onsight.ApiClient.Tests.Tests.AuthenticationClientTests
{
    public class AuthenticateAsyncTests : BaseOnsightApiClientTest<AuthenticationClient>
    {
        [Test]
        public async Task SHOULD_set_CurrentToken()
        {
            //Arrange
            var client = new HttpClient();

            //Act
            await Sut.AuthenticateAsync(client);

            //Assert
            var authToken = client.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "X-Onsight-AuthToken");
            Assert.That(authToken, Is.Not.Null);
            Assert.That(authToken.Value, Is.Not.Null);
            Assert.That(authToken.Value, Is.Not.Empty);
        }
    }
}