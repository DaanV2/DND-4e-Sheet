using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanV2.DND;
using DaanV2.DND.Pages;

namespace DaanV2.DND {
    ///DOLATER <summary>Add description for class: MainWindowViewModel</summary>
    public partial class MainWindowViewModel {
        /// <summary>Creates a new instance of <see cref="MainWindowViewModel"/></summary>
        public MainWindowViewModel() {
            this.Current = new StartPage();
            PageController.LoadPage += this.PageController_LoadPage;
        }
    }
}
