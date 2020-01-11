using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class SkillScore {
        /// <summary>
        /// 
        /// </summary>
        public Int32 Bonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean Trained { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 ArmorPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Misc { get; set; }

        /// <summary></summary>
        [DataMember]
        public String Name { get; set; }
    }
}
