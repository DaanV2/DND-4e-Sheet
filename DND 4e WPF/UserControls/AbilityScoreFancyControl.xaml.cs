using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for AbilityScoreFancyControl.xaml
    /// </summary>
    public partial class AbilityScoreFancyControl : UserControl, INotifyPropertyChanged {

        private String _Title;

        public event PropertyChangedEventHandler PropertyChanged;

        public AbilityScoreFancyControl() {
            this.Title = String.Empty;
            this.InitializeComponent();
        }

        public String Title {
            get => this._Title;
            set {
                this._Title = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Title)));
            }
        }
    }
}
