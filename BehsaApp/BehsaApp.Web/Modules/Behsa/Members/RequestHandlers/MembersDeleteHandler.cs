using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.MembersRow;

namespace BehsaApp.Behsa;

public interface IMembersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class MembersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMembersDeleteHandler
{
    public MembersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}