﻿using NUnit.Framework;
using Onsight.ApiClient.Abstractions.Dtos.Base;

namespace Onsight.ApiClient.Tests.Extensions
{
    public static class DtoExtensions
    {
        public static void VerifyModifiedDto<T>(this T dto, T original) where T : OnsightDto
        {
            Assert.That(dto.Id, Is.EqualTo(original.Id));
            Assert.That(dto.CreatedAt, Is.EqualTo(original.CreatedAt));
            Assert.That(dto.ModifiedAt.Ticks, Is.GreaterThan(original.ModifiedAt.Ticks));
            Assert.That(dto.Status, Is.EqualTo(original.Status));
            Assert.That(dto.ExternalKey, Is.EqualTo(original.ExternalKey));
        }
    }
}