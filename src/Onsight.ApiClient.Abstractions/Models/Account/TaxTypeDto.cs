using System;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Account
{
    public record TaxTypeDto(
            long Id,
            DateTime CreatedAt,
            DateTime ModifiedAt,
            string Status,
            string ExternalKey,
            string Name,
            string ChargeType,
            decimal Value,
            decimal Threshold)
               : OnsightDto(Id, CreatedAt, ModifiedAt, Status, ExternalKey);
}
