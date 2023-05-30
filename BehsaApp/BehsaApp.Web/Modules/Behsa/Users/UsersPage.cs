using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(UsersRow))]
public class UsersPage : Controller
{
    [Route("Behsa/Users")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/Users/UsersPage",
            UsersRow.Fields.PageTitle());
    }
}