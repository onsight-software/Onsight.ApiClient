using System;

namespace Onsight.ApiClient.Abstractions.Models.Base
{
    public abstract class BaseOnsightModel : IOnsightModel
    {
        protected BaseOnsightModel(long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey)
        {
            Id = id;
            ModifiedAt = modifiedAt;
            CreatedAt = createdAt;
            Status = status;
            ExternalKey = externalKey;
        }

        public long Id { get; }
        public DateTime ModifiedAt { get; }
        public DateTime CreatedAt { get; }
        public string Status { get; } 
        public string ExternalKey { get; }
    }
}