using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa;

[ConnectionKey("Behsa"), Module("Behsa"), TableName("Users")]
[DisplayName("Users"), InstanceName("Users")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class UsersRow : Row<UsersRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
    public Guid? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("First Name"), NotNull, QuickSearch, NameProperty]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Last Name"), NotNull]
    public string LastName
    {
        get => fields.LastName[this];
        set => fields.LastName[this] = value;
    }

    [DisplayName("User Name"), NotNull]
    public string UserName
    {
        get => fields.UserName[this];
        set => fields.UserName[this] = value;
    }

    [DisplayName("Password"), NotNull]
    public string Password
    {
        get => fields.Password[this];
        set => fields.Password[this] = value;
    }

    [DisplayName("Salt"), NotNull]
    public string Salt
    {
        get => fields.Salt[this];
        set => fields.Salt[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public GuidField Id;
        public StringField FirstName;
        public StringField LastName;
        public StringField UserName;
        public StringField Password;
        public StringField Salt;

    }
}