using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Dtos.Base;
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
        float Latitude,
        float Longitude) 
            : OnsightDto(Links, Id, CreatedAt, ModifiedAt, Status, ExternalKey);

}