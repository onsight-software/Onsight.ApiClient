using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Values;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Extensions;
using Onsight.ApiClient.Tests.Tests.Base;
using static Onsight.ApiClient.Tests.Config.AppTest3Ids;

namespace Onsight.ApiClient.Tests.Tests.CustomersClientTests
{
    public class GetAsyncTests : BaseOnsightApiClientTest<CustomersClient>
    {
        [Test]
        public async Task SHOULD_get_all_customer_details()
        {
            //Act
            var result = await Sut.GetAsync(CustomerIds.FullyDetailedCustomer);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(CustomerIds.FullyDetailedCustomer));
            Assert.That(result.CreatedAt, Is.EqualTo(DateTime.Parse("2021-04-30 10:52:42")));
            Assert.That(result.ModifiedAt, Is.EqualTo(DateTime.Parse("2021-05-13T14:55:25")));
            Assert.That(result.Status, Is.EqualTo(EntityStatus.Active));
            Assert.That(result.ExternalKey, Is.EqualTo(string.Empty));
            Assert.That(result.UniqueId, Is.EqualTo("905363e2-01b5-4e94-a751-192044941893"));
            
            Assert.That(result.Name, Is.EqualTo("Fully Detailed Customer"));
            Assert.That(result.Comment, Is.EqualTo("This is a note about the fully detailed customer"));
            Assert.That(result.Email, Is.EqualTo("billing@mycustomer.com"));
            Assert.That(result.TaxNumber, Is.EqualTo(string.Empty));
            Assert.That(result.IsTaxable, Is.True);

            Assert.That(result.ShippingAddress1, Is.EqualTo("Shipp Line 1"));
            Assert.That(result.ShippingAddress2, Is.EqualTo("Shipp Line 2"));
            Assert.That(result.ShippingCity, Is.EqualTo("Shipp City"));
            Assert.That(result.ShippingState, Is.EqualTo("Shipp State"));
            Assert.That(result.ShippingCountry, Is.EqualTo("Germany"));
            Assert.That(result.ShippingPostalCode, Is.EqualTo("2211"));
            Assert.That(result.BillingAddress1, Is.EqualTo("Biill Line 1"));
            Assert.That(result.BillingAddress2, Is.EqualTo("Biill Line 2"));
            Assert.That(result.BillingCity, Is.EqualTo("Biill City"));
            Assert.That(result.BillingState, Is.EqualTo("Bill State"));
            Assert.That(result.BillingCountry, Is.EqualTo("Germany"));
            Assert.That(result.BillingPostalCode, Is.EqualTo("2121"));

            Assert.That(result.Latitude, Is.EqualTo(-33.8265291f));
            Assert.That(result.Longitude, Is.EqualTo(18.5107103f));

            result.VerifyCustomerLinks(CustomerIds.FullyDetailedCustomer);
        }
    }
}