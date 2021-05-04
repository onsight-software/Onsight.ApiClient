using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Models.Products;

namespace Onsight.ApiClient.Tests.Extensions
{
    public static class ProductDtoExtensions
    {
        public static void VerifyProductLinks(this ProductDto productDto, long id, long categoryId)
        {
            Assert.That(productDto.Links[0].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}"));
            Assert.That(productDto.Links[0].Rel, Is.EqualTo("self"));
            Assert.That(productDto.Links[1].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/productcategories/{categoryId}"));
            Assert.That(productDto.Links[1].Rel, Is.EqualTo("category"));
            Assert.That(productDto.Links[2].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/associated"));
            Assert.That(productDto.Links[2].Rel, Is.EqualTo("associated"));
            Assert.That(productDto.Links[3].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/alternative"));
            Assert.That(productDto.Links[3].Rel, Is.EqualTo("alternative"));
            Assert.That(productDto.Links[4].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/taxtypes"));
            Assert.That(productDto.Links[4].Rel, Is.EqualTo("taxTypes"));
            Assert.That(productDto.Links[5].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/icons"));
            Assert.That(productDto.Links[5].Rel, Is.EqualTo("icons"));
            Assert.That(productDto.Links[6].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/customfields"));
            Assert.That(productDto.Links[6].Rel, Is.EqualTo("customFields"));
            Assert.That(productDto.Links[7].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/specifications"));
            Assert.That(productDto.Links[7].Rel, Is.EqualTo("specifications"));
            Assert.That(productDto.Links[8].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/secondarycategories"));
            Assert.That(productDto.Links[8].Rel, Is.EqualTo("secondaryCategories"));
            Assert.That(productDto.Links[9].Href, Is.EqualTo($"http://publicapiv5.onsightapp.com/products/{id}/customerGroupPricing"));
            Assert.That(productDto.Links[9].Rel, Is.EqualTo("customerGroupPricing"));
        }


        public static void VerifyMetadataUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.Name, Is.EqualTo(originalDto.Name));
            Assert.That(dto.Description, Is.EqualTo(originalDto.Description));
            Assert.That(dto.Blurb, Is.EqualTo(originalDto.Blurb));         
            Assert.That(dto.ProductCode, Is.EqualTo(originalDto.ProductCode));
            Assert.That(dto.Barcode, Is.EqualTo(originalDto.Barcode));
            Assert.That(dto.Sku, Is.EqualTo(originalDto.Sku));
            Assert.That(dto.Featured, Is.EqualTo(originalDto.Featured));
            Assert.That(dto.Featured, Is.EqualTo(originalDto.Featured));
            Assert.That(dto.IsMasterProduct, Is.EqualTo(originalDto.IsMasterProduct));
            Assert.That(dto.ParentProduct.Id, Is.EqualTo(originalDto.ParentProduct.Id));
        }
        
        public static void VerifyCategoryUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.Category, Is.EqualTo(originalDto.Category));
            Assert.That(dto.CategoryName, Is.EqualTo(originalDto.CategoryName));
        }
        
        public static void VerifyPriceUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.CostPrice, Is.EqualTo(originalDto.CostPrice));
            Assert.That(dto.Price, Is.EqualTo(originalDto.Price));
        }

        public static void VerifyTaxUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.TaxCodeId, Is.EqualTo(originalDto.TaxCodeId));
            Assert.That(dto.IsTaxable, Is.EqualTo(originalDto.IsTaxable));
        }
        
        public static void VerifyImageUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.ImageLocation, Is.EqualTo(originalDto.ImageLocation));
            Assert.That(dto.PrimaryImage, Is.EqualTo(originalDto.PrimaryImage));
        }
        
        public static void VerifyStockCountUnchanged(this ProductDto dto, ProductDto originalDto)
        {
            Assert.That(dto.StockCount, Is.EqualTo(originalDto.StockCount));
        }
    }
}