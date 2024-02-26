using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class MonkeysPage : ContentPage
{
	public MonkeysPage(MonkeysPage vm)
	{
		InitializeComponent();
		this.BindingContext = vm;

	}
}