using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.FinancialRowsRow>;
using MyRow = BehsaApp.Behsa.FinancialRowsRow;

namespace BehsaApp.Behsa;

public interface IFinancialRowsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class FinancialRowsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFinancialRowsRetrieveHandler
{
    public FinancialRowsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}