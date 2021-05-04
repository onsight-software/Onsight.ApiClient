using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Values;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Config;
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
            result.VerifyProductLinks(ProductIds.Arrows.Carets.DownCaret, CategoryIds.Arrows_Carets);
            result.VerifyModifiedDto(originalProduct);
            result.VerifyMetadataUnchanged(originalProduct);
            result.VerifyCategoryUnchanged(originalProduct);
            result.VerifyPriceUnchanged(originalProduct);
            result.VerifyTaxUnchanged(originalProduct);
            result.VerifyImageUnchanged(originalProduct);
            result.VerifyStockCountUnchanged(originalProduct);
        }
    }
}