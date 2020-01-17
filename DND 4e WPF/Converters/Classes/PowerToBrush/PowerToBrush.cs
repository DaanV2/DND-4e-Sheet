﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DaanV2.DND.Converters {
    ///DOLATER <summary>add description for class: PowerToBrush</summary>
    public partial class PowerToBrush : IValueConverter {
        private static Brush Default = Brushes.Purple;
        private static Brush Atwill = Brushes.Green;
        private static Brush Encounter = Brushes.Red;
        private static Brush Daily = Brushes.Gray;

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is Power P) {

                if (P.Info.AtWill) { return Atwill; }
                if (P.Info.Encounter) { return Encounter; }
                if (P.Info.Daily) { return Daily; }
            }

            return Default;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
