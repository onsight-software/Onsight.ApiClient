using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Dtos.Customers;
using Onsight.ApiClient.Abstractions.Dtos.Products;

namespace Onsight.ApiClient.Tests.Extensions
{
    public static class CustomerDtoExtensions
    {
        public static void VerifyCustomerLinks(this CustomerDto dto, long id)
        {
            Assert.That(dto.Links[0].Href.EndsWith($".onsightapp.com/customers/{id}"));
            Assert.That(dto.Links[0].Rel, Is.EqualTo("self"));

            Assert.That(dto.Links[1].Href.EndsWith($".onsightapp.com/customers/{id}/contacts"));
            Assert.That(dto.Links[1].Rel, Is.EqualTo("contacts"));

            Assert.That(dto.Links[2].Href.EndsWith($".onsightapp.com/customers/{id}/addresses"));
            Assert.That(dto.Links[2].Rel, Is.EqualTo("addresses"));

            Assert.That(dto.Links[3].Href.EndsWith($".onsightapp.com/customers/{id}/groups"));
            Assert.That(dto.Links[3].Rel, Is.EqualTo("groups"));

            Assert.That(dto.Links[4].Href.EndsWith($".onsightapp.com/customers/{id}/users"));
            Assert.That(dto.Links[4].Rel, Is.EqualTo("assignedTo"));

            Assert.That(dto.Links[5].Href.EndsWith($".onsightapp.com/customers/{id}/customfields"));
            Assert.That(dto.Links[5].Rel, Is.EqualTo("customFields")); 
        }
    }
}