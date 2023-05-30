using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.CitiesRow>;
using MyRow = BehsaApp.Behsa.CitiesRow;

namespace BehsaApp.Behsa;

public interface ICitiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CitiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICitiesListHandler
{
    public CitiesListHandler(IRequestContext context)
            : base(context)
    {
    }
}