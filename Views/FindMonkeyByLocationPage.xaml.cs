using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class FindMonkeyByLocationPage : ContentPage
{
	public FindMonkeyByLocationPage(FindMonkeyByLocationPage vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}