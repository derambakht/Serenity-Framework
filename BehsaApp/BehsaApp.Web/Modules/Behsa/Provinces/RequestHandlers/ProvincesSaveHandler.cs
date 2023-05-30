using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.ProvincesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.ProvincesRow;

namespace BehsaApp.Behsa;

public interface IProvincesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProvincesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProvincesSaveHandler
{
    public ProvincesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}