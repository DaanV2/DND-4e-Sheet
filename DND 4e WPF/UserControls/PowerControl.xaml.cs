using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for PowerControl.xaml
    /// </summary>
    public partial class PowerControl : UserControl, IViewModel<Power> {

        public Power ViewModel { get => (Power)this.DataContext; set => this.DataContext = value; }

        public PowerControl() {
            this.InitializeComponent();
        }
    }
}
