using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Extensions;
using Onsight.ApiClient.Tests.Tests.Base;
using static Onsight.ApiClient.Tests.Config.AppTest3Ids;

namespace Onsight.ApiClient.Tests.Tests.ProductsClientTests
{
    public class UpdatePriceAsyncTests : BaseOnsightApiClientTest<ProductsClient>
    {
        [Test]
        public async Task SHOULD_get_product()
        {
            //Arrange
            var originalProduct = await Sut.GetAsync(ProductIds.Arrows.Carets.DownCaret);
            var newPrice = Random.Next();

            //Act 
            var result = await Sut.UpdatePriceAsync(originalProduct.Id, newPrice);

            //Assert
            Assert.That(result.Price, Is.EqualTo(newPrice));
            Assert.That(result.CostPrice, Is.EqualTo(originalProduct.CostPrice));

            result.VerifyProductLinks(ProductIds.Arrows.Carets.DownCaret, CategoryIds.Arrows_Carets);
            result.VerifyModifiedDto(originalProduct);
            result.VerifyMetadataUnchanged(originalProduct);
            result.VerifyCategoryUnchanged(originalProduct);
            result.VerifyTaxUnchanged(originalProduct);
            result.VerifyImageUnchanged(originalProduct);
            result.VerifyStockCountUnchanged(originalProduct);
        }
    }
}