﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class Details {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 HalfLevel { get => this.Level / 2; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Race { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SimpleInfo> OtherInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int64 XP { get; set; }
    }
}
