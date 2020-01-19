using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for TitleTextBoxVertical.xaml
    /// </summary>
    public partial class TitleTextBoxVertical : UserControl {
        public TitleTextBoxVertical() {
            
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TitleTextProperty =
            DependencyProperty.Register("TitleText", typeof(Object), typeof(TitleTextBoxVertical));

        public static readonly DependencyProperty TextValueProperty =
            DependencyProperty.Register("TextValue", typeof(Object), typeof(TitleTextBoxVertical));

        public static readonly DependencyProperty TitleBackgroundProperty =
            DependencyProperty.Register("TitleBackground", typeof(Brush), typeof(TitleTextBoxVertical));

        public Object TextValue {
            get { return (String)this.GetValue(TextValueProperty); }
            set { this.SetValue(TextValueProperty, value); }
        }

        public Object TitleText {
            get { return (String)this.GetValue(TitleTextProperty); }
            set { this.SetValue(TitleTextProperty, value); }
        }

        public Brush TitleBackground {
            get { return (Brush)this.GetValue(TitleBackgroundProperty); }
            set { this.SetValue(TitleBackgroundProperty, value); }
        }
    }
}
