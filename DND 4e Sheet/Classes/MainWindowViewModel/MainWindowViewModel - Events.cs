using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DaanV2.DND {
    public partial class MainWindowViewModel : INotifyPropertyChanged {
        ///DOLATER <summary></summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageController_LoadPage(Object sender, Page e) {
            this.Current = e;
        }
    }
}
