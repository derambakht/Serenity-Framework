using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.FinancialRowsRow;

namespace BehsaApp.Behsa;

public interface IFinancialRowsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class FinancialRowsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IFinancialRowsDeleteHandler
{
    public FinancialRowsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}