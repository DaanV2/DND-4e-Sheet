using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for TitleTextBox.xaml
    /// </summary>
    public partial class TitleTextBox : UserControl {
        public TitleTextBox() {
            Console.WriteLine($"{nameof(TitleTextBox)} Loaded");
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TitleTextProperty =
            DependencyProperty.Register("TitleText", typeof(String), typeof(TitleTextBox));

        public static readonly DependencyProperty TextValueProperty =
            DependencyProperty.Register("TextValue", typeof(Object), typeof(TitleTextBox));
        
        public String TextValue {
            get { return (String)this.GetValue(TextValueProperty); }
            set { this.SetValue(TextValueProperty, value); }
        }

        public Object TitleText {
            get { return (String)this.GetValue(TitleTextProperty); }
            set { this.SetValue(TitleTextProperty, value); }
        }
    }
}
