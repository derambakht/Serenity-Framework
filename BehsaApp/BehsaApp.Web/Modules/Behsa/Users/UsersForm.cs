using Serenity.ComponentModel;

namespace BehsaApp.Behsa.Forms;

[FormScript("Behsa.Users")]
[BasedOnRow(typeof(UsersRow), CheckNames = true)]
public class UsersForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
}