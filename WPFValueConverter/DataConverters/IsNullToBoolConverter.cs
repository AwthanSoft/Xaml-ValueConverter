using System;
using System.Windows.Data;

namespace WPFValueConverter.DataConverters
{
    public class IsNullToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return false;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool ss)
            {
                if (ss)
                    return string.Empty;
            }
            return null;
        }
    }
}
