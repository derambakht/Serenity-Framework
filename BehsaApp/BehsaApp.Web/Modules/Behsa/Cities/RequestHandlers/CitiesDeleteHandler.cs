using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.CitiesRow;

namespace BehsaApp.Behsa;

public interface ICitiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CitiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICitiesDeleteHandler
{
    public CitiesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}