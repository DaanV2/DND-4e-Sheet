using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Uses</summary>
    [Serializable, DataContract]
    public partial class Uses {
        /// <summary>Creates a new instance of <see cref="Uses"/></summary>
        public Uses() {
            this.Used = 0;
            this.Max = 1;
        }

        /// <summary>Creates a new instance of <see cref="Uses"/></summary>
        /// <param name="Max"></param>
        public Uses(Int32 Max) {
            this.Used = 0;
            this.Max = Max;
        }
    }
}
