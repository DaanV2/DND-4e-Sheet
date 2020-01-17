using System;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for SkillScoreControl.xaml
    /// </summary>
    public partial class SkillScoreControl : UserControl {
        public SkillScoreControl() {
            Console.WriteLine($"{nameof(SkillScoreControl)} Loaded");
            this.InitializeComponent();
        }
    }
}
