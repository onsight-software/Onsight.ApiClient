using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Customers
{
    public class Customer : BaseOnsightModel
    { 
        
        public Customer(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey,  
            string name, string uniqueId, 
            string billingAddress1, string billingAddress2, string billingCity, string billingCountry, string billingPostalCode, string billingState, 
            string shippingAddress1, string shippingAddress2, string shippingCity, string shippingCountry, string shippingPostalCode, string shippingState, 
            string comment, string email, string mobile, string telephone, string website, string taxNumber, 
            bool applyDiscountPercentage, decimal discountPercentage, bool allowUserOverrideDiscountPercentage, decimal maxAllowableDiscountPercentage, 
            List<Contact> contactPersons, 
            List<CustomerGroup> customerGroups) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Name = name;
            BillingAddress1 = billingAddress1;
            BillingAddress2 = billingAddress2;
            BillingCity = billingCity;
            BillingCountry = billingCountry;
            BillingPostalCode = billingPostalCode;
            BillingState = billingState;
            Comment = comment;
            Email = email;
            Mobile = mobile;
            ShippingAddress1 = shippingAddress1;
            ShippingAddress2 = shippingAddress2;
            ShippingCity = shippingCity;
            ShippingCountry = shippingCountry;
            ShippingPostalCode = shippingPostalCode;
            ShippingState = shippingState;
            Telephone = telephone;
            Website = website;
            TaxNumber = taxNumber;
            ApplyDiscountPercentage = applyDiscountPercentage;
            DiscountPercentage = discountPercentage;
            AllowUserOverrideDiscountPercentage = allowUserOverrideDiscountPercentage;
            MaxAllowableDiscountPercentage = maxAllowableDiscountPercentage;
            UniqueId = uniqueId;
            ContactPersons = contactPersons;
            CustomerGroups = customerGroups;
        }

        public string Name { get; }
        public string UniqueId { get; }
        
        public string Comment { get; }
        public string Email { get; }
        public string Mobile { get; }
        public string Telephone { get; }
        public string Website { get; }
        public string TaxNumber { get; }

        public string BillingAddress1 { get; }
        public string BillingAddress2 { get; }
        public string BillingCity { get; }
        public string BillingCountry { get; }
        public string BillingPostalCode { get; }
        public string BillingState { get; }
        
        public string ShippingAddress1 { get; }
        public string ShippingAddress2 { get; }
        public string ShippingCity { get; }
        public string ShippingCountry { get; }
        public string ShippingPostalCode { get; }
        public string ShippingState { get; }

        public bool ApplyDiscountPercentage { get; }
        public decimal DiscountPercentage { get; }
        public bool AllowUserOverrideDiscountPercentage { get; }
        public decimal MaxAllowableDiscountPercentage { get; }
        public List<Contact> ContactPersons { get; }
        public List<CustomerGroup> CustomerGroups { get; }

    }
}