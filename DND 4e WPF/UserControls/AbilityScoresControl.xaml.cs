using System;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for AbilityScoresControl.xaml
    /// </summary>
    public partial class AbilityScoresControl : UserControl {
        public AbilityScoresControl() {
            Console.WriteLine($"{nameof(AbilityScoresControl)} Loaded");
            this.InitializeComponent();
        }
    }
}
