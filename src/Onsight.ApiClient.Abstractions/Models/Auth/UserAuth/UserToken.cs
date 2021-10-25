using System.Text.Json.Serialization;

namespace Onsight.ApiClient.Abstractions.Models.Auth.UserAuth
{
    public class UserToken
    {
        [JsonConstructor]
        public UserToken(string sessionKey)
        {
            SessionKey = sessionKey;
        }

        public string SessionKey { get; }
    }
}

