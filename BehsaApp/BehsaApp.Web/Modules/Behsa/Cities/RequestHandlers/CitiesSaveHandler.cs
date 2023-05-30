using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.CitiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.CitiesRow;

namespace BehsaApp.Behsa;

public interface ICitiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CitiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICitiesSaveHandler
{
    public CitiesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}