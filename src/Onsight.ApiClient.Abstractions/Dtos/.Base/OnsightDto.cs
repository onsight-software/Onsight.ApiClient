using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Onsight.ApiClient.Abstractions.Dtos.Base
{ 
    public record OnsightDto(
        IReadOnlyList<LinkDto> Links,
        long Id, 
        DateTime CreatedAt, 
        DateTime ModifiedAt, 
        string Status, 
        string ExternalKey);
}