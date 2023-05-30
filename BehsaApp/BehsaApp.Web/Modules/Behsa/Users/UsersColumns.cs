using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace BehsaApp.Behsa.Columns;

[ColumnsScript("Behsa.Users")]
[BasedOnRow(typeof(UsersRow), CheckNames = true)]
public class UsersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public Guid Id { get; set; }
    [EditLink]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
}