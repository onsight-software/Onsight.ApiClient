namespace Onsight.ApiClient.Abstractions.Dtos.Common
{
    public record DtoBatch<TDto>(int TotalCount, float TotalPage, TDto[] Results);
}