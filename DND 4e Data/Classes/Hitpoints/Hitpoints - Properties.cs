﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class Hitpoints {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 SurgeValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Surges { get; set; }
    }
}
