using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Administration.UserRow>;
using MyRow = BehsaApp.Administration.UserRow;


namespace BehsaApp.Administration
{
    public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
    {
        public UserRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}