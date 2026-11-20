using System;
using System.Windows.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_Shitov_WPF.Converters
{
    public class WeightConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return String.Empty;
            if (value is float f)
                return System.Convert.ToString(f * 1000);
            if (value is double d)
                return System.Convert.ToString(d * 1000);
            if (float.TryParse(value.ToString(), NumberStyles.Float, culture,
            out float result))
                return System.Convert.ToString(result * 1000);
            return String.Empty;
        }
        public object ConvertBack(object value, Type targetType, object
        parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            if (float.TryParse(value.ToString(), NumberStyles.Float, culture,
            out float result))
                return result / 1000f;
            return null;
        }


    }
}
