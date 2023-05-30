using Serenity.ComponentModel;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.Cities")]
[BasedOnRow(typeof(CitiesRow), CheckNames = true)]
public class CitiesForm
{
    public string CityName { get; set; }
    public int ProvinceId { get; set; }
}