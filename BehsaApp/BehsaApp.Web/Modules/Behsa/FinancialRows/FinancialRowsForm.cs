using Serenity.ComponentModel;
using System;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.FinancialRows")]
[BasedOnRow(typeof(FinancialRowsRow), CheckNames = true)]
public class FinancialRowsForm
{
    public DateTime ChangeDate { get; set; }
    public long Amount { get; set; }
}