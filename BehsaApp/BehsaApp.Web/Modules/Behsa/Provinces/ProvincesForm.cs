using Serenity.ComponentModel;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.Provinces")]
[BasedOnRow(typeof(ProvincesRow), CheckNames = true)]
public class ProvincesForm
{
    public string ProvinceName { get; set; }
}