using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Details</summary>
    [Serializable, DataContract]
    public partial class Details {
        /// <summary>Creates a new instance of <see cref="Details"/></summary>
        public Details() {
            this.Class = String.Empty;
            this.Level = 1;
            this.Name = String.Empty;
            this.OtherInfo = new List<SimpleInfo>();
            this.Race = String.Empty;
            this.XP = 0;
        }
    }
}
