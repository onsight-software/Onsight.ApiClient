using System;

namespace Onsight.ApiClient.Abstractions.Models.Auth.SubscriberAuth
{
    public class SubscriberToken
    {
        public SubscriberToken(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }

        public string Token { get; }
        public DateTime Expiration { get; }
    }
}