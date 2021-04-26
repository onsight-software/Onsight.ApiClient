using System;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Customers
{
    public class CustomerGroup : BaseOnsightModel
    {
        public CustomerGroup(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey,
            string name) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Name = name;
        }

        public string Name { get; } 

    }
}