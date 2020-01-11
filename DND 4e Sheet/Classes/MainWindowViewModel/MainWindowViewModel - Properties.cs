using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DaanV2.DND {
    public partial class MainWindowViewModel {
        ///DOLATER Add description<summary></summary>
        public Page Current {
            get => this._Current;
            set {
                this._Current = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Current)));
            }
        }
    }
}
