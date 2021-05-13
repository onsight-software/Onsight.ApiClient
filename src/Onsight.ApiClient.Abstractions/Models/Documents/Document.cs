using System;
using System.Collections.Generic;
using Onsight.ApiClient.Abstractions.Dtos.Customers;
using Onsight.ApiClient.Abstractions.Dtos.Subscriber;
using Onsight.ApiClient.Abstractions.Models.Base;
using Onsight.ApiClient.Abstractions.Models.Customers;

namespace Onsight.ApiClient.Abstractions.Models.Documents
{
    public class Document: BaseOnsightModel
    {
        public Document(
            long id, DateTime modifiedAt, DateTime createdAt, string status, string externalKey, 
            long customerId, string documentStatus, string paymentMethod, string referenceNo, int year, int month, int day, 
            CustomerDto customerDto, Contact? contact, string accountRefNo, string notes, DateTime requiredAt, 
            bool emailed, decimal discountPercentage, decimal discountValue, string signatureLocation, string signatureFile, 
            string uniqueId, UserDto createdBy, IReadOnlyList<DocumentLine> lines) 
                : base(id, modifiedAt, createdAt, status, externalKey)
        {
            CustomerId = customerId;
            DocumentStatus = documentStatus;
            PaymentMethod = paymentMethod;
            ReferenceNo = referenceNo;
            Year = year;
            Month = month;
            Day = day;
            CustomerDto = customerDto;
            Contact = contact;
            AccountRefNo = accountRefNo;
            Notes = notes;
            RequiredAt = requiredAt;
            Emailed = emailed;
            DiscountPercentage = discountPercentage;
            DiscountValue = discountValue;
            SignatureLocation = signatureLocation;
            SignatureFile = signatureFile;
            UniqueId = uniqueId;
            CreatedBy = createdBy;
            Lines = lines;
        }

        public long CustomerId { get;}
        public string DocumentStatus { get;}
        public string PaymentMethod { get;}
        public string ReferenceNo { get;}
        public int Year { get;}
        public int Month { get;}
        public int Day { get;}
        public CustomerDto CustomerDto { get;}
        public Contact? Contact { get;}
        public string AccountRefNo { get;}
        public string Notes { get;}
        public DateTime RequiredAt { get;}
        public bool Emailed { get;}
        public decimal DiscountPercentage { get;}
        public decimal DiscountValue { get;}
        public string SignatureLocation { get;}
        public string SignatureFile { get;}
        public string UniqueId { get;}
        public UserDto CreatedBy { get;}
        public IReadOnlyList<DocumentLine> Lines { get;}
    }
}