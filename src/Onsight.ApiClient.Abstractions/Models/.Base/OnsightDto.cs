using System;
using System.Collections.Generic;

namespace Onsight.ApiClient.Abstractions.Models.Base
{
    public record OnsightDto(
        long Id, 
        DateTime CreatedAt, 
        DateTime ModifiedAt, 
        string Status, 
        string ExternalKey);
}