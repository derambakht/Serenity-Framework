using Serenity.Navigation;
using MyPages = BehsaApp.Behsa.Pages;

[assembly: NavigationLink(int.MaxValue, "Behsa/Employees", typeof(MyPages.EmployeesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Behsa/Financial Rows", typeof(MyPages.FinancialRowsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Behsa/Users", typeof(MyPages.UsersPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Behsa/Cities", typeof(MyPages.CitiesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Behsa/Members", typeof(MyPages.MembersPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Behsa/Provinces", typeof(MyPages.ProvincesPage), icon: null)]