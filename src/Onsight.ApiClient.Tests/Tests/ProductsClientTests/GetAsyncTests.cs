using System;
using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Dtos.Products;
using Onsight.ApiClient.Abstractions.Values;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Extensions;
using Onsight.ApiClient.Tests.Tests.Base;
using static Onsight.ApiClient.Tests.Config.AppTest3Ids;

namespace Onsight.ApiClient.Tests.Tests.ProductsClientTests
{
    public class GetAsyncTests : BaseGetAsyncTests<ProductsClient, ProductDto>
    {
        [Test]
        public async Task SHOULD_get_product()
        { 
            //Act
            var result = await Sut.GetAsync(ProductIds.Scanners.BluetoothScanner);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(ProductIds.Scanners.BluetoothScanner));
            Assert.That(result.CreatedAt, Is.EqualTo(DateTime.Parse("2021-04-30 10:35:35.000")));
            Assert.That(result.ModifiedAt, Is.EqualTo(DateTime.Parse("2021-04-30 11:46:43.000")));
            Assert.That(result.Status, Is.EqualTo(EntityStatus.Active));
            Assert.That(result.ExternalKey, Is.EqualTo(string.Empty));
            
            Assert.That(result.Name, Is.EqualTo("Bluetooth Scanner"));
            Assert.That(result.Description, Is.EqualTo("Bluetooth Scanner"));
            Assert.That(result.Blurb, Is.EqualTo("Some more detail about the Bluetooth scanner"));         
            Assert.That(result.ProductCode, Is.EqualTo("BTS_Code"));
            Assert.That(result.Barcode, Is.EqualTo("BTS_BarCode"));
            Assert.That(result.Sku, Is.EqualTo("BTS_Sku"));
            Assert.That(result.Featured, Is.False);

            Assert.That(result.Category.Id, Is.EqualTo(281839));
            Assert.That(result.CategoryName, Is.EqualTo("Scanners"));
            Assert.That(result.IsMasterProduct, Is.False);
            Assert.That(result.ParentProduct.Id, Is.EqualTo(0));
            
            Assert.That(result.Price, Is.EqualTo(11.99m));
            Assert.That(result.CostPrice, Is.EqualTo(0m));
            Assert.That(result.StockCount, Is.EqualTo(0));
            Assert.That(result.IsTaxable, Is.True);
            Assert.That(result.TaxCodeId, Is.EqualTo(string.Empty));

            Assert.That(result.PrimaryImage, Is.EqualTo("78566c57cc174ae7872b38441174daec.png"));
            Assert.That(result.ImageLocation, Is.EqualTo("https://web.onsightapp.com/cloud/products/"));

            result.VerifyProductLinks(ProductIds.Scanners.BluetoothScanner, CategoryIds.Scanners);

        }
    }
}