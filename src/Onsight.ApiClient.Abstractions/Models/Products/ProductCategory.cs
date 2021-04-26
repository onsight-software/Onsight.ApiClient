using System;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Products
{
    public class ProductCategory : BaseOnsightModel
    {
        public ProductCategory(long id, DateTime modifiedAt, DateTime createdAt, string status, string name, string primaryImage, string blurb, string imageLocation, ProductCategory parentCategory, string externalKey)
            : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Name = name;
            PrimaryImage = primaryImage;
            Blurb = blurb;
            ImageLocation = imageLocation;
            ParentCategory = parentCategory;
        }

        public string Name { get; }
        public string PrimaryImage { get; }
        public string Blurb { get; }
        public string ImageLocation { get; }
        public ProductCategory ParentCategory { get; }
    }
}