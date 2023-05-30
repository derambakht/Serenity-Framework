using Serenity.Services;
using MyRequest = Serenity.Web.App.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.Web.App.Administration.UserRow>;
using MyRow = Serenity.Web.App.Administration.UserRow;

namespace Serenity.Web.App.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}