using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using lab_2_b.Model;

namespace lab_2_b.Helper
{
    [ValueConversion(typeof(int), typeof(Brushes))]
    public class AnnualSalesToBrushConverter : IValueConverter
    {
        public static AnnualSalesToBrushConverter AsTBConverter = new AnnualSalesToBrushConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int annualSales = (int)value;
            if (annualSales > 300)
            {
                return Brushes.Yellow;
            }
            else
            {
                return Brushes.Green;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
