using Serenity.ComponentModel;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.Provinces")]
[BasedOnRow(typeof(ProvincesRow), CheckNames = true)]
public class ProvincesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string ProvinceName { get; set; }
}