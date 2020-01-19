using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: SimpleInfo</summary>
    [Serializable, DataContract]
    public partial class SimpleInfo {
        /// <summary>Creates a new instance of <see cref="SimpleInfo"/></summary>
        public SimpleInfo() {
            this.Name = String.Empty;
            this.Text = String.Empty;
        }

        /// <summary>Creates a new instance of <see cref="SimpleInfo"/></summary>
        /// <param name="Name"></param>
        /// <param name="Text"></param>
        public SimpleInfo(String Name, String Text) {
            this.Name = Name;
            this.Text = Text;
        }
    }
}
