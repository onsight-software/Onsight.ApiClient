using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Account
{
    public record User(
            IReadOnlyList<LinkDto> Links,
            long Id,
            DateTime ModifiedAt,
            DateTime CreatedAt,
            string Status,
            string ExternalKey,
            string FirstName,
            string LastName,
            string Email,
            string Telephone,
            string Mobile,
            string AccessType)
                : OnsightDto(Id, ModifiedAt, CreatedAt, Status, ExternalKey);

}