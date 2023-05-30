using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("Employees")]
[DisplayName("Employees"), InstanceName("Employees")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class EmployeesRow : Row<EmployeesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("National Code"), Size(15), QuickSearch, NameProperty]
    public string NationalCode
    {
        get => fields.NationalCode[this];
        set => fields.NationalCode[this] = value;
    }

    [DisplayName("First Name"), Size(128)]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Last Name")]
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

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField NationalCode;
        public StringField FirstName;
        public StringField LastName;
        public DateTimeField BirthDate;

    }
}