using System;
using Onsight.ApiClient.Abstractions.Models.Base;

namespace Onsight.ApiClient.Abstractions.Models.Account
{
    public class User : BaseOnsightModel
    {
        public User(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey, 
            string firstName, string lastName, 
            string email, string telephone, string mobile, string accessType) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Telephone = telephone;
            Mobile = mobile;
            AccessType = accessType;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Telephone { get; }
        public string Mobile { get; }
        public string AccessType { get; }
    }
}