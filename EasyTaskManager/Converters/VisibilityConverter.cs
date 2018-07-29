using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UseAbilities.WPF.Converters.Base;

namespace EasyTaskManager.Converters
{
    public class VisibilityConverter : ConverterBase<VisibilityConverter>
    {
        public VisibilityConverter()
        {
            //
        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool)) throw new Exception("Value is not bool!");

            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
