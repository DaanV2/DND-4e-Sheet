using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for UsesControl.xaml
    /// </summary>
    public partial class UsesControl : UserControl {
        public UsesControl() {
            this.InitializeComponent();
        }

        private void userControl_SizeChanged(Object sender, SizeChangedEventArgs e) {
            if (this.CheckBoxes.Width > e.NewSize.Width) {
                this.CheckBoxes.Visibility = Visibility.Collapsed;
                this.Counter.Visibility = Visibility.Visible;
            }
            else {
                this.CheckBoxes.Visibility = Visibility.Visible;
                this.Counter.Visibility = Visibility.Collapsed;
            }
        }
    }
}
