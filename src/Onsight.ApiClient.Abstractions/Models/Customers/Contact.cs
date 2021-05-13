using System;
using Onsight.ApiClient.Abstractions.Dtos.Customers;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Customers
{
    public class Contact : BaseOnsightModel
    {
        public Contact(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey, 
            string surname, string name, string email, string telephone, string uniqueId, CustomerDto? customer, bool isPrimary) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            Surname = surname;
            Name = name;
            Email = email;
            Telephone = telephone;
            UniqueId = uniqueId;
            Customer = customer;
            IsPrimary = isPrimary;
        }


        public string Surname { get; } 
        public string Name { get; } 
        public string Email { get; } 
        public string Telephone { get; } 
        public string UniqueId { get; } 
        public CustomerDto? Customer { get; } 
        public bool IsPrimary { get; } 

    }
}