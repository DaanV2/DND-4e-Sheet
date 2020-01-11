using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class Skills {

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SkillScore> Items { get; set; }
    }
}
