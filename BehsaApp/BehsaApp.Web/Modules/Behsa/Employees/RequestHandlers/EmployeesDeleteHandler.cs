using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BehsaApp.Behsa.EmployeesRow;

namespace BehsaApp.Behsa;

public interface IEmployeesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EmployeesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesDeleteHandler
{
    public EmployeesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}