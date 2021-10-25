using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Onsight.ApiClient.Abstractions.Dtos.Common;

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