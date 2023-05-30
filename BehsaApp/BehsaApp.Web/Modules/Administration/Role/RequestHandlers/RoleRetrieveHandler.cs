using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Administration.RoleRow>;
using MyRow = BehsaApp.Administration.RoleRow;


namespace BehsaApp.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}