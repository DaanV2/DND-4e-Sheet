using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: PowerAttribute</summary>
    [Serializable, DataContract]
    public partial class PowerAttribute {
        /// <summary>Creates a new instance of <see cref="PowerAttribute"/></summary>
        public PowerAttribute() {
            this.Name = String.Empty;
            this.Value = String.Empty;
        }
    }
}
