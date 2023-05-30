using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Behsa.Pages;

[PageAuthorize(typeof(EmployeesRow))]
public class EmployeesPage : Controller
{
    [Route("Behsa/Employees")]
    public ActionResult Index()
    {
        return this.GridPage("@/Behsa/Employees/EmployeesPage",
            EmployeesRow.Fields.PageTitle());
    }
}