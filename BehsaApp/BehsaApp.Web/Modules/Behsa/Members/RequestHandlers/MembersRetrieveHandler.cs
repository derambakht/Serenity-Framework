using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.MembersRow>;
using MyRow = BehsaApp.Behsa.MembersRow;

namespace BehsaApp.Behsa;

public interface IMembersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MembersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMembersRetrieveHandler
{
    public MembersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}