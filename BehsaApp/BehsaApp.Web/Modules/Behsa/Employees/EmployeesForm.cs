using Serenity.ComponentModel;
using System;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.Employees")]
[BasedOnRow(typeof(EmployeesRow), CheckNames = true)]
public class EmployeesForm
{
    public string NationalCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}