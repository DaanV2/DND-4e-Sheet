using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for UsesControlCounter.xaml
    /// </summary>
    public partial class UsesControlCounter : UserControl, IViewModel<Uses> {

        public Uses ViewModel { get => (Uses)this.DataContext; set => this.DataContext = value; }

        public UsesControlCounter() {
            this.InitializeComponent();
        }

        private void Add_Click(Object sender, RoutedEventArgs e) {
            this.ViewModel.Used += 1;
        }

        private void Sub_Click(Object sender, RoutedEventArgs e) {
            this.ViewModel.Used -= 1;
        }
    }
}
