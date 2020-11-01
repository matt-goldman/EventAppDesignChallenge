using System;
using System.Globalization;
using Xamarin.Forms;

namespace EventAppDesignChallenge.Converters
{
    public class SelectedToColorConverter : IValueConverter
    {
        public SelectedToColorConverter()
        {

        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true:
                    return (Color)App.Current.Resources["FashionPink"];
                case false:
                    return Color.LightGray;
                default:
                    return Color.LightGray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
