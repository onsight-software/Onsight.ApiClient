using System;

namespace Onsight.ApiClient.Abstractions.Models.Auth
{
    public class TokenResponse
    {
        public TokenResponse(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }

        public string Token { get; }
        public DateTime Expiration { get; }
    }
}