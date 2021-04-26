using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Models.Products;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Tests.Base;

namespace Onsight.ApiClient.Tests.Tests.ProductsClientTests
{
    public class GetOneAsyncTests : BaseOnsightApiClientTest<ProductsClient>
    {
        [Test]
        public async Task SHOULD_get_product()
        {
            //Act
            var result = await Sut.GetOneAsync(2504578);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(2504578));
        }
    }
}