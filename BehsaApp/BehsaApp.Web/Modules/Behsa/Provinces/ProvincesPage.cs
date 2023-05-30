using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(ProvincesRow))]
public class ProvincesPage : Controller
{
    [Route("Behsa/Provinces")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/Provinces/ProvincesPage",
            ProvincesRow.Fields.PageTitle());
    }
}