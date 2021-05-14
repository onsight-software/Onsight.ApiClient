using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Commands.Customers;
using Onsight.ApiClient.Abstractions.Exceptions;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Tests.Base;

namespace Onsight.ApiClient.Tests.Tests.CustomersClientTests
{
    public class CreateAsyncTests : BaseOnsightApiClientTest<CustomersClient>
    {
        [Test]
        public void IF_name_is_not_provided_SHOULD_throw()
        {
            //Arrange
            var command = new CustomerCreateCommand();

            //Act
            var exception = Assert.ThrowsAsync<HttpResponseException>(async () => await Sut.CreateAsync(command));

            //Assert
            Assert.That(exception!.Message, Is.EqualTo("BadRequest: An customer name is required."));
        }

        [Test]
        public void IF_name_already_exists_SHOULD_throw()
        {
            //Arrange
            var command = new CustomerCreateCommand
            {
                Name = "Limited access customer"
            };

            //Act
            var exception = Assert.ThrowsAsync<HttpResponseException>(async () => await Sut.CreateAsync(command));

            //Assert
            Assert.That(exception!.Message, Is.EqualTo("BadRequest: Duplicate active customer with name is not allowed."));
        }

        [Test]
        public async Task IF_only_name_is_provided_SHOULD_create_with_default_values()
        {
            try
            {
                //Arrange
                var customer = new CustomerCreateCommand
                {
                    Name = "Name Only Customer"
                };

                //Act
                var result = await Sut.CreateAsync(customer);

                //Assert
                Assert.That(result.Id, Is.GreaterThan(1));
                Assert.That(result.Name, Is.EqualTo("Name Only Customer"));
                Assert.That(result.CreatedAt.Date, Is.EqualTo(DateTime.UtcNow.Date));
                Assert.That(result.ModifiedAt, Is.EqualTo(result.CreatedAt));
                Assert.That(result.BillingAddress1, Is.EqualTo(""));
                Assert.That(result.BillingAddress2, Is.EqualTo(""));
                Assert.That(result.BillingPostalCode, Is.EqualTo(""));
                Assert.That(result.BillingCity, Is.EqualTo(""));
                Assert.That(result.BillingState, Is.EqualTo(""));
                Assert.That(result.BillingCountry, Is.EqualTo(""));
                Assert.That(result.ShippingAddress1, Is.EqualTo(""));
                Assert.That(result.ShippingAddress2, Is.EqualTo(""));
                Assert.That(result.ShippingPostalCode, Is.EqualTo(""));
                Assert.That(result.ShippingCity, Is.EqualTo(""));
                Assert.That(result.ShippingState, Is.EqualTo(""));
                Assert.That(result.ShippingCountry, Is.EqualTo(""));
                Assert.That(result.Comment, Is.EqualTo(""));
                Assert.That(result.IsTaxable, Is.EqualTo(true));
                Assert.That(result.TaxNumber, Is.EqualTo(""));
                Assert.That(result.Email, Is.EqualTo(""));
                Assert.That(result.ExternalKey, Is.EqualTo(""));
                Assert.That(result.Latitude, Is.EqualTo(null));
                Assert.That(result.Longitude, Is.EqualTo(null));
            }
            finally
            {
                //Cleanup
                var testCreatedCustomers = await Sut.SearchAsync(new CustomerSearchCommand{Query = "Name Only Customer"});
                foreach (var customerDto in testCreatedCustomers.Results)
                {
                    await Sut.DeleteAsync(customerDto.Id);
                } 
            }  
        }   

        [Test]
        public async Task IF_command_is_valid_SHOULD_create()
        {
            try
            {
                //Arrange
                var customer = new CustomerCreateCommand
                {
                    Name = "Test Create Customer",
                    BillingAddress1 = "B1",
                    BillingAddress2 = "B2",
                    BillingPostalCode = "B3",
                    BillingCity = "B4",
                    BillingState = "B5",
                    BillingCountry = "B6",
                    ShippingAddress1 = "S1",
                    ShippingAddress2 = "S2",
                    ShippingPostalCode = "S3",
                    ShippingCity = "S4",
                    ShippingState = "S5",
                    ShippingCountry = "S6",
                    Comment = "No comment",
                    IsTaxable = true,
                    TaxNumber = "Tax",
                    Email = "email",
                    ExternalKey = "123",
                    GpsCoordinates = "1, 2.1"
                };

                //Act
                var result = await Sut.CreateAsync(customer);

                //Assert
                Assert.That(result.Id, Is.GreaterThan(1));
                Assert.That(result.Name, Is.EqualTo("Test Create Customer"));
                Assert.That(result.CreatedAt.Date, Is.EqualTo(DateTime.UtcNow.Date));
                Assert.That(result.ModifiedAt, Is.EqualTo(result.CreatedAt));
                Assert.That(result.BillingAddress1, Is.EqualTo("B1"));
                Assert.That(result.BillingAddress2, Is.EqualTo("B2"));
                Assert.That(result.BillingPostalCode, Is.EqualTo("B3"));
                Assert.That(result.BillingCity, Is.EqualTo("B4"));
                Assert.That(result.BillingState, Is.EqualTo("B5"));
                Assert.That(result.BillingCountry, Is.EqualTo("B6"));
                Assert.That(result.ShippingAddress1, Is.EqualTo("S1"));
                Assert.That(result.ShippingAddress2, Is.EqualTo("S2"));
                Assert.That(result.ShippingPostalCode, Is.EqualTo("S3"));
                Assert.That(result.ShippingCity, Is.EqualTo("S4"));
                Assert.That(result.ShippingState, Is.EqualTo("S5"));
                Assert.That(result.ShippingCountry, Is.EqualTo("S6"));
                Assert.That(result.Comment, Is.EqualTo("No comment"));
                Assert.That(result.IsTaxable, Is.EqualTo(true));
                Assert.That(result.TaxNumber, Is.EqualTo("Tax"));
                Assert.That(result.Email, Is.EqualTo("email"));
                Assert.That(result.ExternalKey, Is.EqualTo("123"));
                Assert.That(result.Latitude, Is.EqualTo(1));
                Assert.That(result.Longitude, Is.EqualTo(2.1f));
            }
            finally
            {
                //Cleanup
                var testCreatedCustomers = await Sut.SearchAsync(new CustomerSearchCommand{Query = "Test Create Customer"});
                foreach (var customerDto in testCreatedCustomers.Results)
                {
                    await Sut.DeleteAsync(customerDto.Id);
                } 
            }  
        }   
    }
}