using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BehsaApp.Behsa.EmployeesRow>;
using MyRow = BehsaApp.Behsa.EmployeesRow;

namespace BehsaApp.Behsa;

public interface IEmployeesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EmployeesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesListHandler
{
    public EmployeesListHandler(IRequestContext context)
            : base(context)
    {
    }
}