using MonkeysMVVM.Views;

namespace MonkeysMVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("HomePage", typeof(MonkeysPage));
        Routing.RegisterRoute("ShowMonkey", typeof(ShowMonkeyView));
        Routing.RegisterRoute("FindMonkey", typeof(FindMonkeyByLocationPage));
    }
}
