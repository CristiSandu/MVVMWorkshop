using WsMVVM.ViewModels;

namespace WsMVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}

