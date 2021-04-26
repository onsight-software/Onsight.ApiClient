using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Models.Account;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Products
{
    public class Product : BaseOnsightModel
    {
        public Product(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey,
            ProductCategory category, string categoryName, 
            string description, string name, string sku, string productCode, string blurb, 
            decimal? price, 
            string primaryImage, string imageLocation, 
            long position, string barcode, bool featured, bool isMasterProduct, 
            Product? parentProduct, 
            decimal stockCount, 
            IList<TaxType> applicableTaxes, 
            string localImagePath, bool valid, string taxCodeId) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Category = category;
            CategoryName = categoryName;
            Description = description;
            Name = name;
            Sku = sku;
            ProductCode = productCode;
            Blurb = blurb;
            Price = price;
            PrimaryImage = primaryImage;
            ImageLocation = imageLocation;
            Position = position;
            Barcode = barcode;
            Featured = featured;
            IsMasterProduct = isMasterProduct;
            StockCount = stockCount;
            ApplicableTaxes = applicableTaxes;
            LocalImagePath = localImagePath;
            Valid = valid;
            TaxCodeId = taxCodeId;

            ParentProduct = parentProduct is {Id: 0} ? null : parentProduct;

        }

        public ProductCategory Category { get; }
        public string CategoryName { get; }
        public string Description { get; }
        public string Name { get; }
        public string Sku { get; }
        public string ProductCode { get; }
        public string Blurb { get; }
        public decimal? Price { get; }
        public string PrimaryImage { get; }
        public string ImageLocation { get; }
        public long Position { get; }
        public string Barcode { get; }
        public bool Featured { get; }
        public bool IsMasterProduct { get; }
        public Product? ParentProduct { get; }
        public decimal StockCount { get; }
        public IList<TaxType> ApplicableTaxes { get; }
        public string LocalImagePath { get; }
        public bool Valid { get; }
        public string TaxCodeId { get; }
    }
}