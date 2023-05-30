using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(CitiesRow))]
public class CitiesPage : Controller
{
    [Route("Behsa/Cities")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/Cities/CitiesPage",
            CitiesRow.Fields.PageTitle());
    }
}