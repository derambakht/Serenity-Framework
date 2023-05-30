using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("Provinces")]
[DisplayName("Provinces"), InstanceName("Provinces")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed class ProvincesRow : Row<ProvincesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Province Name"), Size(128), NotNull, QuickSearch, NameProperty]
    public string ProvinceName
    {
        get => fields.ProvinceName[this];
        set => fields.ProvinceName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField ProvinceName;

    }
}