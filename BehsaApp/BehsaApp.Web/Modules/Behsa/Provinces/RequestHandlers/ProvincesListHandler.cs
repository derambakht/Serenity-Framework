using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.ProvincesRow>;
using MyRow = BehsaApp.Behsa.ProvincesRow;

namespace BehsaApp.Behsa;

public interface IProvincesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProvincesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProvincesListHandler
{
    public ProvincesListHandler(IRequestContext context)
            : base(context)
    {
    }
}