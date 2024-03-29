﻿using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Dtos.Common;
using Onsight.ApiClient.Abstractions.Models.Products;

namespace Onsight.ApiClient.Abstractions.Dtos.Products
{
    public record ProductDto(
            IReadOnlyList<LinkDto> Links,
            long Id,
            DateTime CreatedAt,
            DateTime ModifiedAt,
            string Status,
            string ExternalKey,
            string Name,
            string Description,
            string Blurb,
            string ProductCode,
            string Sku,
            string Barcode,
            bool Featured,
            CategoryId Category,
            string CategoryName,
            bool IsTaxable,
            decimal Price,
            decimal CostPrice,
            decimal StockCount,
            string PrimaryImage,
            string ImageLocation,
            bool IsMasterProduct,
            ParentProductId ParentProduct, 
            string TaxCodeId)
                : OnsightDto(Links, Id, CreatedAt, ModifiedAt, Status, ExternalKey);

}