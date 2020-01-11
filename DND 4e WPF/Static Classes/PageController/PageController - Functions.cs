using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: PageController</summary>
    public static partial class PageController {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        public static void Load(Page page) {
            PageController.LoadPage?.Invoke(null, page);
        }
    }
}
