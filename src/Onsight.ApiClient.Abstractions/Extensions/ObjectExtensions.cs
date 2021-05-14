using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Onsight.ApiClient.Abstractions.Extensions
{
    public static class ObjectExtensions
    {
        public static HttpContent ToHttpContent<T>(this T objectToSerialize)
        {
            var json = JsonSerializer.Serialize(objectToSerialize);
            return new StringContent(json, new UTF8Encoding(), "application/json");
        }
    }
}