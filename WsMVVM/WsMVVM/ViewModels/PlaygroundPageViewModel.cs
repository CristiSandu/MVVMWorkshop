using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WsMVVM.ViewModels;

public partial class PlaygroundPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private double sizeValue;

    [ObservableProperty]
    private double rotationValue;

    [ObservableProperty]
    private FontAttributes currentFont;

    List<FontAttributes> Fonts { get; set; } = new List<FontAttributes> { FontAttributes.Bold, FontAttributes.Italic, FontAttributes.None };
    Random rand = new Random();

    public PlaygroundPageViewModel()
    {
        Title = "Playground";
    }

    [RelayCommand]
    private void ChangeFont()
    {
        CurrentFont = Fonts[rand.Next(0, 2)];
    }
}
