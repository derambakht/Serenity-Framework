using Serenity.Services;

namespace BehsaApp.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}