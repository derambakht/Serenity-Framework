using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.ProvincesRow;

namespace BehsaApp.Behsa;

public interface IProvincesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProvincesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProvincesDeleteHandler
{
    public ProvincesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}