using System;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for PowerCollectionControl.xaml
    /// </summary>
    public partial class PowerCollectionControl : UserControl {
        public PowerCollectionControl() {
            Console.WriteLine($"{nameof(PowerCollectionControl)} Loaded");
            this.InitializeComponent();
        }
    }
}
