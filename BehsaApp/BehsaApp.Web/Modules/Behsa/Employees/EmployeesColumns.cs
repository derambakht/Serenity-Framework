using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.Employees")]
[BasedOnRow(typeof(EmployeesRow), CheckNames = true)]
public class EmployeesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string NationalCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}