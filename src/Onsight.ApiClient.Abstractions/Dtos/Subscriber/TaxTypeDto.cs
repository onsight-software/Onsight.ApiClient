using System;
using Onsight.ApiClient.Abstractions.Dtos.Base;

namespace Onsight.ApiClient.Abstractions.Dtos.Subscriber
{
    public record TaxTypeDto(long Id, DateTime CreatedAt, DateTime ModifiedAt, string Status, string ExternalKey,
            string Name,
            string ChargeType,
            decimal Value,
            decimal Threshold)
               : OnsightDto(Array.Empty<LinkDto>(), Id, CreatedAt, ModifiedAt, Status, ExternalKey);
}
