using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.MembersRow>;
using MyRow = BehsaApp.Behsa.MembersRow;

namespace BehsaApp.Behsa;

public interface IMembersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MembersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMembersListHandler
{
    public MembersListHandler(IRequestContext context)
            : base(context)
    {
    }
}