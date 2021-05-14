using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Commands.Customers;
using Onsight.ApiClient.Clients;
using Onsight.ApiClient.Tests.Tests.Base;

namespace Onsight.ApiClient.Tests.Tests.CustomersClientTests
{
    public class SearchAsyncTests : BaseOnsightApiClientTest<CustomersClient>
    {
        [Test]
        public async Task If_customers_exist_SHOULD_return()
        {
            //Act
            var result = await Sut.SearchAsync(new CustomerSearchCommand
            {
                Query = "customer"
            });

            //Assert
            Assert.That(result.Results.Length, Is.EqualTo(6));

        }
    }
}