using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.MembersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.MembersRow;

namespace BehsaApp.Behsa;

public interface IMembersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MembersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMembersSaveHandler
{
    public MembersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}