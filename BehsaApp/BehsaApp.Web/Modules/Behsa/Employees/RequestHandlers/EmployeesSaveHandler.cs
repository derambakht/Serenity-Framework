using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Behsa.EmployeesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Behsa.EmployeesRow;

namespace BehsaApp.Behsa;

public interface IEmployeesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EmployeesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesSaveHandler
{
    public EmployeesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}