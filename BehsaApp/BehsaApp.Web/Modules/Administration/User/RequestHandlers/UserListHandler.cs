using Serenity.Services;
using MyRequest = BehsaApp.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Administration.UserRow>;
using MyRow = BehsaApp.Administration.UserRow;

namespace BehsaApp.Administration
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