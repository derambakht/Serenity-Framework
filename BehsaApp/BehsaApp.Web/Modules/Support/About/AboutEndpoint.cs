using BehsaApp.Behsa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BehsaApp.Web.Modules.Support.About
{
    [Route("Services/Support/About/[action]")]
    [ConnectionKey("Behsa"), ServiceAuthorize(true)]
    public class AboutEndpoint : ServiceEndpoint
    {
        //private readonly IUnitOfWork uow;
        //public AboutEndpoint(IUnitOfWork uow)
        //{
        //    this.uow = uow;
        //}
        [HttpGet]
        public List<MemberDto> GetMembers()
        {
            var factory = HttpContext.RequestServices.GetRequiredService<ISqlConnections>();
            var connection = factory.NewByKey("Behsa");
            var result = connection.Query<MemberDto>("SELECT * FROM BehsaSampleDB.dbo.V_MemberList");
            return result.ToList();
        }
    }
}
