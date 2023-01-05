
using System.Globalization;

namespace WsMVVM.Converters;

public class NumberToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            double valueConverted = (double)value;
            if (valueConverted < 90)
                return Colors.Red;
            else if (valueConverted >= 90 && valueConverted < 180)
                return Colors.Blue;
            else if (valueConverted >= 180 && valueConverted < 270)
                return Colors.Green;
            else if (valueConverted >= 270 && valueConverted < 360)
                return Colors.YellowGreen;
        }
        return Colors.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
