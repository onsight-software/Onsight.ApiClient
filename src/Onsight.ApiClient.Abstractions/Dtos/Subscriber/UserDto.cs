using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Dtos.Base;

namespace Onsight.ApiClient.Abstractions.Dtos.Subscriber
{
    public record UserDto(
            IReadOnlyList<LinkDto> Links, long Id, DateTime CreatedAt, DateTime ModifiedAt, string Status, string ExternalKey,
            string FirstName,
            string LastName,
            string Email,
            string Telephone,
            string Mobile,
            string AccessType)
                : OnsightDto(Links, Id, CreatedAt, ModifiedAt, Status, ExternalKey);

}