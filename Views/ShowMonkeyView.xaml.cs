using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class ShowMonkeyView : ContentPage
{
	public ShowMonkeyView(ShowMonkeyView vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}