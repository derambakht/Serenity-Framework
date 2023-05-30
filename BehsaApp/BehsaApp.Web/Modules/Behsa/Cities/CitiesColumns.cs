using Serenity.ComponentModel;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.Cities")]
[BasedOnRow(typeof(CitiesRow), CheckNames = true)]
public class CitiesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string CityName { get; set; }
    [EditLink(ItemType = "Demo.Northwind.Provinces"), Width(150), QuickFilter, QuickFilterOption("multiple", true)]
    public string ProvinceName { get; set; }
}