using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.Members")]
[BasedOnRow(typeof(MembersRow), CheckNames = true)]
public class MembersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [QuickFilter]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    [FilterOnly, QuickFilter]
    public int? ProvinceId { get; set; }
    [Width(150), QuickFilter, QuickFilterOption("CascadeFrom", "ProvinceId")]
    public string CityName { get; set; }
}