using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace lab_2_b.Helper
{
    [ValueConversion(typeof(int), typeof(Brushes))]
    public class IntegerToBrushConverter : IValueConverter
    {
        public static IntegerToBrushConverter ITBConverter = new IntegerToBrushConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int quantity = (int)value;
            if (quantity > 1000)
            {
                return Brushes.Aquamarine;
            } 
            else
            {
                return Brushes.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
