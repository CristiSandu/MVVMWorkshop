using System.Windows.Input;

namespace WsMVVM.ViewModels;

public class PlaygroundPageViewModel : BaseViewModel
{
    private double sizeValue;

    public double SizeValue
    {
        get => sizeValue;
        set
        {
            if (sizeValue != value)
            {
                sizeValue = value;
                OnPropertyChanged(nameof(SizeValue));
            }
        }
    }

    private double rotationValue;

    public double RotationValue
    {
        get => rotationValue;
        set
        {
            if (rotationValue != value)
            {
                rotationValue = value;
                OnPropertyChanged(nameof(RotationValue));
            }
        }
    }

    private FontAttributes currentFont;

    public FontAttributes CurrentFont
    {
        get => currentFont;
        set
        {
            if (currentFont != value)
            {
                currentFont = value;
                OnPropertyChanged(nameof(CurrentFont));
            }
        }
    }


    List<FontAttributes> Fonts { get; set; } = new List<FontAttributes> { FontAttributes.Bold, FontAttributes.Italic, FontAttributes.None };
    Random rand = new Random();
    public ICommand ChangeFontCommand { get; set; }

    public PlaygroundPageViewModel()
    {
        Title = "Playground";

        ChangeFontCommand = new Command(() =>
        {
            CurrentFont = Fonts[rand.Next(0,2)];
        });
    }
}
