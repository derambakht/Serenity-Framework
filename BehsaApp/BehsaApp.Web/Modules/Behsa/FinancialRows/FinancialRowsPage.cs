using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(FinancialRowsRow))]
public class FinancialRowsPage : Controller
{
    [Route("Behsa/FinancialRows")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/FinancialRows/FinancialRowsPage",
            FinancialRowsRow.Fields.PageTitle());
    }
}