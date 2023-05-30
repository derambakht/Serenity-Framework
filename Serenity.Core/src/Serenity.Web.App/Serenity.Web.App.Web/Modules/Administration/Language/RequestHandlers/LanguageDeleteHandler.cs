using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity.Web.App.Administration.LanguageRow;


namespace Serenity.Web.App.Administration
{
    public interface ILanguageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

    public class LanguageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageDeleteHandler
    {
        public LanguageDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}