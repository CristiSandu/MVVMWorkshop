using WsMVVM.ViewModels;

namespace WsMVVM.Views;

public partial class PlaygroundPage : ContentPage
{
    public PlaygroundPage(PlaygroundPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}