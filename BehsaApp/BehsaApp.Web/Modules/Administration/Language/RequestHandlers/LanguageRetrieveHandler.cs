using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BehsaApp.Administration.LanguageRow>;
using MyRow = BehsaApp.Administration.LanguageRow;


namespace BehsaApp.Administration
{
    public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
    {
        public LanguageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}