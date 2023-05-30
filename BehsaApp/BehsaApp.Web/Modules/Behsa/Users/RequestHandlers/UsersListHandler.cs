using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.UsersRow>;
using MyRow = BehsaApp.Behsa.UsersRow;

namespace BehsaApp.Behsa;

public interface IUsersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class UsersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUsersListHandler
{
    public UsersListHandler(IRequestContext context)
            : base(context)
    {
    }
}