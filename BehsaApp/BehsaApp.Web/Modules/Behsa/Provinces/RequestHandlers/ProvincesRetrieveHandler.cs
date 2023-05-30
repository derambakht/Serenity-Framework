using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.ProvincesRow>;
using MyRow = BehsaApp.Behsa.ProvincesRow;

namespace BehsaApp.Behsa;

public interface IProvincesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProvincesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProvincesRetrieveHandler
{
    public ProvincesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}