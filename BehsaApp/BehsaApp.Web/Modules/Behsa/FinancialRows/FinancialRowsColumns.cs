using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.FinancialRows")]
[BasedOnRow(typeof(FinancialRowsRow), CheckNames = true)]
public class FinancialRowsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public DateTime ChangeDate { get; set; }
    public long Amount { get; set; }
}