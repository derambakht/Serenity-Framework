using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Serenity.Web.App.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.Web.App.Administration.LanguageRow;


namespace Serenity.Web.App.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}