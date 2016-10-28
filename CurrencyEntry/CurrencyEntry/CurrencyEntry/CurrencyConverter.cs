using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CurrencyEntry.Util
{
    public class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string textValue = value.ToString();
            decimal decimalValue = decimal.Parse(textValue);
            return string.Format(new CultureInfo("tr-TR"), "{0:n0}", decimalValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value.ToString();

            if (string.IsNullOrEmpty(text))
                return 0;

            try
            {
                return decimal.Parse(value.ToString(), new CultureInfo("tr-TR"));
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
