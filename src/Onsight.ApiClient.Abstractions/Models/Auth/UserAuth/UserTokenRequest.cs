namespace Onsight.ApiClient.Abstractions.Models.Auth.UserAuth
{
    public class UserTokenRequest
    {
        public UserTokenRequest(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }

        public string EmailAddress { get; } 
        public string Password { get; }
    }
}