using System.Linq;
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
                Query = "price customer"
            });

            //Assert
            Assert.That(result.Results.Length, Is.EqualTo(3));
            Assert.That(result.Results.FirstOrDefault(x => x.Name == "High AND Low price customer"), Is.Not.Null);
            Assert.That(result.Results.FirstOrDefault(x => x.Name == "Low price customer"), Is.Not.Null);
            Assert.That(result.Results.FirstOrDefault(x => x.Name == "High price customer"), Is.Not.Null);

        }
    }
}