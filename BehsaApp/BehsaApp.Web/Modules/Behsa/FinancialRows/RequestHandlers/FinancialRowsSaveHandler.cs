using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.FinancialRowsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.FinancialRowsRow;

namespace BehsaApp.Behsa;

public interface IFinancialRowsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class FinancialRowsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFinancialRowsSaveHandler
{
    public FinancialRowsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}