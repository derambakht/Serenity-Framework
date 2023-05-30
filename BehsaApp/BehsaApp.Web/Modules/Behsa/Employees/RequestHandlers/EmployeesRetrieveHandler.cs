using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Behsa.EmployeesRow>;
using MyRow = BehsaApp.Behsa.EmployeesRow;

namespace BehsaApp.Behsa;

public interface IEmployeesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EmployeesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesRetrieveHandler
{
    public EmployeesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}