using Serenity.ComponentModel;
using System;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.Members")]
[BasedOnRow(typeof(MembersRow), CheckNames = true)]
public class MembersForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int? ProvinceId { get; set; }
    public int CityId { get; set; }
}