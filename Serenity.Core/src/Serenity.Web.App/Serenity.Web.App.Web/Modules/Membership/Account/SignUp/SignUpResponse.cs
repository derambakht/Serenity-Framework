using Serenity.Services;

namespace Serenity.Web.App.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}