using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(MembersRow))]
public class MembersPage : Controller
{
    [Route("Behsa/Members")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/Members/MembersPage",
            MembersRow.Fields.PageTitle());
    }
}