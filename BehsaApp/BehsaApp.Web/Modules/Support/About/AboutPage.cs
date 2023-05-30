using BehsaApp.Web.Modules.Support.About;
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace BehsaApp.Support.Pages;

//[PageAuthorize(typeof(FinancialRowsRow))]
public class AboutPage : Controller
{
    //private readonly AboutEndpoint aboutEndpoint;
    //public AboutPage(AboutEndpoint aboutEndpoint)
    //{
    //    this.aboutEndpoint = aboutEndpoint;
    //}
    [Route("Support/About")]
    public ActionResult Index()
    {
        //var dataResult = aboutEndpoint.GetMembers();

        return View("/Modules/Support/About/Index.cshtml");
    }

   
}