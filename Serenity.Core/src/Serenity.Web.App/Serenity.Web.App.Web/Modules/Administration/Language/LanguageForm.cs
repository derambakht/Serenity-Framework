using Serenity.ComponentModel;
using System;

namespace Serenity.Web.App.Administration.Forms
{
    [FormScript("Administration.Language")]
    [BasedOnRow(typeof(LanguageRow), CheckNames = true)]
    public class LanguageForm
    {
        public String LanguageId { get; set; }
        public String LanguageName { get; set; }
    }
}