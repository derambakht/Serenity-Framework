using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("Cities")]
[DisplayName("Cities"), InstanceName("Cities")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]

public sealed class CitiesRow : Row<CitiesRow.RowFields>, IIdRow, INameRow
{
    const string jProvince = nameof(jProvince);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("City Name"), Size(256), NotNull, QuickSearch, NameProperty]
    public string CityName
    {
        get => fields.CityName[this];
        set => fields.CityName[this] = value;
    }

    [DisplayName("Province"), ForeignKey(typeof(ProvincesRow)), LeftJoin("prov"), LookupInclude]
    [LookupEditor(typeof(ProvincesRow), InplaceAdd = true, DialogType = "Demo.Northwind.ProvinceDialog")]
    public int? ProvinceId
    {
        get => fields.ProvinceId[this];
        set => fields.ProvinceId[this] = value;
    }


    [Origin("prov"), DisplayName("Province")]
    public string ProvinceName
    {
        get => fields.ProvinceName[this];
        set => fields.ProvinceName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField CityName;
        public Int32Field ProvinceId;

        public StringField ProvinceName;
    }
}