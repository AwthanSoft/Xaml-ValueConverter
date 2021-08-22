using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Brush = System.Windows.Media.Brush;

namespace WPFValueConverter.ColorsConverters
{
    
    public sealed class ColorToBrushColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.Drawing.Color)
            {
                /*
                var color = (System.Drawing.Color)value;
                byte AVal = color.A;
                byte RVal = color.R;
                byte GVal = color.G;
                byte BVal = color.B;
                //System.Media.Color.FromArgb(AVal, RVal, GVal, BVal);
                var brush2 = System.Windows.Media.Color.FromArgb(AVal, RVal, GVal, BVal);
                return new SolidColorBrush(brush2);
                */
                var color = (System.Drawing.Color)value;
                return new SolidColorBrush(System.Windows.Media.Color.FromArgb(
                    color.A,
                    color.R,
                    color.G,
                    color.B));
            }
            return Brushes.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                var e = (System.Windows.Media.Color)value;
                return System.Drawing.Color.FromArgb(
                    e.A,
                    e.R,
                    e.G,
                    e.B);
            }
            return System.Drawing.Color.Transparent;
        }
    }
    
}
