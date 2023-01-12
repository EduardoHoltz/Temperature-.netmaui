using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MenuPrincipal
{
    public class Conversao : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double fahrenheit = (double)value;
            double celsius = 0.00;

            if (!ReferenceEquals(fahrenheit, null)){
                celsius = (fahrenheit - 32) * 5 / 9;
            }
            return Math.Round(celsius).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
