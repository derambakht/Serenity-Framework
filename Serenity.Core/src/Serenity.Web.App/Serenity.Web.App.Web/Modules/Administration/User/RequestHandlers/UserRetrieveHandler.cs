using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity.Web.App.Administration.UserRow>;
using MyRow = Serenity.Web.App.Administration.UserRow;


namespace Serenity.Web.App.Administration
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