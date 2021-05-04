using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Models.Base;
using Onsight.ApiClient.Abstractions.Values;
using Onsight.ApiClient.Tests.Config;

namespace Onsight.ApiClient.Tests.Extensions
{
    public static class DtoExtensions
    {
        public static void VerifyModifiedDto<T>(this T dto, T original) where T : OnsightDto
        {
            Assert.That(dto.Id, Is.EqualTo(original.Id));
            Assert.That(dto.CreatedAt, Is.EqualTo(original.CreatedAt));
            Assert.That(dto.ModifiedAt.Ticks, Is.GreaterThan(original.ModifiedAt));
            Assert.That(dto.Status, Is.EqualTo(original.Status));
            Assert.That(dto.ExternalKey, Is.EqualTo(original.Status));
        }
    }
}