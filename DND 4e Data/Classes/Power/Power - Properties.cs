using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class Power {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PowerAttribute> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean[] Uses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public PowerInformation Info { get; set; }
    }
}
