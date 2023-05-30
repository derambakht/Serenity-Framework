using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BehsaApp.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BehsaApp.Administration.LanguageRow;


namespace BehsaApp.Administration
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