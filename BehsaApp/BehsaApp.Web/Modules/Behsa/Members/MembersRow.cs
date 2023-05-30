using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("Members")]
[DisplayName("Members"), InstanceName("Members")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class MembersRow : Row<MembersRow.RowFields>, IIdRow, INameRow
{
    const string jCity = nameof(jCity);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("First Name"), Size(128), NotNull, QuickSearch, NameProperty]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Last Name"), Size(128), NotNull]
    public string LastName
    {
        get => fields.LastName[this];
        set => fields.LastName[this] = value;
    }

    [DisplayName("Birth Date"), NotNull]
    public DateTime? BirthDate
    {
        get => fields.BirthDate[this];
        set => fields.BirthDate[this] = value;
    }

    [DisplayName("Province"), Expression("jCity.[ProvinceId]"), LookupEditor(typeof(ProvincesRow))]
    public int? ProvinceId
    {
        get => fields.ProvinceId[this];
        set => fields.ProvinceId[this] = value;
    }

    [DisplayName("City"), NotNull, ForeignKey("Cities", "Id"), LeftJoin(jCity), TextualField(nameof(CityName))]
    [LookupEditor(typeof(CitiesRow),CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
    public int? CityId
    {
        get => fields.CityId[this];
        set => fields.CityId[this] = value;
    }

    [DisplayName("CityName"), Expression($"{jCity}.[CityName]")]
    public string CityName
    {
        get => fields.CityName[this];
        set => fields.CityName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField FirstName;
        public StringField LastName;
        public DateTimeField BirthDate;
        public Int32Field CityId;

        public StringField CityName;

        public Int32Field? ProvinceId;
    }
}