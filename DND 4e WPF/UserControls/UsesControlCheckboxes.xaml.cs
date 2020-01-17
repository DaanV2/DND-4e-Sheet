using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>Interaction logic for UsesControlCheckboxes.xaml</summary>
    public partial class UsesControlCheckboxes : UserControl, IViewModel<Uses> {
        public Uses ViewModel { get => (Uses)this.DataContext; set => this.DataContext = value; }

        public UsesControlCheckboxes() {
            Console.WriteLine($"{nameof(UsesControlCheckboxes)} Loaded");
            this.InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userControl_DataContextChanged(Object sender, DependencyPropertyChangedEventArgs e) {
            if (this.MainGrid == null)
                return;

            this.MainGrid.Children.Clear();

            if (this.ViewModel != null) {
                Uses uses = this.ViewModel;

                for (Int32 I = 0; I < uses.Max; I++) {
                    CheckBox CB = new CheckBox {
                        IsChecked = I < uses.Used
                    };

                    CB.Checked += this.CB_Checked;
                    CB.Unchecked += this.CB_Unchecked;

                    this.MainGrid.Children.Add(CB);
                }
            }
        }

        private void CB_Unchecked(Object sender, RoutedEventArgs e) {
            if (this.ViewModel != null) {
                this.ViewModel.Used--;
            }
        }

        private void CB_Checked(Object sender, RoutedEventArgs e) {
            if (this.ViewModel != null) {
                this.ViewModel.Used++;
            }
        }
    }
}
