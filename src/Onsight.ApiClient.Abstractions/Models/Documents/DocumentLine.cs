using System;
using Onsight.ApiClient.Abstractions.Dtos.Products;
using Onsight.ApiClient.Abstractions.Models.Base;
using Onsight.ApiClient.Abstractions.Models.Products;

namespace Onsight.ApiClient.Abstractions.Models.Documents
{
    public class DocumentLine : BaseOnsightModel
    {
        public DocumentLine(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey, 
            string description, 
            decimal discountPercentage, decimal discountUnitCost, decimal invoicedQuantity, decimal lineItemUnitCost, decimal lineItemUnitCostIncl, decimal lineTotal,
            string notes, int position, decimal quantity, ProductDto productDto, decimal totalTax, decimal unitCost) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Description = description;
            DiscountPercentage = discountPercentage;
            DiscountUnitCost = discountUnitCost;
            InvoicedQuantity = invoicedQuantity;
            LineItemUnitCost = lineItemUnitCost;
            LineItemUnitCostIncl = lineItemUnitCostIncl;
            LineTotal = lineTotal;
            Notes = notes;
            Position = position;
            Quantity = quantity;
            ProductDto = productDto;
            TotalTax = totalTax;
            UnitCost = unitCost;
        }

        public string Description { get; }
        public decimal DiscountPercentage { get; }
        public decimal DiscountUnitCost { get; }
        public decimal InvoicedQuantity { get; }
        public decimal LineItemUnitCost { get; }
        public decimal LineItemUnitCostIncl { get; }
        public decimal LineTotal { get; }
        public string Notes { get; }
        public int Position { get; }
        public decimal Quantity { get; }
        public ProductDto ProductDto { get; }
        public decimal TotalTax { get; }
        public decimal UnitCost { get; }
    }
}