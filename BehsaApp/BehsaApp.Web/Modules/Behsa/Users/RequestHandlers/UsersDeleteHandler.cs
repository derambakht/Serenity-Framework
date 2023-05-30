using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.UsersRow;

namespace BehsaApp.Behsa;

public interface IUsersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class UsersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUsersDeleteHandler
{
    public UsersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}