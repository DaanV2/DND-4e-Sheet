using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class PowerAttribute {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Value { get; set; }
    }
}
