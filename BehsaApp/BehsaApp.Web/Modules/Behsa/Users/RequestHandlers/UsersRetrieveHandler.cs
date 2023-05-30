using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.UsersRow>;
using MyRow = BehsaApp.Behsa.UsersRow;

namespace BehsaApp.Behsa;

public interface IUsersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class UsersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUsersRetrieveHandler
{
    public UsersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}