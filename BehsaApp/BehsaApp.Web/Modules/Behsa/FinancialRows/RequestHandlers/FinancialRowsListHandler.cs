using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.FinancialRowsRow>;
using MyRow = BehsaApp.Behsa.FinancialRowsRow;

namespace BehsaApp.Behsa;

public interface IFinancialRowsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class FinancialRowsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFinancialRowsListHandler
{
    public FinancialRowsListHandler(IRequestContext context)
            : base(context)
    {
    }
}