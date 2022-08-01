using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Dtos.Base;
using Onsight.ApiClient.Abstractions.Exceptions;
using Onsight.ApiClient.Clients.Base;

namespace Onsight.ApiClient.Tests.Tests.Base
{
    public abstract class BaseGetAsyncTests<TClient, TDto> : BaseOnsightApiClientTest<TClient> 
        where TClient : BaseOnsightApiDtoClient<TDto>
        where TDto : OnsightDto
    {
        [Test]
        public void IF_id_is_invalid_SHOULD_throw()
        {
            //Act
            Assert.ThrowsAsync<HttpResponseException>(async ()=> await Sut.GetAsync(1));
        }
    }
}