using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class SimpleInfo {
        /// <summary>The name of this simple info</summary>
        [DataMember]
        public String Name { get; set; }

        /// <summary>The text of this simple info</summary>
        [DataMember]
        public String Text { get; set; }
    }
}
