using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity.Web.App.Administration.RoleRow;


namespace Serenity.Web.App.Administration
{
    public interface IRoleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
    {
        public RoleDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}