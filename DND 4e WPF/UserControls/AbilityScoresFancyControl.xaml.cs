using System;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for AbilityScoresFancyControl.xaml
    /// </summary>
    public partial class AbilityScoresFancyControl : UserControl {
        public AbilityScoresFancyControl() {
            Console.WriteLine($"{nameof(AbilityScoresFancyControl)} Loaded");
            this.InitializeComponent();
        }
    }
}
