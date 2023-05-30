using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.Web.App.Administration.RoleRow>;
using MyRow = Serenity.Web.App.Administration.RoleRow;


namespace Serenity.Web.App.Administration
{
    public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
    {
        public RoleListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}