using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.CitiesRow>;
using MyRow = BehsaApp.Behsa.CitiesRow;

namespace BehsaApp.Behsa;

public interface ICitiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CitiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICitiesRetrieveHandler
{
    public CitiesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}