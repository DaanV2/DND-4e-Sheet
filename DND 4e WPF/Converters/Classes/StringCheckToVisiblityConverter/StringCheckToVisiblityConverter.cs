using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DaanV2.DND.Converters {
    ///DOLATER <summary>add description for class: StringCheckToVisiblityConverter</summary>
    public partial class StringCheckToVisiblityConverter : IValueConverter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is String Text) {
                return String.IsNullOrEmpty(Text) ? Visibility.Visible : (Object)Visibility.Collapsed;
            }

            return value == null ? Visibility.Collapsed : (Object)Visibility.Visible;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
