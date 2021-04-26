using System;

namespace Onsight.ApiClient.Abstractions.Models.Base
{
    public interface IOnsightModel
    {
        public long Id { get; }
        public DateTime ModifiedAt { get; }
        public DateTime CreatedAt { get; }
        public string Status { get; } 
    }
}