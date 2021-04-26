using System;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Account
{
    public class TaxType : BaseOnsightModel
    {
        public TaxType(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey, 
            string name, string chargeType, decimal value, decimal threshold) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Name = name;
            ChargeType = chargeType;
            Value = value;
            Threshold = threshold;
        }

        public string Name { get; }
        public string ChargeType { get; }
        public decimal Value { get; }
        public decimal Threshold { get; }
    }
}