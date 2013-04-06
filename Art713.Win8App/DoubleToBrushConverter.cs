using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Art713.Win8App
{
    class DoubleToBrushConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is double)
            {
                var doubleVal = (double) value;
                if (doubleVal<40)                
                    return new SolidColorBrush(Colors.Green);
                if (doubleVal > 40 && doubleVal < 80)
                    return new SolidColorBrush(Colors.Yellow);
                return new SolidColorBrush(Colors.Red);
            }
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
