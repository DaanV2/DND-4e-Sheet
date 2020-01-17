using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for UsesControl.xaml
    /// </summary>
    public partial class UsesControl : UserControl {
        public UsesControl() {
            Console.WriteLine($"{nameof(UsesControl)} Loaded");
            this.InitializeComponent();
        }

        private void userControl_SizeChanged(Object sender, SizeChangedEventArgs e) {
            if (this.UsesCheckBoxes.Width > e.NewSize.Width) {
                this.UsesCheckBoxes.Visibility = Visibility.Collapsed;
                this.UsesCounter.Visibility = Visibility.Visible;
            }
            else {
                this.UsesCheckBoxes.Visibility = Visibility.Visible;
                this.UsesCounter.Visibility = Visibility.Collapsed;
            }
        }
    }
}
