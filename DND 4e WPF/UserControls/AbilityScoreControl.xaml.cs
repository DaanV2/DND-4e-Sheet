using System;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for AbilityScoreControl.xaml
    /// </summary>
    public partial class AbilityScoreControl : UserControl {
        public AbilityScoreControl() {
            InitializeComponent();
        }

        public String Title { get; set; }
    }
}
