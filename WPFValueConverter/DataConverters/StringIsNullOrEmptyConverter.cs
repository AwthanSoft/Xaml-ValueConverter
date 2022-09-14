using System;
using System.Windows.Data;

namespace WPFValueConverter.DataConverters
{
    public sealed class StringIsNullOrEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                if (value is string ss)
                {
                    return string.IsNullOrEmpty(ss);
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool ss)
            {
                return string.Empty;
            }
            return null;
        }
    }
}
