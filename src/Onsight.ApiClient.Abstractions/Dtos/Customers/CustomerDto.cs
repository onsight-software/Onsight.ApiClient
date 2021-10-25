using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Dtos.Common;
using Onsight.ApiClient.Abstractions.Models.Customers;

namespace Onsight.ApiClient.Abstractions.Dtos.Customers
{
    public record CustomerDto(IReadOnlyList<LinkDto> Links, long Id, DateTime CreatedAt, DateTime ModifiedAt, string Status, string ExternalKey,
            string Name,
            string UniqueId,
            string Comment,
            string Email,
            string TaxNumber,
            bool IsTaxable,
            string BillingAddress1,
            string BillingAddress2,
            string BillingCity,
            string BillingCountry,
            string BillingPostalCode,
            string BillingState,
            string ShippingAddress1,
            string ShippingAddress2,
            string ShippingCity,
            string ShippingCountry,
            string ShippingPostalCode,
            string ShippingState,
            float? Latitude,
            float? Longitude)
        : OnsightDto(Links, Id, CreatedAt, ModifiedAt, Status, ExternalKey)
    {
        public static CustomerDto Create(string name) => new(
            Links: Array.Empty<LinkDto>(),
            Id: default, 
            CreatedAt: default, 
            ModifiedAt: default, 
            Status: string.Empty, 
            ExternalKey: string.Empty,
            Name: name, 
            UniqueId: string.Empty, 
            Comment: string.Empty, 
            Email: string.Empty, 
            TaxNumber: string.Empty,
            IsTaxable: default, 
            BillingAddress1: string.Empty, 
            BillingAddress2: string.Empty, 
            BillingCity: string.Empty, 
            BillingCountry: string.Empty, 
            BillingPostalCode: string.Empty, 
            BillingState: string.Empty, 
            ShippingAddress1: string.Empty, 
            ShippingAddress2: string.Empty, 
            ShippingCity: string.Empty, 
            ShippingCountry: string.Empty, 
            ShippingPostalCode: string.Empty, 
            ShippingState: string.Empty, 
            Latitude: null, 
            Longitude: null);
    }

}