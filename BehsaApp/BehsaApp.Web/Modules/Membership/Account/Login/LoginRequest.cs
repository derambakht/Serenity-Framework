using Serenity.ComponentModel;
using Serenity.Extensions;
using Serenity.Services;
using System.ComponentModel;

namespace BehsaApp.Membership
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.UserRow), CheckNames = false)]
    public class LoginRequest : ServiceRequest
    {
        [Placeholder("user name")]
        public string Username { get; set; }
        [PasswordEditor, Required(true), Placeholder("password")]
        public string Password { get; set; }
        //[Recaptcha]
        //public string? Recaptcha { get; set; }
    }
}