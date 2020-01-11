using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Power</summary>
    [Serializable, DataContract]
    public partial class Power {
        /// <summary>Creates a new instance of <see cref="Power"/></summary>
        public Power() {
            this.Attributes = new List<PowerAttribute>();
            this.Info = new PowerInformation();
            this.Uses = new Boolean[1];
        }
    }
}
