using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Administration.RoleRow>;
using MyRow = BehsaApp.Administration.RoleRow;


namespace BehsaApp.Administration
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