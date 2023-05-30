using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.Web.App.Administration.LanguageRow>;
using MyRow = Serenity.Web.App.Administration.LanguageRow;


namespace Serenity.Web.App.Administration
{
    public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
    {
        public LanguageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}