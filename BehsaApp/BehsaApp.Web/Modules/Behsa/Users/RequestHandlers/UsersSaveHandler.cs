using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.UsersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.UsersRow;

namespace BehsaApp.Behsa;

public interface IUsersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class UsersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUsersSaveHandler
{
    public UsersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}