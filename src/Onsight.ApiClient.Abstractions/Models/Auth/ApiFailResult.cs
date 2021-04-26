namespace Onsight.ApiClient.Abstractions.Models.Auth
{
    public class ApiFailResult
    {
        public ApiFailResult(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}