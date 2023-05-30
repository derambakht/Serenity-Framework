using Serenity.Services;

namespace Serenity.Web.App.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}