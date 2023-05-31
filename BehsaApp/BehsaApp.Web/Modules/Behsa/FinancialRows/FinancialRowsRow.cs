using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("FinancialRows")]
[DisplayName("Financial Rows"), InstanceName("Financial Rows")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class FinancialRowsRow : Row<FinancialRowsRow.RowFields>, IIdRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Change Date"), NotNull]
    public DateTime? ChangeDate
    {
        get => fields.ChangeDate[this];
        set => fields.ChangeDate[this] = value;
    }

    [DisplayName("Amount")]
    public long? Amount
    {
        get => fields.Amount[this];
        set => fields.Amount[this] = value;
    }
    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public DateTimeField ChangeDate;
        public Int64Field Amount;

    }
}